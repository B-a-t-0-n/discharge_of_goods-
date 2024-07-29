namespace AppWindowsForm
{
    partial class DockeForm
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
            panelUser = new Panel();
            panel1 = new Panel();
            buttonUser = new Button();
            labelInfoLoad = new Label();
            panel2 = new Panel();
            listBoxAgrees = new ListBox();
            panel5 = new Panel();
            label3 = new Label();
            listBoxFactories = new ListBox();
            panel4 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            richTextBoxInfo = new RichTextBox();
            panel7 = new Panel();
            checkBoxBuy = new CheckBox();
            label5 = new Label();
            panel6 = new Panel();
            label4 = new Label();
            trackBarSpeed = new TrackBar();
            label1 = new Label();
            buttonCreateTable = new Button();
            timerAnimationLoading = new System.Windows.Forms.Timer(components);
            panelUser.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).BeginInit();
            SuspendLayout();
            // 
            // panelUser
            // 
            panelUser.BackColor = Color.FromArgb(84, 84, 84);
            panelUser.Controls.Add(panel1);
            panelUser.Controls.Add(buttonUser);
            panelUser.Controls.Add(labelInfoLoad);
            panelUser.Dock = DockStyle.Top;
            panelUser.Location = new Point(0, 0);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(898, 42);
            panelUser.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.angle_left;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(12, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(30, 28);
            panel1.TabIndex = 2;
            panel1.Click += panel1_Click;
            // 
            // buttonUser
            // 
            buttonUser.BackColor = Color.FromArgb(64, 64, 64);
            buttonUser.BackgroundImage = Properties.Resources.user__3_;
            buttonUser.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUser.Cursor = Cursors.Hand;
            buttonUser.Enabled = false;
            buttonUser.FlatAppearance.BorderSize = 0;
            buttonUser.FlatStyle = FlatStyle.Flat;
            buttonUser.Location = new Point(850, 0);
            buttonUser.Name = "buttonUser";
            buttonUser.Size = new Size(48, 42);
            buttonUser.TabIndex = 0;
            buttonUser.UseVisualStyleBackColor = false;
            // 
            // labelInfoLoad
            // 
            labelInfoLoad.AutoSize = true;
            labelInfoLoad.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelInfoLoad.ForeColor = Color.White;
            labelInfoLoad.Location = new Point(330, 9);
            labelInfoLoad.Name = "labelInfoLoad";
            labelInfoLoad.Size = new Size(0, 25);
            labelInfoLoad.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(listBoxAgrees);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(listBoxFactories);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(898, 382);
            panel2.TabIndex = 1;
            // 
            // listBoxAgrees
            // 
            listBoxAgrees.BackColor = Color.FromArgb(54, 54, 54);
            listBoxAgrees.BorderStyle = BorderStyle.None;
            listBoxAgrees.Dock = DockStyle.Top;
            listBoxAgrees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxAgrees.ForeColor = Color.White;
            listBoxAgrees.FormattingEnabled = true;
            listBoxAgrees.ItemHeight = 21;
            listBoxAgrees.Location = new Point(0, 215);
            listBoxAgrees.Name = "listBoxAgrees";
            listBoxAgrees.Size = new Size(599, 168);
            listBoxAgrees.TabIndex = 6;
            listBoxAgrees.SelectedIndexChanged += listBoxAgreements_SelectedIndexChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 181);
            panel5.Name = "panel5";
            panel5.Size = new Size(599, 34);
            panel5.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(205, 25);
            label3.TabIndex = 2;
            label3.Text = "выберите соглашение";
            // 
            // listBoxFactories
            // 
            listBoxFactories.BackColor = Color.FromArgb(54, 54, 54);
            listBoxFactories.BorderStyle = BorderStyle.None;
            listBoxFactories.Dock = DockStyle.Top;
            listBoxFactories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxFactories.ForeColor = Color.White;
            listBoxFactories.FormattingEnabled = true;
            listBoxFactories.ItemHeight = 21;
            listBoxFactories.Location = new Point(0, 34);
            listBoxFactories.Name = "listBoxFactories";
            listBoxFactories.Size = new Size(599, 147);
            listBoxFactories.TabIndex = 4;
            listBoxFactories.SelectedIndexChanged += listBoxBranches_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(599, 34);
            panel4.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 2;
            label2.Text = "выберите фабрику";
            // 
            // panel3
            // 
            panel3.Controls.Add(richTextBoxInfo);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(buttonCreateTable);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(599, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(299, 382);
            panel3.TabIndex = 1;
            // 
            // richTextBoxInfo
            // 
            richTextBoxInfo.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxInfo.BorderStyle = BorderStyle.None;
            richTextBoxInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxInfo.ForeColor = Color.White;
            richTextBoxInfo.Location = new Point(6, 47);
            richTextBoxInfo.Name = "richTextBoxInfo";
            richTextBoxInfo.Size = new Size(293, 172);
            richTextBoxInfo.TabIndex = 2;
            richTextBoxInfo.Text = "";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(84, 84, 84);
            panel7.Controls.Add(checkBoxBuy);
            panel7.Controls.Add(label5);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 225);
            panel7.Name = "panel7";
            panel7.Size = new Size(299, 42);
            panel7.TabIndex = 4;
            // 
            // checkBoxBuy
            // 
            checkBoxBuy.AutoSize = true;
            checkBoxBuy.Checked = true;
            checkBoxBuy.CheckState = CheckState.Checked;
            checkBoxBuy.Cursor = Cursors.Hand;
            checkBoxBuy.Font = new Font("Segoe UI", 14.25F);
            checkBoxBuy.ForeColor = Color.White;
            checkBoxBuy.Location = new Point(6, 9);
            checkBoxBuy.Name = "checkBoxBuy";
            checkBoxBuy.Size = new Size(158, 29);
            checkBoxBuy.TabIndex = 1;
            checkBoxBuy.Text = "Можно купить";
            checkBoxBuy.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(330, 9);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(label4);
            panel6.Controls.Add(trackBarSpeed);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 267);
            panel6.Name = "panel6";
            panel6.Size = new Size(299, 77);
            panel6.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 4);
            label4.Name = "label4";
            label4.Size = new Size(168, 25);
            label4.TabIndex = 2;
            label4.Text = "скорость загрузки";
            // 
            // trackBarSpeed
            // 
            trackBarSpeed.Dock = DockStyle.Bottom;
            trackBarSpeed.Location = new Point(0, 32);
            trackBarSpeed.Name = "trackBarSpeed";
            trackBarSpeed.Size = new Size(299, 45);
            trackBarSpeed.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 1;
            label1.Text = "доп. инф.";
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
            buttonCreateTable.Location = new Point(0, 344);
            buttonCreateTable.Name = "buttonCreateTable";
            buttonCreateTable.Size = new Size(299, 38);
            buttonCreateTable.TabIndex = 0;
            buttonCreateTable.Text = "cоздать таблицу";
            buttonCreateTable.UseVisualStyleBackColor = false;
            buttonCreateTable.Click += buttonCreateTable_Click;
            // 
            // timerAnimationLoading
            // 
            timerAnimationLoading.Interval = 1000;
            timerAnimationLoading.Tick += timerAnimationLoading_Tick;
            // 
            // DockeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(898, 424);
            Controls.Add(panel2);
            Controls.Add(panelUser);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DockeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Docke v1";
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUser;
        private Panel panel2;
        private Button buttonCreateTable;
        private Panel panel3;
        private ListBox listBoxAgrees;
        private Panel panel5;
        private ListBox listBoxFactories;
        private Panel panel4;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label labelInfo;
        private RichTextBox richTextBoxInfo;
        private Label labelInfoLoad;
        private Panel panel6;
        private Label label4;
        private TrackBar trackBarSpeed;
        private System.Windows.Forms.Timer timerAnimationLoading;
        private Panel panel7;
        private Label label5;
        private CheckBox checkBoxBuy;
        private Button buttonUser;
        private Panel panel1;
    }
}
