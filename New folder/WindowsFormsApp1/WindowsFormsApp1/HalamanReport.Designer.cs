namespace WindowsFormsApp1
{
    partial class HalamanReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridbarang = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_terjual = new System.Windows.Forms.TextBox();
            this.tb_masuk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_untung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_petugas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_member = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_terlaku = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_teraktif = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gridpetugas = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridbarang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridpetugas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gridbarang
            // 
            this.gridbarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridbarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridbarang.Location = new System.Drawing.Point(12, 51);
            this.gridbarang.Name = "gridbarang";
            this.gridbarang.RowHeadersWidth = 51;
            this.gridbarang.RowTemplate.Height = 24;
            this.gridbarang.Size = new System.Drawing.Size(833, 507);
            this.gridbarang.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Barang Terjual";
            // 
            // tb_terjual
            // 
            this.tb_terjual.Location = new System.Drawing.Point(160, 41);
            this.tb_terjual.Name = "tb_terjual";
            this.tb_terjual.ReadOnly = true;
            this.tb_terjual.Size = new System.Drawing.Size(179, 22);
            this.tb_terjual.TabIndex = 4;
            this.tb_terjual.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_masuk
            // 
            this.tb_masuk.Location = new System.Drawing.Point(160, 69);
            this.tb_masuk.Name = "tb_masuk";
            this.tb_masuk.ReadOnly = true;
            this.tb_masuk.Size = new System.Drawing.Size(179, 22);
            this.tb_masuk.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Barang masuk";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_untung
            // 
            this.tb_untung.Location = new System.Drawing.Point(160, 97);
            this.tb_untung.Name = "tb_untung";
            this.tb_untung.ReadOnly = true;
            this.tb_untung.Size = new System.Drawing.Size(179, 22);
            this.tb_untung.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Keuntungan";
            // 
            // tb_petugas
            // 
            this.tb_petugas.Location = new System.Drawing.Point(546, 41);
            this.tb_petugas.Name = "tb_petugas";
            this.tb_petugas.ReadOnly = true;
            this.tb_petugas.Size = new System.Drawing.Size(59, 22);
            this.tb_petugas.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Petugas";
            // 
            // tb_member
            // 
            this.tb_member.Location = new System.Drawing.Point(546, 69);
            this.tb_member.Name = "tb_member";
            this.tb_member.ReadOnly = true;
            this.tb_member.Size = new System.Drawing.Size(59, 22);
            this.tb_member.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Member";
            // 
            // date2
            // 
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Location = new System.Drawing.Point(1231, 43);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(200, 27);
            this.date2.TabIndex = 13;
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Location = new System.Drawing.Point(985, 43);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 27);
            this.date1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(981, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Awal Tanggal Report";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1227, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Akhir Tanggal Report";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(1314, 83);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(117, 36);
            this.btn_confirm.TabIndex = 17;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tb_terlaku);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tb_teraktif);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_confirm);
            this.panel1.Controls.Add(this.tb_terjual);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_masuk);
            this.panel1.Controls.Add(this.date1);
            this.panel1.Controls.Add(this.tb_untung);
            this.panel1.Controls.Add(this.date2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_member);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_petugas);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 556);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1489, 194);
            this.panel1.TabIndex = 18;
            // 
            // tb_terlaku
            // 
            this.tb_terlaku.Location = new System.Drawing.Point(160, 15);
            this.tb_terlaku.Name = "tb_terlaku";
            this.tb_terlaku.ReadOnly = true;
            this.tb_terlaku.Size = new System.Drawing.Size(179, 22);
            this.tb_terlaku.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Barang Terlaku";
            // 
            // tb_teraktif
            // 
            this.tb_teraktif.Location = new System.Drawing.Point(546, 14);
            this.tb_teraktif.Name = "tb_teraktif";
            this.tb_teraktif.ReadOnly = true;
            this.tb_teraktif.Size = new System.Drawing.Size(161, 22);
            this.tb_teraktif.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(392, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Petugas Teraktif";
            // 
            // gridpetugas
            // 
            this.gridpetugas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridpetugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridpetugas.Location = new System.Drawing.Point(851, 51);
            this.gridpetugas.Name = "gridpetugas";
            this.gridpetugas.RowHeadersWidth = 51;
            this.gridpetugas.RowTemplate.Height = 24;
            this.gridpetugas.Size = new System.Drawing.Size(650, 507);
            this.gridpetugas.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1232, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 36);
            this.button2.TabIndex = 22;
            this.button2.Text = "Simpan Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(886, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(299, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Simpan report ke dalam Excel";
            // 
            // HalamanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 762);
            this.Controls.Add(this.gridpetugas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridbarang);
            this.Controls.Add(this.label1);
            this.Name = "HalamanReport";
            this.Text = "HalamanReport";
            ((System.ComponentModel.ISupportInitialize)(this.gridbarang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridpetugas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridbarang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_terjual;
        private System.Windows.Forms.TextBox tb_masuk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_untung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_petugas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_member;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_teraktif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_terlaku;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView gridpetugas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
    }
}