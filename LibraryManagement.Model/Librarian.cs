using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    public class Librarian : User
    {
        public UserType Type;

        public Librarian(int id, string name, string emailId, UserType type)
        {
            Id = id;
            Name = name;
            EmailID = emailId;
            if (type == UserType.AdminLibrarian || type == UserType.Librarian)
                Type = type;
            else
                throw new Exception("Not a valid Librarian");
        }


    }
}
