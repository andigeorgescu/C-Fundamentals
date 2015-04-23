using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    internal class Person
    {
        protected string LastName, FirstName;
        protected DateTime? DateOfBirth;

        public Person()
        {
            this.LastName = null;
            this.FirstName = null;
            this.DateOfBirth = null;
        }

        public Person(string lastName, string firstName, DateTime dateOfBirth)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.DateOfBirth = dateOfBirth;

        }
    }
}
