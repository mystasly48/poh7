using System;
using System.Linq;
using System.Collections.Generic;
public class Hello {
  public static void Main() {
    var allBookCount = int.Parse(Console.ReadLine());
    var haveBookCount = int.Parse(Console.ReadLine());
    var haveBooksStr = Console.ReadLine().Split(' ');
    var haveBooks = new int[haveBookCount];
    var sellBookCount = int.Parse(Console.ReadLine());
    var sellBooksStr = Console.ReadLine().Split(' ');
    var sellBooks = new int[sellBookCount];
    for (int i = 0; i < haveBookCount; i++) haveBooks[i] = int.Parse(haveBooksStr[i]);
    for (int i = 0; i < sellBookCount; i++) sellBooks[i] = int.Parse(sellBooksStr[i]);
    var buyBooks = sellBooks;
    for (int i = 0; i < haveBookCount; i++) {
      for (int j = 0; j < sellBookCount; j++) {
        if (haveBooks[i] == sellBooks[j]) {
          buyBooks[j] = 0;
        }
      }
    }
    var resultList = new List<int>();
    for (int i = 0; i < sellBookCount; i++) {
      if (buyBooks[i] != 0) {
        resultList.Add(buyBooks[i]);
      }
    }
    if (resultList.Count == 0) {
      Console.WriteLine("None");
      return;
    }
    resultList.Sort();
    var result = "";
    foreach(var i in resultList) {
      result += i.ToString() + " ";
    }
    result = result.Substring(0, result.Length - 1);
    Console.WriteLine(result);
  }
}
