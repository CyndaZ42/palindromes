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
      int winCount = 0;
      PalindromeQuiz(winCount);
    }

    public static void PalindromeQuiz(int winCount)
    {
      Console.Write(" What is your word");
      Console.WriteLine("");
      string palindrome = Console.ReadLine();
      if (Words.isPalindrome(palindrome)) 
      {
        Console.WriteLine("YES! We have a winner!");
        Console.WriteLine("The word " + palindrome.ToLower() + " is a palindrome");
        winCount ++;
        Thread.Sleep(200);
        Console.WriteLine("               You're on a " + winCount + " win streak!");
        Console.WriteLine("              Do you want to keep playing");
        Console.WriteLine("                       (Y)   (N)");
        string uInput = Console.ReadLine();
        if (uInput == "y") 
        {
          Console.Write("Ok.");
          PalindromeQuiz(winCount);
        }
        else
        {
          Console.WriteLine("Here is your prize");
          Trophy(winCount);
        }
      }
      else {
        Console.WriteLine("Ohh...");
        Thread.Sleep(600);
        Console.Write("Not Quite... ");
        Thread.Sleep(600);
        Console.Write(palindrome + " is not a palindrome");
        if (winCount > 0) 
        {
          Console.WriteLine("You just lost a " + winCount + " win streak. Here is your prize.");
          Trophy(winCount);
          winCount = 0; 
        }
      }
    }

    public static void Trophy(int winCount) 
    {
      string hat1 = ":";
      string hat2 = "";
      string hat3 = "";
      string space1 = "";
      string space2 = "";
      string brim = "";
      string floor = "";
      string win = "";
      string linecount = "       ";
      if (winCount < 10) {
       win += " ";
      } 
      for (int i = 2; i < winCount && i < 14; i++ ) {
        linecount += "  ";
        space1 += " ";
        space2 += "  ";
        hat1 += ":";
        brim += "--";
        floor += "__";
        if (i % 2 == 0) {
          hat3 += "=";
        } else {
          hat2 += "=";
        }
      }
      //if (winCount > 25){    
      //  Console.WriteLine(@"             _ `|.                            _.:._                                   _ `|.                   ");
      //  Console.WriteLine(@"            /o`=|                           ."\ | /".                                /o`=|                    ");
      //  Console.WriteLine(@"     .=""=./::(.=""=.      .,__             "=.\:/.="             __,.        .=""=./::(.=""=.                ");
      //  Console.WriteLine(@"    /./.' .::::. \'. \      "=.`"=._           /^\           _.="`.="        /./.' .::::. \'. \               ");
      //  Console.WriteLine(@"   //\/ / :::::: \/\ \\       ".'.'.".=.=.=.-,/   \,-.=.=.=.".'.'."         //\/ / :::::: \/\ \\              ");
      //  Console.WriteLine(@"  /\/ /\/\'::::'/\ \/\ \          `~.`` ` `.`.\   /.'.' ' ''.~`            /\/ /\/\'::::'/\ \/\ \             ");
      //  Console.WriteLine(@"  /' `     '::'     ` `\             `=.-~~-._ ) ( _.-~~-.=`              /' `     '::'     ` `\              ");
      //  Console.WriteLine(@"           /::\                                ( )                                 /::\                       ");
      //  Console.WriteLine(@"          /\/\/\                                Y                                 /\/\/\                      ");               
      //}
      Console.WriteLine(linecount + @"     .-" + hat2 + "====" + hat1 + "====" + hat3 + "-.");
      Console.WriteLine(linecount + @" _____\-" + brim + "--------/_____ ");
      Console.WriteLine(linecount + @"(_(_(_|:        " + space2 + "|_)_)_) ");
      Console.WriteLine(linecount + @"  (_(_|:  " + space1 + ".,.   " + space1 + "|_)_) ");
      Console.WriteLine(linecount + @"    (_|: " + space1 + "{ " + winCount + win +"}  " + space1 + "|_) ");
      Console.WriteLine(linecount + @"     (|:. " + space1 + "`*`   " + space1 + "|) ");
      Console.WriteLine(linecount + @"       \'      " + space2 + "/ ");
      linecount += "      ";  
      if (winCount > 5)        
      {                      
        Console.WriteLine(linecount + @"  \" + space2 + "     / ");
        Console.WriteLine(linecount + @"   \" + space2 + "   / ");
        Console.WriteLine(linecount + @"    )" + space2 +" ( ");
        int loonng = linecount.Length;
        for (int i = 0; i < winCount && i < 18; i ++) 
        {
          if (i % 4 == 0){
            loonng += -2 ;
            linecount = "  ";
            for (int b = 0; b < loonng; b++) 
            {
              linecount += " ";
            }
            Console.WriteLine(linecount + @"  _(_" + floor + "__)_");
            floor += "____";
            space2 += "    ";
          }
        }
      Console.WriteLine(linecount + @" (_" + floor + "__)  ");
      }           
      else 
      {
      if (winCount > 3)
      {
        Console.WriteLine(linecount + @"  \" + space2 + "     / ");
        space2 = "  ";
        floor = "__";
        linecount += " ";
      }
      Console.WriteLine(linecount + @"  )" + space2 + "     ( ");
      Console.WriteLine(linecount + @" (" + floor + "_______)  ");
      }

      //Console.WriteLine("    .-=======:=======-.     ");
      //Console.WriteLine(" ____\---------------/____  ");
      //Console.WriteLine("( ( (|      .,.      |) ) ) ");
      //Console.WriteLine(" \( (|     { 1 }     |) )/  ");
      //Console.WriteLine("   \(|      `*`      |)/    ");
      //Console.WriteLine("    \|               |/     ");
      //Console.WriteLine("      \             /       ");
      //Console.WriteLine("       '\_       _/'        ");
      //Console.WriteLine("        __)     (__         ");
      //Console.WriteLine("       /___________\        ");

    }
  }
}