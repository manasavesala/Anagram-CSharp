using System;
using System.Linq;
using System.Collections.Generic;

namespace AnagramA.Models
{
  public static class Anagram
  {

    public static string IsAnagram(string word, string words)
    {
      word = InOrder(word);
      words = InOrder(words);
      if(word == words){
        return "IsAnagram";
      }else{
        return "notAnagram";
      }

    }
    public static string[] getAnagrams(string word, string[] words)
    {
      word = InOrder(word);
      List<string> anagrams = new List<string>();
      for(int i=0; i < words.Length; i++)
      {
        var sortedWord = InOrder(words[i]);

        if(word.Equals(sortedWord))
        {
          anagrams.Add(words[i]);
        }
      }

      // List<string> --> string[]
      // List<int> --> int[]
      return anagrams.ToArray();
    }

    public static string InOrder(string word)
    {
      char[] newWord = word.ToCharArray();
      Array.Sort(newWord);
      string sortedWord = string.Join("",newWord);
      return sortedWord;
    }


    public static void Main()
    {
      Console.WriteLine("Please enter a String:");
      string userInputword = Console.ReadLine();
      Console.WriteLine("Please enter list of words:");
      List<string> inputList = new List<string>();
      for(int i = 0;i<=inputList.Count;i++)
      {
        Console.WriteLine("Add word? (Y/N)");
          string input = Console.ReadLine();
        if(input=="Y"||input=="y")
        {
          inputList.Add(Console.ReadLine());
        }else{
          i=inputList.Count;
        }

      }
      string[] list =  inputList.ToArray();
      var anagrams = getAnagrams(userInputword,list);
      for(int i = 0; i< anagrams.Length; i++)
      {
          Console.WriteLine(anagrams[i]);
      }
    }

  }
}
