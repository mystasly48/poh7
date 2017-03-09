using System;
public class Program {
  public static void Main() {
    int N = int.Parse(Console.ReadLine());
    string[][] q = new string[N][];
    for (int i = 0; i < N; i++) {
      q[i] = Console.ReadLine().Split(' ');
    }
    int M = int.Parse(Console.ReadLine());
    string[] p = new string[M];
    for (int i = 0; i < M; i++) {
      p[i] = Console.ReadLine().Replace(" ", "");
    }

    for (int i = 0; i <= N-M; i++) { // y
      for (int j = 0; j <= N-M; j++) { // x
        string _q = "";
        string _p = p[0];
        for (int k = 0; k < M; k++) {
          _q += q[i][j + k];
        }
        if (_q == _p) {
          bool success = false;
          for (int k = 1; k < M; k++) {
            string __q = "";
            string __p = p[k];
            for (int l = 0; l < M; l++) {
              __q += q[i+k][j+l];
            }
            if (__q != __p) {
              success = false;
              break;
            }
            success = true;
          }
          if (success) {
            Console.WriteLine("{0} {1}", i, j);
            return;
          }
        }
      }
    }
  }
}
