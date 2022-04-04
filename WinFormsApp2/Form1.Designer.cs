namespace WinFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.button_proses = new System.Windows.Forms.Button();
            this.checkBox_block = new System.Windows.Forms.CheckBox();
            this.comboBox_mode = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mode:";
            // 
            // textBox_Data
            // 
            this.textBox_Data.Location = new System.Drawing.Point(93, 29);
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.Size = new System.Drawing.Size(262, 31);
            this.textBox_Data.TabIndex = 2;
            this.textBox_Data.TextChanged += new System.EventHandler(this.textBox_Data_TextChanged);
            // 
            // button_proses
            // 
            this.button_proses.Location = new System.Drawing.Point(34, 136);
            this.button_proses.Name = "button_proses";
            this.button_proses.Size = new System.Drawing.Size(112, 34);
            this.button_proses.TabIndex = 4;
            this.button_proses.Text = "Proses ";
            this.button_proses.UseVisualStyleBackColor = true;
            this.button_proses.Click += new System.EventHandler(this.button_proses_Click);
            // 
            // checkBox_block
            // 
            this.checkBox_block.AutoSize = true;
            this.checkBox_block.Location = new System.Drawing.Point(323, 141);
            this.checkBox_block.Name = "checkBox_block";
            this.checkBox_block.Size = new System.Drawing.Size(80, 29);
            this.checkBox_block.TabIndex = 5;
            this.checkBox_block.Text = "Block";
            this.checkBox_block.UseVisualStyleBackColor = true;
            this.checkBox_block.CheckedChanged += new System.EventHandler(this.checkBox_block_CheckedChanged);
            // 
            // comboBox_mode
            // 
            this.comboBox_mode.FormattingEnabled = true;
            this.comboBox_mode.Location = new System.Drawing.Point(93, 71);
            this.comboBox_mode.Name = "comboBox_mode";
            this.comboBox_mode.Size = new System.Drawing.Size(182, 33);
            this.comboBox_mode.TabIndex = 6;
            this.comboBox_mode.SelectedIndexChanged += new System.EventHandler(this.comboBox_mode_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(34, 203);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 279);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(323, 203);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(180, 279);
            this.listBox2.TabIndex = 8;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(244, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(244, 383);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 34);
            this.button4.TabIndex = 12;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(244, 423);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 34);
            this.button5.TabIndex = 13;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 519);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox_mode);
            this.Controls.Add(this.checkBox_block);
            this.Controls.Add(this.button_proses);
            this.Controls.Add(this.textBox_Data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Tugas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_Data;
        private Button button_proses;
        private CheckBox checkBox_block;
        private ComboBox comboBox_mode;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}