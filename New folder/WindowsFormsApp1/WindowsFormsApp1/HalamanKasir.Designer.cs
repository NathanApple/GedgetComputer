namespace WindowsFormsApp1
{
    partial class HalamanKasir
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
            this.datagridbarang = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_item = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_kasir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_mem = new System.Windows.Forms.TextBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cek = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_newtr = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridbarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridbarang
            // 
            this.datagridbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridbarang.Location = new System.Drawing.Point(1001, 294);
            this.datagridbarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagridbarang.Name = "datagridbarang";
            this.datagridbarang.RowHeadersWidth = 51;
            this.datagridbarang.RowTemplate.Height = 24;
            this.datagridbarang.Size = new System.Drawing.Size(335, 393);
            this.datagridbarang.TabIndex = 0;
            this.datagridbarang.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridbarang_RowHeaderMouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 245);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(931, 442);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(996, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "SEARCH";
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(1115, 245);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(223, 30);
            this.tb_search.TabIndex = 35;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(1001, 146);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(164, 38);
            this.btn_insert.TabIndex = 37;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1171, 146);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 38);
            this.button2.TabIndex = 38;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(25, 191);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 38);
            this.button3.TabIndex = 39;
            this.button3.Text = "Delete Order";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_print
            // 
            this.btn_print.Enabled = false;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(709, 191);
            this.btn_print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(245, 38);
            this.btn_print.TabIndex = 40;
            this.btn_print.Text = "Print Transaction";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(996, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "ITEM";
            // 
            // tb_item
            // 
            this.tb_item.Enabled = false;
            this.tb_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_item.Location = new System.Drawing.Point(1061, 199);
            this.tb_item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_item.Name = "tb_item";
            this.tb_item.Size = new System.Drawing.Size(273, 30);
            this.tb_item.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "Cashier Name";
            // 
            // tb_kasir
            // 
            this.tb_kasir.Enabled = false;
            this.tb_kasir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kasir.Location = new System.Drawing.Point(213, 105);
            this.tb_kasir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_kasir.Name = "tb_kasir";
            this.tb_kasir.Size = new System.Drawing.Size(306, 30);
            this.tb_kasir.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Member Phone";
            // 
            // tb_mem
            // 
            this.tb_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mem.Location = new System.Drawing.Point(213, 146);
            this.tb_mem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_mem.Name = "tb_mem";
            this.tb_mem.Size = new System.Drawing.Size(306, 30);
            this.tb_mem.TabIndex = 46;
            this.tb_mem.Text = "DEFAULT";
            // 
            // tb_total
            // 
            this.tb_total.Enabled = false;
            this.tb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total.Location = new System.Drawing.Point(328, 196);
            this.tb_total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(367, 30);
            this.tb_total.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Total";
            // 
            // btn_cek
            // 
            this.btn_cek.Enabled = false;
            this.btn_cek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cek.Location = new System.Drawing.Point(525, 146);
            this.btn_cek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cek.Name = "btn_cek";
            this.btn_cek.Size = new System.Drawing.Size(143, 34);
            this.btn_cek.TabIndex = 49;
            this.btn_cek.Text = "Check";
            this.btn_cek.UseVisualStyleBackColor = true;
            this.btn_cek.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1224, 26);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 54);
            this.button6.TabIndex = 50;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btn_newtr
            // 
            this.btn_newtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newtr.Location = new System.Drawing.Point(525, 105);
            this.btn_newtr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_newtr.Name = "btn_newtr";
            this.btn_newtr.Size = new System.Drawing.Size(288, 32);
            this.btn_newtr.TabIndex = 51;
            this.btn_newtr.Text = "New Transaction";
            this.btn_newtr.UseVisualStyleBackColor = true;
            this.btn_newtr.Click += new System.EventHandler(this.button7_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(25, 26);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(243, 54);
            this.button7.TabIndex = 52;
            this.button7.Text = "Cancel Transaction";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(674, 146);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(139, 34);
            this.button8.TabIndex = 53;
            this.button8.Text = "New";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(819, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 75);
            this.button1.TabIndex = 54;
            this.button1.Text = "Add Bonus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // HalamanKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 718);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn_newtr);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_cek);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_mem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_kasir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_item);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.datagridbarang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HalamanKasir";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HalamanKasir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridbarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridbarang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_kasir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_mem;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cek;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_newtr;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
    }
}