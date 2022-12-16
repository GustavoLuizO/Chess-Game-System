﻿namespace ChessGameSystem.Tabuleiro
{
    public class ChessPiece
    {
        public Position Position { get; set; }
        public Color Color { get; set; }
        public int AmountMoves { get; set; }
        public ChessBoard ChessBoard { get; set; }

        public ChessPiece(Color color, ChessBoard chessBoard)
        {
            Color = color;
            ChessBoard = chessBoard;
        }
    }
}
