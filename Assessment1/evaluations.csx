/*  You will see with this assignment that I not only have no idea what I am doing, but I do 
not know where to find the information. I am starting completely from scratch and really not sure if this is something I 
Should be continuing or not? I really want to be a programmer and create web sites, but really struggling. I spent the 
entire time in the class to get this far. I just cannot figure out how to even start anything!  */





using System;

// 1 declaring and initializing variables


//Declare and assign variables 
int num1 = 12;
int num2 = 28;
double dbl3 = 8.65;
double dbl4 = 5.86;
bool boolVal = true;
decimal dec5 = 3.17m;
string name = "Chris Wainscott";
string name2 = " I am struggling with this class";
string date = DateTime.Today.ToShortDateString();


// 2 putting two strings together from the variables at the top.
string CombineToString(string name, string name2)
{
    var message = "Hello " + name + " " + name2 + ".";
    return message;
}

// 3 print the above to the console I ran in debug and it did not work
Console.WriteLine(CombineToString(name, name2));


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

//part two OOP  question 1
class Customer
{
    private string myName = "Chris";
    private int myAge = 41;
    private bool purcahse = true;

    // Declare a Name property of type string:
    public string myName
    {
        get
        {
            return myName;
        }
        set
        {
            myName = value;
        }
    }


    public int myAge
    {
        get
        {
            return myAge;
        }
        set
        {
            myAge = value;
        }
    }

    public int purchase
    {
        get
        {
            return purchase;
        }
        set
        {
            purchase = value;
        }
    }
    //adding the public enum for Gender  still part of 1
        public enum GENDER
    {
       Unknown = 0,
       Male  = 1,
       Female = 2up
    }




