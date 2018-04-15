using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Models
{
    /// <summary>
    /// Simulates a Minesweeper Field
    /// </summary>
    class Minefield
    {
        public Tile[,] Field;

        /// <summary>
        /// Set the size of the Minefield
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        public  void setDimensions(int rows, int columns)
        {
            Field = new Tile[rows, columns];
            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < columns; ++c)
                {
                    Field[r, c] = new Tile();
                }
            }
        }

        /// <summary>
        /// Sets a tile inside the field to be a Mine
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public void setMine(int row, int column)
        {
            if (IsInside(row, column))
            {
                Field[row, column].Mine = true;
            }
        }

        /// <summary>
        /// calculates for all Tiles the amount of Mines that surrounds it
        /// </summary>
        public void calculateTileMineNeighbours()
        {
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    Field[r,c].NeighbouringMines = NumberOfNeighbouringMines(r, c);
                }
            }
        }

        /// <summary>
        /// calculates for the specific Tile the ammount of surrounding mines
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        private int NumberOfNeighbouringMines(int row, int col)
        {
            int count = 0;
            for (int r = row - 1; r <= row + 1; ++r)
            {
                for (int c = col - 1; c <= col + 1; ++c)
                {
                    if (IsInside(r, c) && Field[r, c].Mine)
                        count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Get amount of Rows of the Minefield
        /// </summary>
        public int Rows
        {
            get { return Field.GetLength(0); }
        }

        /// <summary>
        /// Get amount of Columns of the Minefield
        /// </summary>
        public int Columns
        {
            get { return Field.GetLength(1); }
        }

        /// <summary>
        /// Creates the Cheat Note from the Minefield
        /// </summary>
        /// <returns></returns>
        public string[] GetCheatNote()
        {
            string[] note = new string[Rows];
            for (int r = 0; r < Rows; ++r)
            {
                for (int c = 0; c < Columns; ++c)
                {
                    if (IsInside(r, c) && Field[r, c].Mine)
                    {
                        note[r] += "*";
                    }
                    else
                    {
                        if (IsInside(r, c)) note[r] += Field[r,c].NeighbouringMines.ToString();
                    }
                }
            }
            return note;
        }

        /// <summary>
        /// Checks if the choosen spot exists in the current Minefield
        /// </summary>
        /// <param name="r"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        private bool IsInside(int r, int c)
        {
            return r >= 0 && c >= 0 && r < Rows && c < Columns;
        }
    }
    
}
