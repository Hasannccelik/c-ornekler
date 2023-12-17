namespace WinFormsApp1
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
        public void InitializeComponent()
        {
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(121, 21);
            button1.Name = "button1";
            button1.Size = new Size(63, 22);
            button1.TabIndex = 0;
            button1.Text = "Click Me";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(392, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(69, 20);
            openFileToolStripMenuItem.Text = "Open File";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(71, 20);
            toolStripMenuItem1.Text = "Create Txt";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 240);
            label1.Name = "label1";
            label1.Size = new Size(16, 15);
            label1.TabIndex = 3;
            label1.Text = "...";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(180, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 65);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Txt yazdırma textbox a göre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(392, 267);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ImeMode = ImeMode.Off;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            ShowIcon = false;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}