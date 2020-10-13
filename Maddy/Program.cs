using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maddy
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is a comment
            string x;
            string string1 = "My name is Jonathan.";
            string string2 = "5894 Blackwell Rd";

            //this is where I'm doing something stupid
            int number = 1;
            bool isChecked;
            double number1 = 1.1;

            Console.WriteLine(string1);

            isChecked = true;
            x = "blah";

            string string3 = stringFunction();

            if(number == 1)
            {
                string blah = "foo";
                number = 0;
                Console.WriteLine("number equals 1");
                Console.WriteLine(blah);
            }
            else if(number == 0)
            {
                Console.WriteLine("number equals 0");
            }
            else
            {
                Console.WriteLine("number doesn't equal 1");
            }

            while(number < 5)
            {
                number++;
            }

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }


            List<string> strings = new List<string>();
            strings.Add("hi");
            strings.Add(string1);
            strings.Add(string2);
            
            foreach(string temp in strings)
            {
                string newString = string.Concat(temp, "bob");
                Console.WriteLine(newString);
            }
            Console.ReadLine();

            if(isOkay(number, "no"))
            {

            }
        }

        void tempFunction()
        {
        }

        static string stringFunction()
        {
            string returnValue = "";


            return returnValue;
        }

        static bool isOkay(int x, string test)
        {
            //Class1 myClass1 = new Class1();
            //string temp = myClass1.GiveMeData();
            //string temp = Class1.GiveMeData();
            return x > 0;
        }
    }
}
