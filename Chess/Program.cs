using Chess.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{

    class Program
    {

        public static Board board = new Board();
		#region Create
		static void Main(string[] args)
        {
            createFigure("Pawn", "B1", "black");
            createFigure("Pawn", "B2", "black");
            createFigure("Pawn", "B3", "black");
            createFigure("Pawn", "B4", "black");
            createFigure("Pawn", "B5", "black");
            createFigure("Pawn", "B6", "black");
            createFigure("Pawn", "B7", "black");
            createFigure("Pawn", "B8", "black");

            Console.ReadKey();
        }
		#endregion
		static void createFigure(String figure, String position, String color)
        {
            switch (figure)
            {
                case "Bishop":
                    new Bishop(new Position(position), color);
                    break;

                case "Knight":
                    new Knight(new Position(position), color);
                    break;

                case "Pawn":
                    new Pawn(new Position(position), color);
                    break;

                case "Rook":
                    new Rook(new Position(position), color);
                    break;
            }
        }
    }
}
