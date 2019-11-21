using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TORA_Affiliation.Models
{
    class AffiTransaction
    {
        public int Id { get; set; }

        /// <summary>
        /// A character with value 'D' or 'C' (Debit/Credit).
        /// </summary>
        public char TransactionTypeId { get; set; }

        /// <summary>
        /// The timestamp of the transaction.
        /// </summary>
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string InvoicingId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// A character with value '1' or '2' ( 1 = Cash, 2 = Card )
        /// </summary>
        public char PaymentMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal TransactionAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal CommissionAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Count { get; set; }
    }
}
