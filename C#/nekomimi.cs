using System;
public class Hello {
  public static void Main() {
    var input = Console.ReadLine();
    var searchWord = "cat";
    var wordCount = 0;
    var index = input.IndexOf(searchWord);
    if (index >= 0) {
      wordCount++;
      while(true) {
        index = input.IndexOf(searchWord, index + 3);
        if (index >= 0) {
          wordCount++;
        } else {
          break;
        }
      }
    }
    Console.WriteLine(wordCount);
  }
}
