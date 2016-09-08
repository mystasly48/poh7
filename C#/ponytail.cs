using System;
public class Hello {
  public static void Main() {
    var count = int.Parse(Console.ReadLine());
    for (int i = count; i > 0; i--) {
      Console.WriteLine(i);
    }
    Console.WriteLine("0!!");
  }
}
