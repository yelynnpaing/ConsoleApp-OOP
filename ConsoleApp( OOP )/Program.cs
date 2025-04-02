

/*

// Encapsulation, Classes, Objects, and Properties.

using System;
public class Person
{
    private string name;

    public Person(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
        set { Name = value; }
    }

    public void Greet()
    {
        Console.WriteLine($"Hello, Good morning {name}.");
    }
}

public class Program
{
    static void Main()
    {
        Person person = new Person("Alice");
        person.Greet();

        Person person2 = new Person("Bob");
        person2.Greet();
    }
}

*/



/*

//LINQ

using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var EvenNumbers = numbers.Where(num => num % 2 == 0).ToList();
        Console.WriteLine($"Even number are => " + string.Join(", ", EvenNumbers));    
    }
}

*/



/*

//async and await 

using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Start fetching...");
        Console.WriteLine("objects");
        var result = await FetchData();
        Console.WriteLine(result);
    }

    static async Task<string> FetchData()
    {
        await Task.Delay(3000);
        return "Fetching success...";
    }
}

*/



/*

//OOP example with bank account creating

using System;
class BankAccount
{
    private decimal balance;                    //decalre private
    public BankAccount(decimal InitialBalance)
    {
        balance = InitialBalance;
    }

    public decimal Balance
    {
        get { return balance; }
        private set
        {
            if(value >= 0)
            {
                balance = value;
            }
        }
    }

    public void Deposit(decimal amount)
    {
        if(amount > 0)
        {
            Balance += amount;
        }
    }

    public void Withdrawl(decimal amount)
    {
        if(amount > 0)
        {
            Balance -= amount;
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount bankAccount1 = new BankAccount(500);
        bankAccount1.Deposit(200);
        Console.WriteLine($"bankAccount1 Balance is  {bankAccount1.Balance} ");

        BankAccount bankAccount2 = new BankAccount(500);
        bankAccount2.Withdrawl(200);
        Console.WriteLine($"bankAccount2 Balance is  {bankAccount2.Balance} ");

    }
}

*/



/*

//Inheritance and Polymophism

using System;
class Employee                          //base class
{
    public string Name { get; set; }
    public Employee(string name)
    {
        Name = name;
    }

    public virtual void Work()          //virtual method
    {
        Console.WriteLine($"{Name} is working.");
    }
}

class Developer : Employee
{
    public Developer(string name) : base(name) { }

    public override void Work()         //override base method
    {
        Console.WriteLine($"{Name} is developing softwares.");
    }
}

class Driver : Employee
{
    public Driver(string name) : base(name) { }

    public override void Work()
    {
        Console.WriteLine($"{Name} is driving truk car.");
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
           new Employee("Mg Mg"),
           new Developer("Kyaw Kyaw"),
           new Driver("U Mya"),
        };

        foreach(var emp in employees)
        {
            emp.Work();
        }
    }
}

*/



/*

//Abstract 

abstract class Animal       //abstract class
{
    public abstract void MakeSound();       // abstract method

    public void Sleeping()
    {
        Console.WriteLine("Sleeping.....");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof woof...");
    }
}

class Program
{
    static void Main()
    {
        Animal myDog = new Dog();
        myDog.MakeSound();      //Woof woof...
        myDog.Sleeping();       //Sleeping.....
    }
}

*/



//LINQ

using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee{Name= "Mg mg", Age=28, Department="IT"},
            new Employee{Name= "Su", Age=30, Department="IT"},
            new Employee{Name= "Kyaw", Age=29, Department="IT"},
            new Employee{Name= "Myo", Age=28, Department="HR"},
            new Employee{Name= "Nyi", Age=30, Department="HR"},
        };

        var selectedEmployees = employees
            .Where(emp => emp.Age > 28 && emp.Department == "IT")
            .Select(emp => emp.Name)
            .ToList();
        Console.WriteLine("Here are selected employees : " + string.Join(", ", selectedEmployees));


        //GroupBy
        var selectedGroup = employees
            .GroupBy(emp => emp.Department)
            .Select(g => new { Department = g.Key, Employees = g.ToList() });

        foreach(var group in selectedGroup)
        {
            Console.WriteLine($"Department is : {group.Department}");
            foreach(var emp in group.Employees)
            {
                Console.WriteLine($" - {emp.Name}");
            }
        }
    }
}

class Employee
{    
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
}



