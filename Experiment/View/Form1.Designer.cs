namespace Experiment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnPanel = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button5 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            logoPnl = new Label();
            panel1 = new Panel();
            labelonp = new Label();
            Screenpanel = new Panel();
            btnPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPanel
            // 
            btnPanel.BackColor = Color.FromArgb(105, 54, 158);
            btnPanel.Controls.Add(button4);
            btnPanel.Controls.Add(button3);
            btnPanel.Controls.Add(button2);
            btnPanel.Controls.Add(button5);
            btnPanel.Controls.Add(button1);
            btnPanel.Controls.Add(panel2);
            btnPanel.Dock = DockStyle.Left;
            btnPanel.Location = new Point(0, 0);
            btnPanel.Margin = new Padding(3, 4, 3, 4);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(229, 875);
            btnPanel.TabIndex = 0;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 409);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Padding = new Padding(11, 0, 0, 0);
            button4.Size = new Size(229, 100);
            button4.TabIndex = 8;
            button4.Text = "   Mægler";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 309);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Padding = new Padding(11, 0, 0, 0);
            button3.Size = new Size(229, 100);
            button3.TabIndex = 7;
            button3.Text = "   Køber";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 209);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(11, 0, 0, 0);
            button2.Size = new Size(229, 100);
            button2.TabIndex = 6;
            button2.Text = "   Sælger";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Bottom;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 815);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(229, 60);
            button5.TabIndex = 5;
            button5.Text = "Admin Login";
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 109);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(11, 0, 0, 0);
            button1.Size = new Size(229, 100);
            button1.TabIndex = 1;
            button1.Text = "   Bolig";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 26, 48);
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(logoPnl);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 109);
            panel2.TabIndex = 0;
            // 
            // logoPnl
            // 
            logoPnl.BackColor = Color.FromArgb(105, 54, 158);
            logoPnl.Dock = DockStyle.Top;
            logoPnl.Font = new Font("Myanmar Text", 42F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoPnl.ForeColor = Color.Transparent;
            logoPnl.Location = new Point(0, 0);
            logoPnl.Name = "logoPnl";
            logoPnl.Size = new Size(229, 109);
            logoPnl.TabIndex = 0;
            logoPnl.Text = "EDC";
            logoPnl.TextAlign = ContentAlignment.MiddleCenter;
            logoPnl.Click += logoPnl_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(labelonp);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(229, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 109);
            panel1.TabIndex = 1;
            // 
            // labelonp
            // 
            labelonp.AutoSize = true;
            labelonp.Font = new Font("Myanmar Text", 23.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelonp.ForeColor = Color.Black;
            labelonp.Location = new Point(8, 16);
            labelonp.Name = "labelonp";
            labelonp.Size = new Size(135, 70);
            labelonp.TabIndex = 0;
            labelonp.Text = "HJEM";
            labelonp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Screenpanel
            // 
            Screenpanel.AutoSize = true;
            Screenpanel.BackColor = Color.White;
            Screenpanel.Dock = DockStyle.Fill;
            Screenpanel.Location = new Point(229, 109);
            Screenpanel.Margin = new Padding(3, 4, 3, 4);
            Screenpanel.Name = "Screenpanel";
            Screenpanel.Size = new Size(1014, 766);
            Screenpanel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 229);
            ClientSize = new Size(1243, 875);
            Controls.Add(Screenpanel);
            Controls.Add(panel1);
            Controls.Add(btnPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            btnPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel btnPanel;
        private Button button1;
        private Panel panel2;
        private Button button5;
        private Label logoPnl;
        private Button button3;
        private Button button2;
        private Button button4;
        private Panel panel1;
        private Label labelonp;
        private Panel Screenpanel;
    }
}
