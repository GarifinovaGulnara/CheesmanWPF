using System;
using ClassLibrary;

class ConsoleApp
{
    static void Main()
    {
        string chess = Console.ReadLine();
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());

        try
        {
            Chess f = ChessmanMaker.Make(chess, x1, y1);
            Console.WriteLine(f.MakeMove(x2, y2) ? "YES" : "NO");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

class ChessmanMaker
{
    static public Chess Make(string pieceCode, int x, int y)
    {
        Chess piece = null;

        switch (pieceCode)
        {
            case "King":
            case "K":
                piece = new King(x, y);
                break;

            case "Queen":
            case "Q":
                piece = new Queen(x, y);
                break;

            case "Bishop":
            case "B":
                piece = new Bishop(x, y);
                break;

            case "Knight":
            case "N":
                piece = new Knight(x, y);
                break;

            case "Rook":
            case "R":
                piece = new Rook(x, y);
                break;

            case "Pawn":
            case "P":
                piece = new Pawn(x, y);
                break;

            default: throw (new Exception("Unknown piece code."));
        }
        return piece;
    }
}
