using System;
public class Program {
  public static void Main() {
    string input = Console.ReadLine();
    int c_count = getCount(input, 'c');
    int a_count = getCount(input, 'a');
    int t_count = getCount(input, 't');

    int min = Math.Min(c_count, Math.Min(a_count, t_count));
    int max = Math.Max(c_count, Math.Max(a_count, t_count));

    Console.WriteLine(min);
    Console.WriteLine(max - c_count);
    Console.WriteLine(max - a_count);
    Console.WriteLine(max - t_count);
  }

  private static int getCount(string s, char c) {
    int count = 0;
    for (int i = 0; i < s.Length; i++) {
      if (s[i] == c) {
        count++;
      }
    }
    return count;
  }
}
