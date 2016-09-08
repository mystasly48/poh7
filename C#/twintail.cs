using System;
public class Hello {
  public static void Main() {
    var drink1 = Console.ReadLine().Split(' ');
    var caffeine1 = int.Parse(drink1[0]);
    var price1 = int.Parse(drink1[1]);
    var perfor1 = (double)caffeine1 / price1;
    var drink2 = Console.ReadLine().Split(' ');
    var caffeine2 = int.Parse(drink2[0]);
    var price2 = int.Parse(drink2[1]);
    var perfor2 = (double)caffeine2 / price2;
    if (perfor1 > perfor2) {
        Console.WriteLine("1");
    } else {
        Console.WriteLine("2");
    }
  }
}
