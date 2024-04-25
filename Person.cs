using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_L6_Notes_Week4
{
    public class Person
    {
        //fields
        string _firstName;
        string _lastName;
        List<string> _personalList;

        //constructor
        public Person(string firstName, string lastName, List<string> personalList)
        {
            _firstName = firstName;
            _lastName = lastName;
            _personalList = personalList;
        }

        //properties
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public List<string> PersonalList { get => _personalList; set => _personalList = value; }



        //method
        public override string ToString()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
