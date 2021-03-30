using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterCode
{
    public class ChessQueens
    {
        public int ChessboardSize { get; private set; }
        public List<int[]> Rows { get; private set; }
        private Random Rnd = new Random();
        private List<int[]> _rows;
        public bool Solved { get; private set; }
        public int Tries { get; private set; }

        public ChessQueens(int chessboardSize)
        {
            ChessboardSize = chessboardSize;
            Rows = InitateEmptyBoard();
            Solved = false;
        }

        private List<int[]> InitateEmptyBoard()
        {
            var board = new List<int[]>();
            var array = new int[ChessboardSize];
            for (int i = 0; i < ChessboardSize; i++)
            {
                board.Add(array);
            }
            return board;
        }

        internal void ShowBoard()
        {
            foreach (var row in Rows)
            {
                foreach (var value in row)
                {
                    Console.Write($"{value} ");
                }
                Console.WriteLine();
            }
        }

        public void SolveByForce()
        {
            int randidx;
            while (!Solved)
            {
                _rows = InitateEmptyBoard();
                for (int i = 0; i < ChessboardSize; i++)
                {
                    var row = _rows[i].ToArray();
                    randidx = Rnd.Next(0, ChessboardSize);
                    row[randidx] = 1;
                    _rows[i] = row;
                }
                Solved = CheckIfSolved(_rows);
                Tries++;
            }
            Rows = _rows;
        }

        public bool CheckIfSolved(List<int[]> rows)
        {
            // Vertical check
            var verticallyPlacedQueens = new List<int>();
            foreach (var row in rows)
            {
                var idx = row.ToList().FindIndex(v => v == 1);
                verticallyPlacedQueens.Add(idx);
            }
            if (verticallyPlacedQueens.IsNotPlacedAtUniqueIndex())
            {
                return false;
            }
            // Diagonal check
            for (int j = 0; j < ChessboardSize - 1; j++)
            {
                int diff = 1;
                for (int i = j + 1; i < ChessboardSize; i++)
                {
                    if (Math.Abs(verticallyPlacedQueens[i] - verticallyPlacedQueens[j]) == diff)
                    {
                        return false;
                    }
                    diff++;
                }
            }
            return true;
        }
    }
}