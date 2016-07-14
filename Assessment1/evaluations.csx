/*  You will see with this assignment that I not only have no idea what I am doing, but I do 
not know where to find the information. I am starting completely from scratch and really not sure if this is something I 
Should be continuing or not? I really want to be a programmer and create web sites, but really struggling. I spent the 
entire time in the class to get this far. I just cannot figure out how to even start anything!  */





using System;

namespace VariableDemo
{
    class Program
    {
        // 1 declaring and initializing variables

        static void Main(string[] args)
        {
            //Declare variables 
            int num1;
            int num2;
            double dbl3;
            double dbl4;
            bool boolVal;
            decimal dec5;
            string name;
            string name2;
            string date = DateTime.Today.ToShortDateString();

            //Assign values to variables 
            num1 = 12;
            num2 = 28;
            dbl3 = 8.65;
            dbl4 = 5.86;
            boolVal = true;
            dec5 = 3.17;
            name = "Chris Wainscott"; x
            name2 = " I am struggling with this class";


            {




                // 2 putting two strings together from the variables at the top.
                string greeting = "Hello " + name + " " + name2 + ".";
                {
                    // 3 print the above to the console I ran in debug and it did not work
                    Console.WriteLine(greeting);
                    Console.ReadLine();
                } 
              
                   //4 I had no idea how to put this in the code. 
                    string[] arr = new string[5]; // Initialize.
                    arr[0] = "Sophia";               
                    arr[1] = "Sean";               
                    arr[2] = "Henry";             
                    arr[3] = "Edith";
                    arr[4] = "Jennifer";              

                    // 5 Loop over strings and print to console.
                    foreach (string s in arr)
                    {
                        Console.WriteLine(s);
                    }
                
            }
            }

       
    }
}
