﻿namespace AplikasiLatihanTiga3
{
    partial class frmLatihanTiga3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPekerjaan = new System.Windows.Forms.ListBox();
            this.txtPesan1 = new System.Windows.Forms.TextBox();
            this.txtPesan2 = new System.Windows.Forms.TextBox();
            this.txtPesan3 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.cmbPendidikan = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pendidikan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pekerjaan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lstPekerjaan
            // 
            this.lstPekerjaan.FormattingEnabled = true;
            this.lstPekerjaan.ItemHeight = 20;
            this.lstPekerjaan.Items.AddRange(new object[] {
            "PEDAGANG",
            "PNS",
            "DOSEN",
            "SWASTA",
            "ABRI",
            "NGANGGUR",
            "GADANG",
            "PUSH RANK"});
            this.lstPekerjaan.Location = new System.Drawing.Point(119, 139);
            this.lstPekerjaan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPekerjaan.Name = "lstPekerjaan";
            this.lstPekerjaan.Size = new System.Drawing.Size(608, 184);
            this.lstPekerjaan.TabIndex = 5;
            this.lstPekerjaan.SelectedIndexChanged += new System.EventHandler(this.lstPekerjaan_SelectedIndexChanged);
            // 
            // txtPesan1
            // 
            this.txtPesan1.Enabled = false;
            this.txtPesan1.Location = new System.Drawing.Point(4, 5);
            this.txtPesan1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPesan1.Name = "txtPesan1";
            this.txtPesan1.Size = new System.Drawing.Size(723, 26);
            this.txtPesan1.TabIndex = 6;
            // 
            // txtPesan2
            // 
            this.txtPesan2.Enabled = false;
            this.txtPesan2.Location = new System.Drawing.Point(4, 41);
            this.txtPesan2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPesan2.Name = "txtPesan2";
            this.txtPesan2.Size = new System.Drawing.Size(723, 26);
            this.txtPesan2.TabIndex = 7;
            this.txtPesan2.TextChanged += new System.EventHandler(this.txtPesan2_TextChanged);
            // 
            // txtPesan3
            // 
            this.txtPesan3.Enabled = false;
            this.txtPesan3.Location = new System.Drawing.Point(4, 77);
            this.txtPesan3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPesan3.Name = "txtPesan3";
            this.txtPesan3.Size = new System.Drawing.Size(723, 26);
            this.txtPesan3.TabIndex = 8;
            this.txtPesan3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(4, 113);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(723, 57);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cmbPendidikan
            // 
            this.cmbPendidikan.FormattingEnabled = true;
            this.cmbPendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "DIPLOMA",
            "SARJANA",
            "PASCASARJANA",
            ""});
            this.cmbPendidikan.Location = new System.Drawing.Point(119, 72);
            this.cmbPendidikan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPendidikan.Name = "cmbPendidikan";
            this.cmbPendidikan.Size = new System.Drawing.Size(608, 28);
            this.cmbPendidikan.TabIndex = 10;
            this.cmbPendidikan.SelectedIndexChanged += new System.EventHandler(this.cmbPendidikan_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 5);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(608, 26);
            this.txtName.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.71429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.28571F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbPendidikan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lstPekerjaan, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(735, 328);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtPesan1);
            this.flowLayoutPanel1.Controls.Add(this.txtPesan2);
            this.flowLayoutPanel1.Controls.Add(this.txtPesan3);
            this.flowLayoutPanel1.Controls.Add(this.btnOk);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 352);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(735, 186);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // frmLatihanTiga3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 552);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLatihanTiga3";
            this.Text = "Latihan 3.3";
            this.Load += new System.EventHandler(this.frmLatihanTiga3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPekerjaan;
        private System.Windows.Forms.TextBox txtPesan1;
        private System.Windows.Forms.TextBox txtPesan2;
        private System.Windows.Forms.TextBox txtPesan3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cmbPendidikan;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

