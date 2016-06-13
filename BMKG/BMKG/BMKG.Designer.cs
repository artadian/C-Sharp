namespace WindowsFormsApplication1
{
    partial class BMKG
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_maxhuj = new System.Windows.Forms.Label();
            this.lbl_maxsuhu = new System.Windows.Forms.Label();
            this.lbl_maxlembab = new System.Windows.Forms.Label();
            this.lbl_minhuj = new System.Windows.Forms.Label();
            this.lbl_minsuhu = new System.Windows.Forms.Label();
            this.lbl_minlembab = new System.Windows.Forms.Label();
            this.lbl_minkec = new System.Windows.Forms.Label();
            this.lbl_maxkec = new System.Windows.Forms.Label();
            this.txt_avgkec = new System.Windows.Forms.TextBox();
            this.txt_avghuj = new System.Windows.Forms.TextBox();
            this.txt_avgsuhu = new System.Windows.Forms.TextBox();
            this.txt_avglembab = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 177);
            this.dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.download;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1231, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 54);
            this.button1.TabIndex = 15;
            this.button1.Text = "Login Admin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "DATA HARI INI";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "BERITA DAN PENGUMUMAN";
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(25, 408);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(382, 220);
            this.listBox1.TabIndex = 37;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Kecepatan Angin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Suhu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Kelembaban";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Minimum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Average";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Maximum";
            // 
            // lbl_maxhuj
            // 
            this.lbl_maxhuj.AutoSize = true;
            this.lbl_maxhuj.Location = new System.Drawing.Point(275, 64);
            this.lbl_maxhuj.Name = "lbl_maxhuj";
            this.lbl_maxhuj.Size = new System.Drawing.Size(10, 13);
            this.lbl_maxhuj.TabIndex = 51;
            this.lbl_maxhuj.Text = "-";
            // 
            // lbl_maxsuhu
            // 
            this.lbl_maxsuhu.AutoSize = true;
            this.lbl_maxsuhu.Location = new System.Drawing.Point(411, 64);
            this.lbl_maxsuhu.Name = "lbl_maxsuhu";
            this.lbl_maxsuhu.Size = new System.Drawing.Size(10, 13);
            this.lbl_maxsuhu.TabIndex = 52;
            this.lbl_maxsuhu.Text = "-";
            // 
            // lbl_maxlembab
            // 
            this.lbl_maxlembab.AutoSize = true;
            this.lbl_maxlembab.Location = new System.Drawing.Point(537, 64);
            this.lbl_maxlembab.Name = "lbl_maxlembab";
            this.lbl_maxlembab.Size = new System.Drawing.Size(10, 13);
            this.lbl_maxlembab.TabIndex = 53;
            this.lbl_maxlembab.Text = "-";
            // 
            // lbl_minhuj
            // 
            this.lbl_minhuj.AutoSize = true;
            this.lbl_minhuj.Location = new System.Drawing.Point(275, 132);
            this.lbl_minhuj.Name = "lbl_minhuj";
            this.lbl_minhuj.Size = new System.Drawing.Size(10, 13);
            this.lbl_minhuj.TabIndex = 55;
            this.lbl_minhuj.Text = "-";
            // 
            // lbl_minsuhu
            // 
            this.lbl_minsuhu.AutoSize = true;
            this.lbl_minsuhu.Location = new System.Drawing.Point(411, 132);
            this.lbl_minsuhu.Name = "lbl_minsuhu";
            this.lbl_minsuhu.Size = new System.Drawing.Size(10, 13);
            this.lbl_minsuhu.TabIndex = 56;
            this.lbl_minsuhu.Text = "-";
            // 
            // lbl_minlembab
            // 
            this.lbl_minlembab.AutoSize = true;
            this.lbl_minlembab.Location = new System.Drawing.Point(542, 132);
            this.lbl_minlembab.Name = "lbl_minlembab";
            this.lbl_minlembab.Size = new System.Drawing.Size(10, 13);
            this.lbl_minlembab.TabIndex = 57;
            this.lbl_minlembab.Text = "-";
            // 
            // lbl_minkec
            // 
            this.lbl_minkec.AutoSize = true;
            this.lbl_minkec.Location = new System.Drawing.Point(144, 132);
            this.lbl_minkec.Name = "lbl_minkec";
            this.lbl_minkec.Size = new System.Drawing.Size(10, 13);
            this.lbl_minkec.TabIndex = 54;
            this.lbl_minkec.Text = "-";
            // 
            // lbl_maxkec
            // 
            this.lbl_maxkec.AutoSize = true;
            this.lbl_maxkec.Location = new System.Drawing.Point(144, 64);
            this.lbl_maxkec.Name = "lbl_maxkec";
            this.lbl_maxkec.Size = new System.Drawing.Size(10, 13);
            this.lbl_maxkec.TabIndex = 50;
            this.lbl_maxkec.Text = "-";
            // 
            // txt_avgkec
            // 
            this.txt_avgkec.Location = new System.Drawing.Point(98, 94);
            this.txt_avgkec.Name = "txt_avgkec";
            this.txt_avgkec.ReadOnly = true;
            this.txt_avgkec.Size = new System.Drawing.Size(100, 20);
            this.txt_avgkec.TabIndex = 58;
            this.txt_avgkec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_avghuj
            // 
            this.txt_avghuj.Location = new System.Drawing.Point(233, 94);
            this.txt_avghuj.Name = "txt_avghuj";
            this.txt_avghuj.ReadOnly = true;
            this.txt_avghuj.Size = new System.Drawing.Size(100, 20);
            this.txt_avghuj.TabIndex = 59;
            this.txt_avghuj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_avgsuhu
            // 
            this.txt_avgsuhu.Location = new System.Drawing.Point(361, 94);
            this.txt_avgsuhu.Name = "txt_avgsuhu";
            this.txt_avgsuhu.ReadOnly = true;
            this.txt_avgsuhu.Size = new System.Drawing.Size(100, 20);
            this.txt_avgsuhu.TabIndex = 60;
            this.txt_avgsuhu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_avglembab
            // 
            this.txt_avglembab.Location = new System.Drawing.Point(496, 94);
            this.txt_avglembab.Name = "txt_avglembab";
            this.txt_avglembab.ReadOnly = true;
            this.txt_avglembab.Size = new System.Drawing.Size(100, 20);
            this.txt_avglembab.TabIndex = 61;
            this.txt_avglembab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Curah Hujan";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_avglembab);
            this.groupBox1.Controls.Add(this.txt_avgsuhu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_avghuj);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_avgkec);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_minlembab);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_minsuhu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_minhuj);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl_minkec);
            this.groupBox1.Controls.Add(this.lbl_maxkec);
            this.groupBox1.Controls.Add(this.lbl_maxlembab);
            this.groupBox1.Controls.Add(this.lbl_maxhuj);
            this.groupBox1.Controls.Add(this.lbl_maxsuhu);
            this.groupBox1.Location = new System.Drawing.Point(703, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 177);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 18);
            this.label11.TabIndex = 64;
            this.label11.Text = "Daftar Isi";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(442, 408);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(415, 261);
            this.richTextBox1.TabIndex = 65;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.dance;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(1023, 484);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1193, 632);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 67;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BMKG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bg_gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "BMKG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMKG";
            this.Load += new System.EventHandler(this.BMKG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_maxhuj;
        private System.Windows.Forms.Label lbl_maxsuhu;
        private System.Windows.Forms.Label lbl_maxlembab;
        private System.Windows.Forms.Label lbl_minhuj;
        private System.Windows.Forms.Label lbl_minsuhu;
        private System.Windows.Forms.Label lbl_minlembab;
        private System.Windows.Forms.Label lbl_minkec;
        private System.Windows.Forms.Label lbl_maxkec;
        private System.Windows.Forms.TextBox txt_avgkec;
        private System.Windows.Forms.TextBox txt_avghuj;
        private System.Windows.Forms.TextBox txt_avgsuhu;
        private System.Windows.Forms.TextBox txt_avglembab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}

