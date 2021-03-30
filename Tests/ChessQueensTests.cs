using EasterCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class ChessQueensTests
    {
        [TestMethod]
        public void Can_Check_Correct_Solution()
        {
            var pussel = new ChessQueens(4);
            var rows = new List<int[]>() {
            new int[] {0, 1, 0, 0},
            new int[] {0, 0, 0, 1},
            new int[] {1, 0, 0, 0},
            new int[] {0, 0, 1, 0}
            };
            Assert.IsTrue(pussel.CheckIfSolved(rows));
        }
        [TestMethod]
        public void Can_Check_Wrong_Solution_Horizontally()
        {
            var pussel = new ChessQueens(4);
            var rows = new List<int[]>() {
            new int[] {0, 1, 0, 0},
            new int[] {0, 0, 0, 1},
            new int[] {0, 1, 0, 0},
            new int[] {0, 0, 0, 1}
            };
            Assert.IsFalse(pussel.CheckIfSolved(rows));
        }
        [TestMethod]
        public void Can_Check_Wrong_Solution_Diagonally()
        {
            var pussel = new ChessQueens(4);
            var rows = new List<int[]>() {
            new int[] {1, 0, 0, 0},
            new int[] {0, 1, 0, 0},
            new int[] {0, 0, 0, 1},
            new int[] {0, 0, 1, 0}
            };
            Assert.IsFalse(pussel.CheckIfSolved(rows));
        }
        [TestMethod]
        public void Can_Solve_4_Queen_Pussel()
        {
            var pussel = new ChessQueens(4);
            pussel.SolveByForce();
            Assert.IsTrue(pussel.Solved);
        }
        [TestMethod]
        public void Can_Solve_5_Queen_Pussel()
        {
            var pussel = new ChessQueens(5);
            pussel.SolveByForce();
            Assert.IsTrue(pussel.Solved);
        }
        [TestMethod]
        public void Can_Solve_6_Queen_Pussel()
        {
            var pussel = new ChessQueens(6);
            pussel.SolveByForce();
            Assert.IsTrue(pussel.Solved);
        }
        [TestMethod]
        public void Can_Solve_7_Queen_Pussel()
        {
            var pussel = new ChessQueens(7);
            pussel.SolveByForce();
            Assert.IsTrue(pussel.Solved);
        }
        [TestMethod]
        public void Can_Solve_8_Queen_Pussel()
        {
            var pussel = new ChessQueens(8);
            pussel.SolveByForce();
            Assert.IsTrue(pussel.Solved);
        }
        [TestMethod]
        public void Can_Solve_9_Queen_Pussel()
        {
            var pussel = new ChessQueens(9);
            pussel.SolveByForce();
            Assert.IsTrue(pussel.Solved);
        }
    }
}
