using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_Contact
{
    public class Contact
    {
        public string Name { get; set; }
        public string Phno { get; set; }
        public string Email { get; set; }
        public string Relation { get; set; }
        public bool isFavourite { get; set; }
        public Contact(string _name, string _phno, string _email, string _relation, bool _isFavourite)
        {
            Name = _name;
            Phno = _phno;
            Email = _email;
            Relation = _relation;
            isFavourite = _isFavourite;
        }
    }
}
