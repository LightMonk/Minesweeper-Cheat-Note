using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Minesweeper
{
    public partial class Form1 : Form
    {
        private CreateCheatNote CCN = new CreateCheatNote();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            //Open Filebrowser
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "txt Files (*.txt)|*.txt";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tb_InputFile.Text = ofd.FileName;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            //Close
            Close();
        }

        private void btn_MakeCheatNote_Click(object sender, EventArgs e)
        {
            //Start Create Cheatnote
            if (!String.IsNullOrWhiteSpace(tb_InputFile.Text)) CCN.MakeCheatNote(tb_InputFile.Text); else MessageBox.Show("Please select an input File!", "Input File Missing", MessageBoxButtons.OK);
        }
        
    }
}
