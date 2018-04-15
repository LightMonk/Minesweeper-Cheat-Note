using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minesweeper.Models;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;

namespace Minesweeper
{
    class CreateCheatNote
    {
        /// <summary>
        /// Makes out of the Input File containing the Minefield the Cheat Note
        /// </summary>
        /// <param name="filepath"></param>
        public void MakeCheatNote(string filepath)
        {
            int rows = 0;
            int columns = 0;
            string[] lines;
            Minefield minefield;
            Regex input = new Regex("^[.*]*$");
            
            try
            {
                if (File.Exists(filepath))
                {
                    //read input
                    lines = File.ReadAllLines(filepath);

                    //set Dimensions
                    rows = lines.GetLength(0);
                    columns = lines[0].Length;
                    if (rows < 1 || columns < 1) throw new ArgumentException("Board size can not be less than 1x1!");
                    minefield = new Minefield();
                    minefield.setDimensions(rows, columns);

                    //set mines
                    for (int r = 0; r < rows; r++)
                    {
                        //catch eventual faulty input charachters
                        if (!input.IsMatch(lines[r])) throw new ArgumentException("Input File contains unallowed charachters!");
                        int c = 0;
                        foreach (char ch in lines[r])
                        {
                            switch (ch)
                            {
                                case '*':
                                    minefield.setMine(r, c);
                                    break;
                                default:
                                    break;
                            }
                            c++;
                        }
                    }
                    //calculate fields
                    minefield.calculateTileMineNeighbours();

                    //start Making Cheat Note
                    string[] cheatNote = minefield.GetCheatNote();
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "txt File (*.txt)|*.txt";
                    sfd.RestoreDirectory = true;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllLines(sfd.FileName, cheatNote);
                    } else
                    {
                        throw new ArgumentException("Cheat Note Creation cancled!");
                    }

                    MessageBox.Show("Cheat Note Successfuly Created!", "Success", MessageBoxButtons.OK);
                    Process.Start("explorer.exe","/select, \"" + sfd.FileName + "\""); //Open File Explorer with selection on new File
                } else
                {
                    throw new ArgumentException("File not found!");
                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Runtime Error", MessageBoxButtons.OK);

            }
              
        }


    }
}
