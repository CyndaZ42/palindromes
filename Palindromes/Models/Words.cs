using System;

namespace Palindromes
{
  public class Words
  {
    public static string Backwards(string word)
    {
      char[] reversed = new char[word.Length];

      for (int i = 1; i <= word.Length; i++)
      {
        reversed[word.Length-i] = word[i - 1];
      }

      string[] result = Array.ConvertAll(reversed, x => x.ToString());

      string output = "";

      for (int i = 0; i < word.Length; i++) {
        output += result[i];
      }

      return output;
    }

    public static bool isPalindrome(string word) {
      return word.ToLower() == Words.Backwards(word).ToLower();
    }
  }
}