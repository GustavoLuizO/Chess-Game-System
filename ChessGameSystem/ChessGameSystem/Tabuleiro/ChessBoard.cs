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

        public ChessPiece ChessPiece(Position position)
        {
            return Pieces[position.Line, position.Column];
        }

        public ChessPiece ChessPiece(int line, int column)
        {
            return Pieces[line, column];
        }

        public void PutPiece(ChessPiece piece, Position position)
        {
            if (ExistsPiece(position)) 
                throw new Exception("There is a piece this position");

            Pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }

        //TODO 1 : This function can be transferred to ValidatePosition's "IF" command, if you have no more references.
        public bool ExistsPosition(Position position)
        {
            return !(position.Line < 0 || position.Line >= Lines || position.Column < 0 || position.Column >= Columns);
        }

        public void ValidatePosition(Position pos)
        {
            if (!ExistsPosition(pos))
                throw new ArgumentException("Position invalidate");
        }

        public bool ExistsPiece(Position pos)
        {
            ValidatePosition(pos);
            return Pieces[pos.Line, pos.Column] != null;
        }
    }
}
