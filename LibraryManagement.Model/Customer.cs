using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    public class Customer : User
    {
        private int _membershipId;
        public int MembershipId
        {
            get { return _membershipId; }
           private set { _membershipId = value; }
        }

        public DateTime JoiningDate
        {
            get { return _joiningDate; }
            set { _joiningDate = value; }
        }

        public DateTime ExpiryDate
        {
            get { return _expiryDate; }
            set { _expiryDate = value; }
        }

        public UserType CustomerType
        {
            get { return _customerType; }
            set { _customerType = value; }
        }

        private DateTime _joiningDate;
        private DateTime _expiryDate;
        private UserType _customerType;


        public bool IsExpired()
        {
            TimeSpan dateSpan = ExpiryDate - JoiningDate;
            return dateSpan.TotalDays > 0;

        }


    }

    
}
