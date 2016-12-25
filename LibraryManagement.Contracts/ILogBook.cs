using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Model;

namespace LibraryManagement.Contracts
{
    interface ILogBook
    {
        void AddTransaction(Librarian librarian,  Transaction transaction );

        List<Transaction> RetrieveTransaction(Librarian librarian, TransactionSearchCriterion criterion);




    }
}
