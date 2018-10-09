using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9_FieldVariables
{
    class Program
    {
        // Fields are generally declared here, at the top of the class
        // so that they are accessible to all of the following methods and code 

        // Fields are declared like local variables, plus they have a modifier
        private int number = 0;
        // The private modifier means that any code outside of the class cannot see it
        // but any code inside the class, including methods, can see it

        // Lifetime of a field
        // the lifetime of a field variable is the entire time that the class exists
        // by comparison, a regular variable's lifetime is only while the method is running

        // Constant Fields
        // fields for whose values cannot be changed
        // create it like a normal const, and remember to declare it private
        private const string MY_CONST_FIELD = "I cannot be changed!";




        static void Main(string[] args)
        {
            // Chapter 3.9 Declaring Variables as Fields, p. 165

            // A field is a variable scoped to a class, as opposed to a method
            // A local variable is a variable declared inside a method

        }
    }
}
