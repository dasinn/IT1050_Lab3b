using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter the salesperson's name:");
    string name = Convert.ToString(Console.ReadLine());
    Console.WriteLine ("Enter the sales amount:");
    double amount = Convert.ToDouble(Console.ReadLine());

    double commission = 200 + (.09 * amount);
    Console.WriteLine ("Sales commission for " + name + " is $" + commission);

    if (amount <= 2999.99)
    {
      Console.WriteLine ("Performance is poor.");
    }
    else if (amount <= 4999.99)
    {
      Console.WriteLine ("Performance is average.");
    }
    else if (amount <= 9999.99)
    {
      Console.WriteLine ("Performance is good.");
    }
    else if (amount <= 14999.99)
    {
      Console.WriteLine ("Performance is excellent.");
    }
    else
    {
      Console.WriteLine ("Performance is outstanding.");
    }
  }
}