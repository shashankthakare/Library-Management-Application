using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
   public class LogBook
    {

    }

    public class Transaction
    {
        public TimeSpan Span;

        public int BookId;

        public int UserId;

        public int LibrararianId;

        public BookStatus Status;

    }

    public enum BookStatus
    {
        Unkown,
        Issued,
        Returned,
        Lost,

    }
}
