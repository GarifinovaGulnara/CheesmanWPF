using System;

namespace ClassLibrary
{
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

    public class King : Chess
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

    public class Queen : Chess
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

    public class Rook : Chess
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

    public class Bishop : Chess
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

    public class Knight : Chess
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

    public class Pawn : Chess
    {
        public Pawn(int newX, int newY) : base(newX, newY)
        { }

        public override bool MakeMove(int newX, int newY)
        {
            return ((x == newX && y == 2 && y + 2 >= newY) ||
                    (x == newX && y + 1 == newY));
        }
    }
}
