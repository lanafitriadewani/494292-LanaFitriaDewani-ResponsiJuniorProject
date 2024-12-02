namespace responsiJunpro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNama = new TextBox();
            cbDep = new ComboBox();
            cbJabatan = new ComboBox();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvDataKaryawan = new DataGridView();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataKaryawan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 83);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 123);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Dep. Karyawan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 159);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Jabatan :";
            label3.Click += label3_Click;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(153, 83);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(232, 23);
            tbNama.TabIndex = 3;
            // 
            // cbDep
            // 
            cbDep.FormattingEnabled = true;
            cbDep.Location = new Point(153, 120);
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(232, 23);
            cbDep.TabIndex = 4;
            // 
            // cbJabatan
            // 
            cbJabatan.FormattingEnabled = true;
            cbJabatan.Location = new Point(153, 156);
            cbJabatan.Name = "cbJabatan";
            cbJabatan.Size = new Size(232, 23);
            cbJabatan.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(427, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 106);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 8);
            label4.Name = "label4";
            label4.Size = new Size(123, 90);
            label4.TabIndex = 7;
            label4.Text = "ID Departemen:\r\nHR: HR\r\nENG: Engineer\r\nDEV: Developer\r\nPM: Product Manager\r\nFIN: Finance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 240);
            label5.Name = "label5";
            label5.Size = new Size(141, 15);
            label5.TabIndex = 7;
            label5.Text = "ID Karyawan yang Dipilih:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(167, 240);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 8;
            // 
            // dgvDataKaryawan
            // 
            dgvDataKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataKaryawan.Location = new Point(30, 269);
            dgvDataKaryawan.Name = "dgvDataKaryawan";
            dgvDataKaryawan.RowTemplate.Height = 25;
            dgvDataKaryawan.Size = new Size(546, 170);
            dgvDataKaryawan.TabIndex = 9;
            dgvDataKaryawan.CellContentClick += dgvDataKaryawan_CellContentClick;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(30, 201);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(157, 23);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(228, 201);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(157, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(419, 201);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(157, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(419, 457);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(157, 23);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 508);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dgvDataKaryawan);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(cbJabatan);
            Controls.Add(cbDep);
            Controls.Add(tbNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataKaryawan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbNama;
        private ComboBox cbDep;
        private ComboBox cbJabatan;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgvDataKaryawan;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoad;
    }
}