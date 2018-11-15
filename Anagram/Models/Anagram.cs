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
    public static void wordsAnagramArray(string word, string[] words)
    {
      word = InOrder(word);
      string[] anagramFinal = new string[words.Length];
      // Array.Copy(words,anagramFinal, words.Length);
      for (int i = 0; i < words.Length; i++)
      {
        anagramFinal[i] = words[i];
      }

      // words[j]=InOrder(words[j]);

      List<string> newList = new List<string>();
      for(int i=0; i < words.Length; i++)
      {
        if(word == InOrder(words[i]))
        {
          newList.Add(anagramFinal[i]);
        }
      }
      Console.WriteLine("your Anagram list:");
      for (int i = 0; i < newList.Count; i++)
      {
        Console.WriteLine(newList[i]);
      }
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
      wordsAnagramArray(userInputword,list);
      // for(int i=1;i<=userNumber;i++)
      // {
      //     string userOutput = CheckNumber(i);
      //     Console.WriteLine(userOutput);
      // }
    }

  }
}
