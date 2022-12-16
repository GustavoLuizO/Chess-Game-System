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

        public ChessPiece ChessPiece(int line, int column)
        {
            return Pieces[line, column];
        }

        public void PutPiece(ChessPiece piece, Position position)
        {
            Pieces[position.Line, position.Column] = piece;
            piece.Position = position; 
        }
    }
}
