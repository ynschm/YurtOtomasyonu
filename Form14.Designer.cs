﻿namespace YurtKayitSistemi
{
    partial class Form14
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.TxtPersonelid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPersonelGorev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPersonelAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtKayitDataSet8 = new YurtKayitSistemi.YurtKayitDataSet8();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new YurtKayitSistemi.YurtKayitDataSet8TableAdapters.PersonelTableAdapter();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPersonelid
            // 
            this.TxtPersonelid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonelid.Location = new System.Drawing.Point(286, 28);
            this.TxtPersonelid.Name = "TxtPersonelid";
            this.TxtPersonelid.Size = new System.Drawing.Size(171, 30);
            this.TxtPersonelid.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(165, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personel id:";
            // 
            // TxtPersonelGorev
            // 
            this.TxtPersonelGorev.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonelGorev.Location = new System.Drawing.Point(286, 130);
            this.TxtPersonelGorev.Name = "TxtPersonelGorev";
            this.TxtPersonelGorev.Size = new System.Drawing.Size(171, 30);
            this.TxtPersonelGorev.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(128, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Görev:";
            // 
            // TxtPersonelAd
            // 
            this.TxtPersonelAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonelAd.Location = new System.Drawing.Point(286, 74);
            this.TxtPersonelAd.Name = "TxtPersonelAd";
            this.TxtPersonelAd.Size = new System.Drawing.Size(171, 30);
            this.TxtPersonelAd.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(158, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel Ad:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(132, 195);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(124, 37);
            this.BtnKaydet.TabIndex = 8;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(278, 195);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(124, 37);
            this.BtnSil.TabIndex = 9;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(428, 195);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(124, 37);
            this.BtnGuncelle.TabIndex = 10;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.personelAdSoyadDataGridViewTextBoxColumn,
            this.personelDepartmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(66, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(557, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yurtKayitDataSet8
            // 
            this.yurtKayitDataSet8.DataSetName = "YurtKayitDataSet8";
            this.yurtKayitDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.yurtKayitDataSet8;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "Personelid";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "Personelid";
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelAdSoyadDataGridViewTextBoxColumn
            // 
            this.personelAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.Name = "personelAdSoyadDataGridViewTextBoxColumn";
            // 
            // personelDepartmanDataGridViewTextBoxColumn
            // 
            this.personelDepartmanDataGridViewTextBoxColumn.DataPropertyName = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.HeaderText = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.Name = "personelDepartmanDataGridViewTextBoxColumn";
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtPersonelAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPersonelGorev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPersonelid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form14";
            this.Text = "Personel ";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPersonelid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPersonelGorev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPersonelAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtKayitDataSet8 yurtKayitDataSet8;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private YurtKayitDataSet8TableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDepartmanDataGridViewTextBoxColumn;
    }
}