using ChessGameSystem.Tabuleiro;
using System;

namespace ChessGameSystem
{
    public class Screen
    {
        public static void ShowChessBoard(ChessBoard chessBoard)
        {
            for (int i = 0; i < chessBoard.Lines; i++)
            {
                for (int j = 0; j < chessBoard.Columns; j++)
                {
                    if (chessBoard.ChessPiece(line: i, column: j) == null)
                        Console.Write("- ");
                    else
                        Console.Write(chessBoard.ChessPiece(line: i, column: j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
