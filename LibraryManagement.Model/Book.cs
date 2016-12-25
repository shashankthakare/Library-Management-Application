using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    public class Book
    {


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private int _id;
        private string _name;
        private string _author;
        private string _category;

        public int Id
        {
            get { return _id; }
           
        }

        


        public Book(int id, string name, string author, string category)
        {
            _id = id;
            Name = name;
            //..
        }
    }
}
