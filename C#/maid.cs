using System;
public class Hello {
  public static void Main() {
    var sleepTime = new TimeSpan(0, 1500, 0);
    var count = int.Parse(Console.ReadLine());
    var overTimes = new TimeSpan[count];
    var appendTimes = new TimeSpan[count];
    var resultTimes = new TimeSpan[count];
    for (int i = 0; i < count; i++) overTimes[i] = new TimeSpan(0, int.Parse(Console.ReadLine()), 0);
    for (int i = 0; i < count; i++) appendTimes[i] = new TimeSpan(0, (int)(overTimes[i].TotalMinutes / 3), 0);
    for (int i = 0; i < count; i++) resultTimes[i] = new TimeSpan(0, (int)(sleepTime.TotalMinutes - appendTimes[i].TotalMinutes), 0);
    for (int i = 0; i < count; i++) Console.WriteLine(resultTimes[i].ToString(@"hh\:mm"));
  }
}
