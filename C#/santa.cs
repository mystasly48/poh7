using System;
using System.Collections.Generic;
using System.Linq;
public class Program {
  public static void Main() {
    var XYZN = Gets();
    var DAs = new int[XYZN[3]][];
    for (var i = 0; i < XYZN[3]; i++) {
      DAs[i] = Gets();
    }
    DAs = DAs.OrderBy(x => x[0]).ThenBy(x => x[1]).ToArray();
    var rectangles = new int[DAs.Count(x => x[0] == 0)+1 * DAs.Count(x => x[0] == 1)+1];
    for (var i = 0; i < DAs.Length; i++) {

    }
    // foreach (var x in DAs)
    //   Console.WriteLine("{0} {1}", x[0], x[1]);
  }

  private static int[] Gets() {
    return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
  }
}
