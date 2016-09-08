using System;
public class Hello {
  public static void Main() {
    var count = 5;
    var inputArray = new string[count];
    for (int i = 0; i < count; i++) {
      inputArray[i] = Console.ReadLine();
    }
    int yes = 0, no = 0;
    foreach (var s in inputArray) {
      if (s == "yes") {
        yes++;
      } else {
        no++;
      }
    }
    if (yes > no) {
      Console.WriteLine("yes");
    } else {
      Console.WriteLine("no");
    }
  }
}
