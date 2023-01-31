using System;

class Program {
  public static void Main (string[] args) {
    void OutputNumbers(int m, int n) 
    {
      if (m <= n) {
          OutputNumbers(m + 1, n);
          Console.Write($"{m} ");
      }
    }

    Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int m = 1;
    OutputNumbers(m, n);


  }
}
