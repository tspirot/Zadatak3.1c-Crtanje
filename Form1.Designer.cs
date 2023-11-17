namespace Zadatak3._1c
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            pictureBoxBoja = new PictureBox();
            colorDialog1 = new ColorDialog();
            groupBox2 = new GroupBox();
            radioButtonElipsa = new RadioButton();
            radioButtonPravougaonik = new RadioButton();
            radioButtonLinija = new RadioButton();
            groupBox3 = new GroupBox();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBoja).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(172, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(616, 426);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBoxBoja);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(154, 77);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Boja";
            // 
            // pictureBoxBoja
            // 
            pictureBoxBoja.BackColor = Color.Black;
            pictureBoxBoja.Location = new Point(15, 23);
            pictureBoxBoja.Name = "pictureBoxBoja";
            pictureBoxBoja.Size = new Size(128, 44);
            pictureBoxBoja.TabIndex = 0;
            pictureBoxBoja.TabStop = false;
            pictureBoxBoja.Click += pictureBoxBoja_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonElipsa);
            groupBox2.Controls.Add(radioButtonPravougaonik);
            groupBox2.Controls.Add(radioButtonLinija);
            groupBox2.Location = new Point(11, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(155, 144);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Oblik";
            // 
            // radioButtonElipsa
            // 
            radioButtonElipsa.AutoSize = true;
            radioButtonElipsa.Location = new Point(6, 86);
            radioButtonElipsa.Name = "radioButtonElipsa";
            radioButtonElipsa.Size = new Size(69, 24);
            radioButtonElipsa.TabIndex = 2;
            radioButtonElipsa.Text = "Elipsa";
            radioButtonElipsa.UseVisualStyleBackColor = true;
            // 
            // radioButtonPravougaonik
            // 
            radioButtonPravougaonik.AutoSize = true;
            radioButtonPravougaonik.Location = new Point(6, 56);
            radioButtonPravougaonik.Name = "radioButtonPravougaonik";
            radioButtonPravougaonik.Size = new Size(120, 24);
            radioButtonPravougaonik.TabIndex = 1;
            radioButtonPravougaonik.Text = "Pravougaonik";
            radioButtonPravougaonik.UseVisualStyleBackColor = true;
            // 
            // radioButtonLinija
            // 
            radioButtonLinija.AutoSize = true;
            radioButtonLinija.Checked = true;
            radioButtonLinija.Location = new Point(6, 26);
            radioButtonLinija.Name = "radioButtonLinija";
            radioButtonLinija.Size = new Size(65, 24);
            radioButtonLinija.TabIndex = 0;
            radioButtonLinija.TabStop = true;
            radioButtonLinija.Text = "Linija";
            radioButtonLinija.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBox1);
            groupBox3.Location = new Point(11, 252);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(155, 186);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Debljina";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            listBox1.Location = new Point(13, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(131, 144);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBoja).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private PictureBox pictureBoxBoja;
        private ColorDialog colorDialog1;
        private GroupBox groupBox2;
        private RadioButton radioButtonElipsa;
        private RadioButton radioButtonPravougaonik;
        private RadioButton radioButtonLinija;
        private GroupBox groupBox3;
        private ListBox listBox1;
    }
}
