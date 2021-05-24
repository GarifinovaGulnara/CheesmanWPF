//Гарифинова Гульнара 221 гр

using System;

class Program
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

    public class Chess
    {
        protected int x;
        protected int y;

        public Chess(int newX, int newY)
        {
            x = newX;
            y = newY;
        }

        public virtual bool MakeMove(int newX, int newY)
        {
            return false;
        }
    }

    class King : Chess
    {
        public King(int newX, int newY) : base(newX, newY)
        {

        }
        public override bool MakeMove(int newX, int newY)
        {
            if ((Math.Abs(x - newX) <= 1 && Math.Abs(y - newY) <= 1))
            {
                x = newX;
                y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Queen : Chess
    {
        public Queen(int newX, int newY) : base(newX, newY)
        {

        }
        public override bool MakeMove(int newX, int newY)
        {
            if (((x == newX) || (y == newY)) || (Math.Abs(x - newX)) == (Math.Abs(y - newY)))
            {
                x = newX;
                y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Rook : Chess
    {
        public Rook(int newX, int newY) : base(newX, newY)
        {

        }
        public override bool MakeMove(int newX, int newY)
        {
            if ((x == newX) || (y == newY))
            {
                x = newX;
                y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Bishop : Chess
    {
        public Bishop(int newX, int newY) : base(newX, newY)
        {

        }
        public override bool MakeMove(int newX, int newY)
        {
            if (Math.Abs(x - newX) == Math.Abs(y - newY))
            {
                x = newX;
                y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Knight : Chess
    {
        public Knight(int newX, int newY) : base(newX, newY)
        {

        }
        public override bool MakeMove(int newX, int newY)
        {
            if ((Math.Abs(x - newX) == 2 && Math.Abs(y - newY) == 1) || (Math.Abs(x - newX) == 1 && Math.Abs(y - newY) == 2))
            {
                x = newX;
                y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Pawn : Chess
    {
        public Pawn(int newX, int newY) : base(newX, newY)
        { }

        public override bool MakeMove(int newX, int newY)
        {
            return ((x == newX && y == 2 && y + 2 >= newY) ||
                    (x == newX && y + 1 == newY));
        }
    }
