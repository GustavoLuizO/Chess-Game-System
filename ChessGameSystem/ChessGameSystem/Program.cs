using ChessGameSystem.Chess;
using ChessGameSystem.Tabuleiro;
using System;

namespace ChessGameSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessBoard chessBoard = new ChessBoard(8, 8);
                chessBoard.PutPiece(new Tower(Color.Black, chessBoard), new Position(0, 0));
                chessBoard.PutPiece(new Tower(Color.Black, chessBoard), new Position(1, 3));
                chessBoard.PutPiece(new King(Color.Black, chessBoard), new Position(2, 0));

                chessBoard.PutPiece(new Tower(Color.White, chessBoard), new Position(2, 1));
                chessBoard.PutPiece(new Tower(Color.White, chessBoard), new Position(3, 2));
                chessBoard.PutPiece(new King(Color.White, chessBoard), new Position(2, 5));

                Screen.ShowChessBoard(chessBoard);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
    }
}
