using System;
using System.Threading;

namespace Palindromes {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("_______________________________________________________");
      Console.WriteLine("              Is your word a palindrome?");
      Console.WriteLine("              Step right up and find out!");
      Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
      Carnie();
    }

    public static void Carnie()
    {
      Console.WriteLine("");
      Thread.Sleep(900);
      Console.Write("You there");
      Thread.Sleep(100);
      Console.Write(".");
      Thread.Sleep(100);
      Console.Write(".");
      Thread.Sleep(100);
      Console.Write(".");
      Thread.Sleep(300);
      Console.Write("In the blue shirt.");
      Thread.Sleep(800);
      Console.Write(" What is your word");
      Console.WriteLine("");
      string palindrome = Console.ReadLine();
      if (Words.isPalindrome(palindrome)) {
        Console.WriteLine("YES! We have a winner!");
        Console.Write("The word " + palindrome.ToLower() + " is a palindrome");
      } 
      else {
        Console.WriteLine("OHH...");
        Thread.Sleep(600);
        Console.Write("Not Quite... ");
        Thread.Sleep(600);
        Console.Write(palindrome + " is not a palindrome");
      }
    }
  }
}