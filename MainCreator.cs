using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using TORA_Affiliation.Controllers;
using TORA_Affiliation.Controllers.Log;
using TORA_Affiliation.Controllers.Mail;
using TORA_Affiliation.Interfaces;
using TORA_Affiliation.Models;

namespace TORA_Affiliation
{
    class MainCreator : ICreator
    {
        private ILogger _logger;


        public MainCreator()
        {
            _logger = new TraceLogger();
        }

        public bool Create()
        {
            _logger.EmptyLine();
            _logger.Info("Affiliation Service Started Running");

            var mail = new MailSender();
            mail.SendConfirmMail("Affiliation Service Started Running");

            try
            {
                if (FillAffiTransaction())
                {
                    var transactions = GetAffiTransactions();
                    if (transactions.Any())
                    {
                        _logger.Info("Affiliation Service Terminating. Bye-Bye");
                    }
                    else
                    {
                        _logger.Info("No Transactions to Add. My job is done here. Bye-Bye");
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message, ex);
            }
            return true;



        }

        private bool FillAffiTransaction()
        {
            _logger.Info("Getting Data from CMS_Transactions "
                     + "to Aggregate to AffiTransactions");


            var config = Config.ReadConfig();
            var connectionsStr = $"Data Source = {config.SQLServerName};" +
                                 $"Initial Catalog = {config.SQLDatabaseName};" +
                                 $"User ID= {config.SQLUsername};" +
                                 $"Password= {Crypto.ToInsecureString(config.SQLPassword)}";

            var query = string.Format(Queries.Queries.AddEntriesToAffiliation
                                  , config.SboDatabaseName);

            using (var sqlConnection = new SqlConnection(connectionsStr))
            {

                try
                {
                    using (var sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlConnection.Open();
                        // set query execution timeout to infinite
                        sqlCommand.CommandTimeout = 0;
                        // execute query
                        sqlCommand.ExecuteNonQuery();
                        _logger.Info("Entries added successfully to Affiliation_Transactions "
                                   // + "and @TORA_SELFBILLINGS tables. "
                                    + "Aggregation process ended");

                        var mail = new MailSender();
                        mail.SendConfirmMail("Entries added successfully to Affiliation_Transactions "
                                                + "Aggregation process ended");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    _logger.Error(ex.Message, ex);
                    var mail = new MailSender();
                    mail.SendErrorMail("Affiliation_Transactions failed to add entries"
                                            + "Aggregation process ended");
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }

        }
        public List<AffiTransaction> GetAffiTransactions()
        {
            var config = Config.ReadConfig();
            var connectionsStr = $"Data Source = {config.SQLServerName};" +
                                 $"Initial Catalog = {config.SQLDatabaseName};" +
                                 $"User ID = {config.SQLUsername};" +
                                 $"Password = {Crypto.ToInsecureString(config.SQLPassword)}";
            var query = Queries.Queries.GetAffiTransations;
            var AffiTransactions = new List<AffiTransaction>();

            using (var connection = new SqlConnection(connectionsStr))
            {
                try
                {

                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (var reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                var trans = new AffiTransaction();
                                trans.Id = Convert.ToInt32(reader["ID"]);
                                trans.TransactionTypeId = reader["TransactionTypeID"].ToString()[0];
                                var transDate = reader["TransactionDate"];

                                if (transDate != DBNull.Value)
                                {
                                    trans.TransactionDate = Convert.ToDateTime(reader["TransactionDate"]);
                                }

                                trans.InvoicingId = reader["InvoicingID"].ToString();
                                trans.ProductId = reader["ProductID"].ToString();
                                trans.Quantity = Convert.ToInt32(reader["Quantity"]);
                                trans.PaymentMethod = reader["PaymentMethod"].ToString()[0];
                                trans.TransactionAmount = Convert.ToDecimal(reader["TransactionAmount"]);
                                trans.CommissionAmount = Convert.ToDecimal(reader["CommissionAmount"]);
                                trans.Count = Convert.ToInt32(reader["Count"]);

                                AffiTransactions.Add(trans);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.Error(ex.Message, ex);
                }
                finally
                {
                    connection.Close();
                }

            }

            return AffiTransactions;

        }
    }
}
