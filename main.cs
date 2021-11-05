using System;

class Program {
  static int add4(int nb)
  {
    return nb+4;
  }
  public static void Main (string[] args) 
  {
    string output = Console.ReadLine();
    int nb;
   while(output != "exit"){
      nb = add4(int.Parse(output));
      Console.WriteLine (nb);
      output = Console.ReadLine();
   }
  }
}