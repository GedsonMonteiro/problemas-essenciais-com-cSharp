using System;
  class qtdLinha {

  static void Main(string[] args) {
    int limit = Int32.Parse(Console.ReadLine());

    for (int i = 1; i <= limit; i++) 
    {
        var dobro = i * i;
        var cubo = dobro * i;
        Console.WriteLine(i + " " + dobro + " " + cubo);
    }
  }
}