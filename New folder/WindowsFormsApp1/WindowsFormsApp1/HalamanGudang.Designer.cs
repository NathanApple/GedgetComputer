namespace WindowsFormsApp1
{
    partial class HalamanGudang
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
            this.btn_back = new System.Windows.Forms.Button();
            this.tb_qty = new System.Windows.Forms.NumericUpDown();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.datagridbarang = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_keterangan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tb_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridbarang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(752, 481);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(116, 42);
            this.btn_back.TabIndex = 25;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tb_qty
            // 
            this.tb_qty.Location = new System.Drawing.Point(188, 374);
            this.tb_qty.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.tb_qty.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.Size = new System.Drawing.Size(186, 22);
            this.tb_qty.TabIndex = 24;
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(188, 344);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.ReadOnly = true;
            this.tb_nama.Size = new System.Drawing.Size(388, 22);
            this.tb_nama.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "QTY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "NAMA BARANG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(608, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "SEARCH";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(678, 347);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(186, 22);
            this.tb_search.TabIndex = 19;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(306, 492);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(96, 31);
            this.btn_reset.TabIndex = 18;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(408, 492);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(168, 31);
            this.btn_insert.TabIndex = 15;
            this.btn_insert.Text = "Tambah Stok";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // datagridbarang
            // 
            this.datagridbarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.datagridbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridbarang.Location = new System.Drawing.Point(24, 23);
            this.datagridbarang.Name = "datagridbarang";
            this.datagridbarang.RowHeadersWidth = 51;
            this.datagridbarang.RowTemplate.Height = 24;
            this.datagridbarang.Size = new System.Drawing.Size(856, 298);
            this.datagridbarang.TabIndex = 14;
            this.datagridbarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridbarang_CellContentClick);
            this.datagridbarang.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridbarang_RowHeaderMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 26);
            this.button1.TabIndex = 26;
            this.button1.Text = "Tambah Barang Baru";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button3.Location = new System.Drawing.Point(188, 492);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 31);
            this.button3.TabIndex = 27;
            this.button3.Text = "Update Stok";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Keterangan";
            // 
            // tb_keterangan
            // 
            this.tb_keterangan.Location = new System.Drawing.Point(188, 409);
            this.tb_keterangan.MaxLength = 100;
            this.tb_keterangan.Multiline = true;
            this.tb_keterangan.Name = "tb_keterangan";
            this.tb_keterangan.Size = new System.Drawing.Size(388, 77);
            this.tb_keterangan.TabIndex = 29;
            // 
            // HalamanGudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 556);
            this.Controls.Add(this.tb_keterangan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tb_qty);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.datagridbarang);
            this.Name = "HalamanGudang";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HalamanGudang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridbarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.NumericUpDown tb_qty;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DataGridView datagridbarang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_keterangan;
    }
}