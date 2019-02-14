using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QueenAttack;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenTest
  {
    [TestMethod]
    public void QueenConstructor_CreateInstanceOfQueen_Queen()
    {
      Queen newQueen = new Queen(0, 0);
      Assert.AreEqual(typeof(Queen), newQueen.GetType());
    }

    [TestMethod]
    public void CanAttack_HorizontalPosition_True()
    {
      Queen newQueen = new Queen(0, 0);
      Assert.AreEqual(true, newQueen.CanAttack(3, 0));
    }

    [TestMethod]
    public void CanAttack_VerticalPosition_True()
    {
      Queen newQueen = new Queen(0, 0);
      Assert.AreEqual(true, newQueen.CanAttack(0, 4));
    }
    [TestMethod]
    public void CanAttack_DiagonalPosition_True()
    {
      Queen newQueen = new Queen(1,2);
      Assert.AreEqual(true, newQueen.CanAttack(2, 3));
    }
    [TestMethod]
    public void CanAttack_CantAttack_False()
    {
      Queen newQueen = new Queen(0,0);
      Assert.AreEqual(false, newQueen.CanAttack(1, 2));
    }
    [TestMethod]
    public void CanAttack_CanAttackNegativeCoordinates_True()
    {
      Queen newQueen = new Queen(0, 0);
      Assert.AreEqual(true, newQueen.CanAttack(-2, -2));
    }
  }
}
