namespace Minesweeper
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_MakeCheatNote = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.tb_InputFile = new System.Windows.Forms.TextBox();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.l_InputFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_MakeCheatNote
            // 
            this.btn_MakeCheatNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MakeCheatNote.Location = new System.Drawing.Point(192, 205);
            this.btn_MakeCheatNote.Name = "btn_MakeCheatNote";
            this.btn_MakeCheatNote.Size = new System.Drawing.Size(174, 41);
            this.btn_MakeCheatNote.TabIndex = 0;
            this.btn_MakeCheatNote.Text = "Make Cheat Note";
            this.btn_MakeCheatNote.UseVisualStyleBackColor = true;
            this.btn_MakeCheatNote.Click += new System.EventHandler(this.btn_MakeCheatNote_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Close.Location = new System.Drawing.Point(12, 205);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(174, 41);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // tb_InputFile
            // 
            this.tb_InputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_InputFile.Location = new System.Drawing.Point(13, 49);
            this.tb_InputFile.Name = "tb_InputFile";
            this.tb_InputFile.Size = new System.Drawing.Size(235, 20);
            this.tb_InputFile.TabIndex = 2;
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OpenFile.Location = new System.Drawing.Point(263, 49);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(75, 20);
            this.btn_OpenFile.TabIndex = 3;
            this.btn_OpenFile.Text = "Select File";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // l_InputFile
            // 
            this.l_InputFile.AutoSize = true;
            this.l_InputFile.Location = new System.Drawing.Point(13, 30);
            this.l_InputFile.Name = "l_InputFile";
            this.l_InputFile.Size = new System.Drawing.Size(53, 13);
            this.l_InputFile.TabIndex = 4;
            this.l_InputFile.Text = "Input File:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 254);
            this.Controls.Add(this.l_InputFile);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.tb_InputFile);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_MakeCheatNote);
            this.MaximumSize = new System.Drawing.Size(394, 293);
            this.MinimumSize = new System.Drawing.Size(394, 293);
            this.Name = "Form1";
            this.Text = "Minesweeper Cheat Note Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MakeCheatNote;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox tb_InputFile;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Label l_InputFile;
    }
}

