using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    abstract class Figure
    {
		#region public
		public Position currentPosition;
        public string color;
        public string name;
        public abstract bool canMove(Position position);

		#endregion 
		#region Figure
		protected Figure(Position position, string color)
        {
            this.currentPosition = position;
            this.setColor(color);

            Program.board[this.currentPosition.getField()] = this;
            ToolBox.write(this.color + " " + this.name + "set on position (" + position.getField() + ")");
        }
		#endregion 

		public void moveTo(Position position)
		#region IF
		{

            if (this.canMove(position))
            {
                Position Positionolder = this.currentPosition;
                this.currentPosition = position;
                ToolBox.write(this.name + " changed position to  (" + Positionolder.getField() + ") for (" + position.getField() + ")");
            }
            else
            {
                Position Positionolder = this.currentPosition;
                ToolBox.write(this.name + " can't move to   (" + position.getField() + ") from position (" + Positionolder.getField() + ")");
            }
			#endregion
		}

        private void setColor(string color)
        {
            if (color != "black" || color != "biały")
            {
                color = "black";
            }

            this.color = color;
        }
    }
}
