using System;
using System.Collections.Generic;
using System.Text;

// 1 declaring and initializing variables


//Declare and assign variables 
int num1 = 12;
int num2 = 4;
double dbl3 = 8.65;
double dbl4 = 5.86;
bool boolVal = true;
decimal dec5 = 3.17m;
decimal dec6 = 9.89m;
string name = "Chris Wainscott";
string name2 = " I am struggling with this class";
string date = DateTime.Today.ToShortDateString();
double dbl1 = 89;
double dbl2 = 10.5;



// 2 putting two strings together from the variables at the top.
string CombineToString(string name, int num2)
{
    return $"I am {name} and I have {num2} kids.";
}

// 3 print the above to the console I ran in debug and it did not work
Console.WriteLine(CombineToString(name, num2));


//4 I had no idea how to put this in the code. 
var familyMembers =
    new[]
    {
        "Sean",
        "Henry",
        "Sophia",
        "Jennifer",
        "Edith"
    };

// 5 Loop over strings and print to console.
foreach (var family in familyMembers) Console.WriteLine(family);

//part two OOP  question 1
//create a class called enum
public enum Gender
{
    Unknown, //this is 0 place
    Male,   //this is 1 place
    Female // this is 2 place
}

public class Customer //1 create a class called customer with 3 properties of 
{
    // 2 create a constructor customer class to create customer objects with parameters.
    //***Make sure to remember to use Gender for Gender since it is an enum***
    public Customer(string name, Gender gender, string purchase)
    {
        Name = name;
        Gender = gender;
        Product = purchase;
    }

    public string Name { get; set; }
    public string Gender { get; set; }
    public string Purchase { get; set}

    // 3 Create a method in your customer class that stimulates sending a thank you to 
    //the customer after their purchase by console message.

    public void thankYou()
    {
        Console.WriteLine($" {Name}, We at ABC Company appreciate you taking" +
           " the time to purchase {Product} at our store today. We hope to " +
           " see you back at our store in the near future. ");
    }

    //4 Create 2 more methods and they should both be called to send sales notice. 
    // one should accept only a date as a parameter and the other one is an overload
    // of the same method which should accept both a date and a string as a parameter.
    //Use these methods to announce sales and print a message.

    public void SaleNotice(DateTime eventDate)
    {
        Console.WriteLine($" {Name}, We are having a 50% off sale to our prime" + 
            "members and will also have several give aways on {eventDate:MM-dd-yyyy}");
    }

    public void SaleNotice(string product, DateTime eventDate)
    {
        Console.WriteLine($"{Name}, you are a prime member so please see the item" +
            "{purchase} at 50% off on {saleDate:MM-dd-yyyy}");
    }

    // 9 Add an overridable method to the Customer class called PrintCustomerInfo. 
    //The method should print the name purchase, and gender of the customer. It could go like this:
    public virtual void PrintCustomerInfo()
    {
        Console.WriteLine($"{Name} - {Gender} - {Purchse}");
    }
}

    // 5 Create a subclass of Customer called InactiveCutomer. The class should have an int property called MonthsInactive,
    // and other programmers SHOULD NOT be able to create subclasses from it.

    private class InactiveCustomer(int monthsInactive);
    : Customer;


    // 10 Add an enum to the InactiveCustomer class that gives a couple reasons why a customer might not be purchasing. 
    // The reasons might be Irate, Moved, Uninterested

    public enum InactiveReason
    {
        Irate,
        Moved,
        Uninterested
        
    }

    // 6  In the InactiveCustomer subclass, create a constructor that uses the base
    //keyword that adds a monthsInactive parameter.

    public InactiveCustomer
        :base;
    {
        MonthsInactive = monthsInactive;
    }

    public int MonthsInactive { get; set; }

    // 11 Add a property to the InactiveCustomer class that indicates why the customer is inactive

    public InactiveCustomer Inactive { get; set; }

    // 7 In the InactiveCustomer subclass create a method that sends a message to a customer who has been inactive for over 
    //four months. The console would read something like this:

    public void InactiveMessage()
    {
        var inactiveMessage =
            new StringBuilder($"Being a loyal customer,  {Name}. ")
                .Append($"Our company hopes you enjoyed your {Product}. Around {Inactive} time. ")
                .Append("It might make a good present for someone at a 20% discount with this letter.").ToString();
                
        Console.WriteLine(inactiveMessage);
    }

    // 12 Add a method called PrintCustomerInfo that overrides the one from the Customer class. You should print Name, 
    // product purchased, gender, months inactive, and reason for inactivity. 

    public override void PrintCustomerInfo()
    {
        Console.WriteLine($"{Name} - {Product} - {Gender} - {MonthsInactive}  - {Inactive}");
    }


    // 8 You should, of course, create instances of these classes, set the properties via the constructors,
    // and test the methods on those objects.

   
    customer.PrintCustomerInfo();
    inactiveCustomer.SayThanks();
    inactiveCustomer.ThanyYou();
    inactiveCustomer.SaleNotice();




