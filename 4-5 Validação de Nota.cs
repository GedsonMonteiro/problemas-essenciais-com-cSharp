using System;

class Program {
  static void Main(string[] args) {
  int count = 0;
  double media = 0;
    
    do{
    double nota = double.Parse(Console.ReadLine());
      if (nota < 0 || nota > 10)
        {
      Console.WriteLine("nota invalida");
    }
      else{
      count++;
      media += nota;
    }
  }
      while (count < 2);
      Console.WriteLine("media = " + (media / 2).ToString("N2"));
  }
}