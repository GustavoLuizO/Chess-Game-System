using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameSystem.Tabuleiro
{
    public class ChessBoard // not inherit from position because the objective is another
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private ChessPiece[,] Pieces { get; set; }

        public ChessBoard(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            Pieces = new ChessPiece[lines, columns];
        }
    }
}
