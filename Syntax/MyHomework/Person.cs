using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    internal class Person
    {
        protected string lastName, firstName;
        protected DateTime DateOfBirth;


        public Person(string lastName, string firstName, DateTime dateOfBirth)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.DateOfBirth = dateOfBirth;

        }
    }
}
