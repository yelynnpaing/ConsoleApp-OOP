

/*

// Encapsulation, Classes, Objects, and Properties.

using System;
public class Person
{
    private readonly string name;

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





//OOP example with bank account creating

using System;
class BankAccount
{
    private decimal balance;
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

