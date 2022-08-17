using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Informe um número: ");
    int numero = int.Parse(Console.ReadLine());
    
    Console.WriteLine("O número antecessor de {0} é {1} e o sucessor é {2}.", numero, numero - 1, numero + 1);
  }
}