using ChessGameSystem.Chess;
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
                Console.Write(8 - i + "  ");
                for (int j = 0; j < chessBoard.Columns; j++)
                {
                    if (chessBoard.ChessPiece(line: i, column: j) == null)
                        Console.Write("- ");
                    else
                    {
                        PrintOutPiece(chessBoard.ChessPiece(line: i, column: j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("   A B C D E F G H");
        }

        public static void PrintOutPiece(ChessPiece piece)
        {
            ConsoleColor colorSystem = Console.ForegroundColor;
            
            if (piece.Color == Color.White)
                Console.ForegroundColor = ConsoleColor.Blue;
            else
                Console.ForegroundColor = ConsoleColor.Red;
            
            Console.Write(piece);
            Console.ForegroundColor = colorSystem;
        }

        public static PositionChess ReadPositionChess()
        {
            string positionChess = Console.ReadLine();
            char column = positionChess[0];
            int line = int.Parse(positionChess[1] + "");
            return new PositionChess(column, line); ;
        }
    }
}
