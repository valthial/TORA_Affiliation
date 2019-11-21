using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TORA_Affiliation.Models;

namespace TORA_Affiliation.Interfaces
{
    interface ICreator
    {

        /// <summary>
        /// Get entries from AffiTransactions that have not been created as Journal Entries
        /// </summary>
        /// <returns></returns>
        List<AffiTransaction> GetAffiTransactions();
    }
}
