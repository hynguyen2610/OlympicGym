﻿namespace GymFitnessOlympic.View.Dialog
{
    partial class FrmGiaHan
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
            this.txtGiaHanSoTien = new System.Windows.Forms.TextBox();
            this.cbbGiaHanGoi = new System.Windows.Forms.ComboBox();
            this.lblNgayHetHanDuKien = new System.Windows.Forms.Label();
            this.btnGiaHan = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtGiaHanSoTien
            // 
            this.txtGiaHanSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaHanSoTien.Location = new System.Drawing.Point(68, 43);
            this.txtGiaHanSoTien.Name = "txtGiaHanSoTien";
            this.txtGiaHanSoTien.Size = new System.Drawing.Size(228, 22);
            this.txtGiaHanSoTien.TabIndex = 1;
            // 
            // cbbGiaHanGoi
            // 
            this.cbbGiaHanGoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGiaHanGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGiaHanGoi.FormattingEnabled = true;
            this.cbbGiaHanGoi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbGiaHanGoi.Location = new System.Drawing.Point(68, 10);
            this.cbbGiaHanGoi.Name = "cbbGiaHanGoi";
            this.cbbGiaHanGoi.Size = new System.Drawing.Size(228, 24);
            this.cbbGiaHanGoi.TabIndex = 0;
            this.cbbGiaHanGoi.SelectedIndexChanged += new System.EventHandler(this.cbbGiaHanGoi_SelectedIndexChanged);
            // 
            // lblNgayHetHanDuKien
            // 
            this.lblNgayHetHanDuKien.AutoSize = true;
            this.lblNgayHetHanDuKien.Location = new System.Drawing.Point(205, 181);
            this.lblNgayHetHanDuKien.Name = "lblNgayHetHanDuKien";
            this.lblNgayHetHanDuKien.Size = new System.Drawing.Size(57, 15);
            this.lblNgayHetHanDuKien.TabIndex = 9;
            this.lblNgayHetHanDuKien.Text = "Không rõ";
            this.lblNgayHetHanDuKien.Visible = false;
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Image = global::GymFitnessOlympic.Properties.Resources.update;
            this.btnGiaHan.Location = new System.Drawing.Point(67, 214);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(88, 44);
            this.btnGiaHan.TabIndex = 3;
            this.btnGiaHan.Text = "Gia hạn";
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ngày hết hạn dự kiến";
            this.label9.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gói";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số tiền";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDo.Location = new System.Drawing.Point(68, 74);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(228, 91);
            this.txtLyDo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chi chú";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(161, 214);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(77, 44);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Hủy";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmGiaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 270);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.txtGiaHanSoTien);
            this.Controls.Add(this.cbbGiaHanGoi);
            this.Controls.Add(this.lblNgayHetHanDuKien);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Name = "FrmGiaHan";
            this.Text = "Gia hạn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiaHanSoTien;
        private System.Windows.Forms.ComboBox cbbGiaHanGoi;
        private System.Windows.Forms.Label lblNgayHetHanDuKien;
        private DevExpress.XtraEditors.SimpleButton btnGiaHan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}