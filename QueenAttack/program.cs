using System;

namespace QueenAttack
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter Queen coordinates.");
      Console.WriteLine("X:");
      int qx = int.Parse(Console.ReadLine());
      Console.WriteLine("Y:");
      int qy = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter Pond coordinates.");
      Console.WriteLine("X:");
      int px = int.Parse(Console.ReadLine());
      Console.WriteLine("Y:");
      int py = int.Parse(Console.ReadLine());

      Queen newQueen = new Queen(qx, qy);
      if (newQueen.CanAttack(px, py))
      {
        Console.WriteLine("Queen can attack!");
      }
      else
      {
        Console.WriteLine("Queen can NOT attack!");
      }
    }
  }
}
