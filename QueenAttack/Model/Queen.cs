using System;

namespace QueenAttack
{
  public class Queen
  {
    private int X;
    private int Y;

    public Queen(int x, int y)
    {
      X = x;
      Y = y;
    }

    public bool CanAttack(int px, int py)
    {
      if ((Y == py) || (X == px) || (Math.Abs(X - px) == Math.Abs(Y - py)) )// horizontal || veritcal
      {
        return true;
      }
      return false;
    }
  }
}
