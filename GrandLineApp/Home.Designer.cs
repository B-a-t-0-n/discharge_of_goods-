namespace AppWindowsForm
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonOpenFormGrandLine = new Button();
            buttonOpenFormDocke = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 25);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 0;
            label1.Text = "Выберете источник";
            // 
            // buttonOpenFormGrandLine
            // 
            buttonOpenFormGrandLine.BackColor = Color.SlateBlue;
            buttonOpenFormGrandLine.Cursor = Cursors.Hand;
            buttonOpenFormGrandLine.FlatAppearance.BorderSize = 0;
            buttonOpenFormGrandLine.FlatStyle = FlatStyle.Flat;
            buttonOpenFormGrandLine.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOpenFormGrandLine.ForeColor = Color.White;
            buttonOpenFormGrandLine.Location = new Point(3, 3);
            buttonOpenFormGrandLine.Name = "buttonOpenFormGrandLine";
            buttonOpenFormGrandLine.Size = new Size(324, 41);
            buttonOpenFormGrandLine.TabIndex = 1;
            buttonOpenFormGrandLine.Text = "Grand Line";
            buttonOpenFormGrandLine.UseVisualStyleBackColor = false;
            buttonOpenFormGrandLine.Click += buttonOpenFormGrandLine_Click;
            // 
            // buttonOpenFormDocke
            // 
            buttonOpenFormDocke.BackColor = Color.SlateBlue;
            buttonOpenFormDocke.Cursor = Cursors.Hand;
            buttonOpenFormDocke.FlatAppearance.BorderSize = 0;
            buttonOpenFormDocke.FlatStyle = FlatStyle.Flat;
            buttonOpenFormDocke.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOpenFormDocke.ForeColor = Color.White;
            buttonOpenFormDocke.Location = new Point(3, 50);
            buttonOpenFormDocke.Name = "buttonOpenFormDocke";
            buttonOpenFormDocke.Size = new Size(321, 41);
            buttonOpenFormDocke.TabIndex = 2;
            buttonOpenFormDocke.Text = "Docke";
            buttonOpenFormDocke.UseVisualStyleBackColor = false;
            buttonOpenFormDocke.Click += buttonOpenFormDocke_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonOpenFormGrandLine);
            flowLayoutPanel1.Controls.Add(buttonOpenFormDocke);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 74);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(323, 144);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(323, 218);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonOpenFormGrandLine;
        private Button buttonOpenFormDocke;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}