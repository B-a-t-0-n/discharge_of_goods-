namespace GrandLineApp
{
    partial class GrandLineForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            buttonCreateTable = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 84, 84);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 54);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(476, 223);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonCreateTable);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(304, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(172, 223);
            panel3.TabIndex = 1;
            // 
            // buttonCreateTable
            // 
            buttonCreateTable.BackColor = Color.SlateBlue;
            buttonCreateTable.Cursor = Cursors.Hand;
            buttonCreateTable.Dock = DockStyle.Bottom;
            buttonCreateTable.FlatAppearance.BorderSize = 0;
            buttonCreateTable.FlatStyle = FlatStyle.Flat;
            buttonCreateTable.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCreateTable.ForeColor = Color.White;
            buttonCreateTable.Location = new Point(0, 185);
            buttonCreateTable.Name = "buttonCreateTable";
            buttonCreateTable.Size = new Size(172, 38);
            buttonCreateTable.TabIndex = 0;
            buttonCreateTable.Text = "cоздать таблицу";
            buttonCreateTable.UseVisualStyleBackColor = false;
            // 
            // GrandLineForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(476, 277);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "GrandLineForm";
            Text = "GrandLine";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button buttonCreateTable;
        private Panel panel3;
        private System.Windows.Forms.Timer timer1;
    }
}
