using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Student
    {
        public class AgeException : Exception
        {
            public AgeException(string message) : base(message)
            {
            }
        }
        public class NameException : Exception
        {
            public NameException(string message) : base(message)
            {

            }
        }
        private string name;
        private int age;

        public void AcceptDetails(string name, int age)
        {
            if (age < 18)
            {
                throw new AgeException("Your age is not valid");
            }
            if (string.IsNullOrEmpty(name))
            {
               throw new NameException("Please mention name");
            }
            else
            {
                this.name = name;
                this.age = age;
            }
        }
    }
}
