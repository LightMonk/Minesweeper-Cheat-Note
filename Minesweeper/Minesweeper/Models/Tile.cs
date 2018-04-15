using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Models
{
    /// <summary>
    /// A Tile of a Minefield
    /// </summary>
    class Tile
    {
        public bool Mine { get; set; }
        public int NeighbouringMines { get; set; }
    }
}
