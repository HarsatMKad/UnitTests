using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestSumm()
    {
      SquareMatrix FirstTestClass = new SquareMatrix(3);
      SquareMatrix SecondTestClass = new SquareMatrix(3);
      int[,] List = new int[3,3];
      int Summator = 1;
      for (int Row = 0; Row < 3; ++Row)
      {
        for(int Column = 0; Column < 3; ++Column)
        {
          List[Row, Column] = Summator;
          ++Summator;
        }
      }

      FirstTestClass.CreateMatrix(List);
      SecondTestClass.CreateMatrix(List);

      SquareMatrix Result = FirstTestClass + SecondTestClass;
      Assert.AreEqual("24681012141618", Result.ToString());
    }

    [TestMethod]
    public void Testmultiplication()
    {
      SquareMatrix FirstTestClass = new SquareMatrix(3);
      SquareMatrix SecondTestClass = new SquareMatrix(3);
      int[,] List = new int[3, 3];
      int Summator = 1;
      for (int Row = 0; Row < 3; ++Row)
      {
        for (int Column = 0; Column < 3; ++Column)
        {
          List[Row, Column] = Summator;
          ++Summator;
        }
      }

      FirstTestClass.CreateMatrix(List);
      SecondTestClass.CreateMatrix(List);

      SquareMatrix Result = FirstTestClass * SecondTestClass;
      Assert.AreEqual("212427424854637281", Result.ToString());
    }

    [TestMethod]
    public void TestDeterm()
    {
      int Dimension = 3;
      SquareMatrix TestClass = new SquareMatrix(Dimension);
      int[,] List = new int[Dimension, Dimension];
      int Summator = 1;
      for (int Row = 0; Row < Dimension; ++Row)
      {
        for (int Column = 0; Column < Dimension; ++Column)
        {
          List[Row, Column] = Summator;
          ++Summator;
        }
      }
      TestClass.CreateMatrix(List);
      double Result = SquareMatrix.Detdeterminant(TestClass);
      Assert.AreEqual(6.66, Result, 0.01);
    }
  }
}
