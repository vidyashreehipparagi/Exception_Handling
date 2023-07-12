
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exception_Handling.Student;

namespace Exception_Handling
{
    public class Program
    {
       


        static void Main(string[] args)
        {
          Student stud = new Student();
            try
            {
                stud.AcceptDetails("  ", 17);

            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                stud.AcceptDetails("", 18);
            }
            catch(NameException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
