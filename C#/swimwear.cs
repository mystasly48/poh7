using System;
using System.Linq;
using System.Collections.Generic;
public class Program {
  public static void Main() {
    int N = int.Parse(Console.ReadLine());
    DateTime start = DateTime.Now;
    string fact = Factorial(N);
    // Console.WriteLine("{0}! = {1}", N, fact);
    using (var sw = new System.IO.StreamWriter(string.Format("Factorial of {0} (Custom).txt", N))) {
      sw.WriteLine(fact);
    }
    Console.WriteLine(DateTime.Now - start);

    // while (fact[fact.Length-1] == '0') {
    //   fact = fact.Substring(0, fact.Length-1);
    // }
    // fact = fact.Substring(fact.Length-9);
    // double res = double.Parse(fact);
    // Console.WriteLine(res);
  }

  private static string Factorial(int N) {
    List<int> list = new List<int>() { 1 }; // 掛け算の元となる配列。要素番号が０から１の位。逆順にすることで正確な整数になる。

    for (int i = N; i > 1; i--) { // N から 2 までの値を使用して掛け算をしていく
      int carry = 0; // 桁上がりの値を保持
      for (int j = 0; j < list.Count; j++) {
        int mul = list[j] * i + carry; // １桁ずつ掛け算し、前回の桁上りの値を足す。
        list[j] = mul % 10; // １０以上になってはいけないので、１０で割った答えを元の位置に代入する。
        carry = mul / 10; // 桁上りする値を保持しておく（桁上りで１０以上になっていることも考える）
      }
      if (carry > 0) {
        if (carry >= 10) {
          int[] carryArr = carry.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).Reverse().ToArray();
          foreach (int k in carryArr) {
            list.Add(k);
          }
        } else {
          list.Add(carry);
        }
      }
      while (list[0] == 0) {
        list.RemoveAt(0);
      }
    }
    return string.Join("", list.Select(x => x.ToString()).Reverse());
  }
}
