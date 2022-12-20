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
                ChessGame game = new ChessGame();

                while(!game.Finished)
                {
                    Console.Clear();
                    Screen.ShowChessBoard(game.ChessBoard);

                    Console.WriteLine();
                    Console.Write("Origin: ");
                    Position origin = Screen.ReadPositionChess().ToPosition();
                    Console.Write("Destination: ");
                    Position destination = Screen.ReadPositionChess().ToPosition(); 
                    
                    game.ExecuteMovement(origin, destination);
                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
    }
}
