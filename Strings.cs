using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Huzaifa";
            var lastName = "Shah";
            var fullName1 = name + " " + lastName;                                  //M1
            Console.WriteLine(fullName1);
            var fullName2 = string.Format("{0} {1}  " , name , lastName);           //M2
            Console.WriteLine(fullName2);


        }
    }
}
