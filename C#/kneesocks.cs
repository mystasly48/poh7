using System;
public class Hello {
  public static void Main() {
    var count = int.Parse(Console.ReadLine()); // 3
    var length = int.Parse(Console.ReadLine()); // 10
    var result = "";
    var appendChar = "R";
    while(true) {
      for (int i = 0; i < count; i++) {
        if (result.Length < length) {
          result += appendChar;
        } else {
          break;
        }
      }
      if (result.Length == length) {
        break;
      } else {
        if (appendChar == "R") {
          appendChar = "W";
        } else {
          appendChar = "R";
        }
      }
    }
    Console.WriteLine(result);
  }
}