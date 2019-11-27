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
    class MainCreator 
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

            var sendError = new MailSender();
            sendError.SendConfirmMail($"Affiliation Service Started Running \r\n {DateTime.Now}");

            try
            {
                if (TransactionCheck())
                {
                    if (FillAffiTransaction())
                    {
                        _logger.Info("Affiliation Service Terminating. Bye-Bye");
                    }
                    
                }
                else
                {
                    _logger.Info("No transactions found Application Terminate");
                    var sendInfo = new MailSender();
                    sendInfo.SendConfirmMail("No transactions found Application Terminate");
                    return true;

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
            _logger.Info("Getting Data from CMS_Transactions " + 
                "  " + "to Aggregate to AffiTransactions");


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
                                    + "  " + "Aggregation process ended");

                        var mail = new MailSender();
                        mail.SendConfirmMail("Affiliation Transactions Were Successfully Added To Affiliation Table \r\n Aggregation process ended");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    _logger.Error(ex.Message, ex);
                    var mail = new MailSender();
                    mail.SendErrorMail($"Affiliation Transactions Failed To Be Added To Affiliation Table \r\n Aggregation process ended");
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }

        }

        private bool TransactionCheck()
        {
            var config = Config.ReadConfig();
            var connectionsStr = $"Data Source = {config.SQLServerName};" +
                                 $"Initial Catalog = {config.SQLDatabaseName};" +
                                 $"User ID = {config.SQLUsername};" +
                                 $"Password = {Crypto.ToInsecureString(config.SQLPassword)}";
            var query = string.Format(Queries.Queries.TransactionCheck, config.SQLDatabaseName);

            var connection = new SqlConnection(connectionsStr);

            int result = 0;

            try
            {
                using(var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.CommandTimeout = 0; 
                    result = (Int32)command.ExecuteScalar();
                }

                if(result <= 0)
                {
                    return false;
                }
                else { return true; }
            }
            catch(Exception e)
            {
                _logger.Error(e.Message, e);
                return false;
            }
            finally
            {
                connection.Close();
            }

            
        }
    }
}
