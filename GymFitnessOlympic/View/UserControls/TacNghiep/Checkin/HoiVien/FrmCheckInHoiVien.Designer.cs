﻿namespace GymFitnessOlympic.View.MainForms
{
    partial class FrmCheckinHoiVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.lblTen = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPT_SoNgayConLai = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblPT_NgayHetHan = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblPT_GiaHanCuoi = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblKetQuaGYM = new System.Windows.Forms.Label();
            this.btnGiaHanGYM = new DevExpress.XtraEditors.SimpleButton();
            this.lblChucNang = new System.Windows.Forms.Label();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblKetQuaSauna = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSauSoNgayConLai = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSauNgayHetHan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSauGiaHanCuoi = new System.Windows.Forms.Label();
            this.btnGiaHanSauna = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new CEMS.Controls.Commons.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInGYM = new DevExpress.XtraEditors.SimpleButton();
            this.btnInSauna = new DevExpress.XtraEditors.SimpleButton();
            this.lblThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(13, 61);
            this.txtMa.Name = "txtMa";
            this.txtMa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Properties.Appearance.Options.UseFont = true;
            this.txtMa.Size = new System.Drawing.Size(551, 40);
            this.txtMa.TabIndex = 4;
            this.txtMa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMa_KeyPress);
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.lblTen);
            this.groupControl5.Controls.Add(this.label12);
            this.groupControl5.Controls.Add(this.lblPT_SoNgayConLai);
            this.groupControl5.Controls.Add(this.label16);
            this.groupControl5.Controls.Add(this.lblPT_NgayHetHan);
            this.groupControl5.Controls.Add(this.label18);
            this.groupControl5.Controls.Add(this.lblPT_GiaHanCuoi);
            this.groupControl5.Location = new System.Drawing.Point(5, 66);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(351, 145);
            this.groupControl5.TabIndex = 4;
            this.groupControl5.Text = "Thông tin chi tiết";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(5, 21);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(105, 19);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Chưa rõ tên";
            this.lblTen.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 23);
            this.label12.TabIndex = 1;
            this.label12.Text = "Lần gia hạn cuối";
            // 
            // lblPT_SoNgayConLai
            // 
            this.lblPT_SoNgayConLai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPT_SoNgayConLai.AutoSize = true;
            this.lblPT_SoNgayConLai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPT_SoNgayConLai.ForeColor = System.Drawing.Color.Green;
            this.lblPT_SoNgayConLai.Location = new System.Drawing.Point(187, 114);
            this.lblPT_SoNgayConLai.Name = "lblPT_SoNgayConLai";
            this.lblPT_SoNgayConLai.Size = new System.Drawing.Size(82, 19);
            this.lblPT_SoNgayConLai.TabIndex = 3;
            this.lblPT_SoNgayConLai.Text = "Không rõ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(5, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 23);
            this.label16.TabIndex = 1;
            this.label16.Text = "Ngày hết hạn";
            // 
            // lblPT_NgayHetHan
            // 
            this.lblPT_NgayHetHan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPT_NgayHetHan.AutoSize = true;
            this.lblPT_NgayHetHan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPT_NgayHetHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPT_NgayHetHan.Location = new System.Drawing.Point(186, 81);
            this.lblPT_NgayHetHan.Name = "lblPT_NgayHetHan";
            this.lblPT_NgayHetHan.Size = new System.Drawing.Size(82, 19);
            this.lblPT_NgayHetHan.TabIndex = 3;
            this.lblPT_NgayHetHan.Text = "Không rõ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(5, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(138, 23);
            this.label18.TabIndex = 1;
            this.label18.Text = "Số ngày còn lại";
            // 
            // lblPT_GiaHanCuoi
            // 
            this.lblPT_GiaHanCuoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPT_GiaHanCuoi.AutoSize = true;
            this.lblPT_GiaHanCuoi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPT_GiaHanCuoi.ForeColor = System.Drawing.Color.Purple;
            this.lblPT_GiaHanCuoi.Location = new System.Drawing.Point(186, 46);
            this.lblPT_GiaHanCuoi.Name = "lblPT_GiaHanCuoi";
            this.lblPT_GiaHanCuoi.Size = new System.Drawing.Size(82, 19);
            this.lblPT_GiaHanCuoi.TabIndex = 2;
            this.lblPT_GiaHanCuoi.Text = "Không rõ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblKetQuaGYM);
            this.groupControl1.Controls.Add(this.groupControl5);
            this.groupControl1.Controls.Add(this.btnGiaHanGYM);
            this.groupControl1.Location = new System.Drawing.Point(13, 107);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(361, 273);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "GYM";
            // 
            // lblKetQuaGYM
            // 
            this.lblKetQuaGYM.AutoSize = true;
            this.lblKetQuaGYM.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQuaGYM.Location = new System.Drawing.Point(2, 21);
            this.lblKetQuaGYM.Name = "lblKetQuaGYM";
            this.lblKetQuaGYM.Size = new System.Drawing.Size(229, 42);
            this.lblKetQuaGYM.TabIndex = 0;
            this.lblKetQuaGYM.Text = "Thẻ còn hạn";
            // 
            // btnGiaHanGYM
            // 
            this.btnGiaHanGYM.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGiaHanGYM.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnGiaHanGYM.Appearance.Image = global::GymFitnessOlympic.Properties.Resources.birthday;
            this.btnGiaHanGYM.Appearance.Options.UseImage = true;
            this.btnGiaHanGYM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGiaHanGYM.Image = global::GymFitnessOlympic.Properties.Resources.giahan;
            this.btnGiaHanGYM.Location = new System.Drawing.Point(255, 217);
            this.btnGiaHanGYM.Name = "btnGiaHanGYM";
            this.btnGiaHanGYM.Size = new System.Drawing.Size(101, 44);
            this.btnGiaHanGYM.TabIndex = 5;
            this.btnGiaHanGYM.Text = "Gia hạn";
            this.btnGiaHanGYM.Click += new System.EventHandler(this.btnGiaHanGYM_Click);
            // 
            // lblChucNang
            // 
            this.lblChucNang.AutoSize = true;
            this.lblChucNang.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucNang.Location = new System.Drawing.Point(3, 0);
            this.lblChucNang.Name = "lblChucNang";
            this.lblChucNang.Size = new System.Drawing.Size(324, 58);
            this.lblChucNang.TabIndex = 2;
            this.lblChucNang.Text = "Check in thẻ";
            this.lblChucNang.Visible = false;
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(570, 61);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(77, 37);
            this.btnCheckin.TabIndex = 10;
            this.btnCheckin.Text = "Checkin";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click_1);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblKetQuaSauna);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.btnGiaHanSauna);
            this.groupControl2.Location = new System.Drawing.Point(379, 107);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(361, 273);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Sauna";
            // 
            // lblKetQuaSauna
            // 
            this.lblKetQuaSauna.AutoSize = true;
            this.lblKetQuaSauna.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQuaSauna.Location = new System.Drawing.Point(2, 21);
            this.lblKetQuaSauna.Name = "lblKetQuaSauna";
            this.lblKetQuaSauna.Size = new System.Drawing.Size(229, 42);
            this.lblKetQuaSauna.TabIndex = 0;
            this.lblKetQuaSauna.Text = "Thẻ còn hạn";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.lblSauSoNgayConLai);
            this.groupControl3.Controls.Add(this.label5);
            this.groupControl3.Controls.Add(this.lblSauNgayHetHan);
            this.groupControl3.Controls.Add(this.label7);
            this.groupControl3.Controls.Add(this.lblSauGiaHanCuoi);
            this.groupControl3.Location = new System.Drawing.Point(5, 66);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(351, 145);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Thông tin chi tiết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lần gia hạn cuối";
            // 
            // lblSauSoNgayConLai
            // 
            this.lblSauSoNgayConLai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSauSoNgayConLai.AutoSize = true;
            this.lblSauSoNgayConLai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSauSoNgayConLai.ForeColor = System.Drawing.Color.Green;
            this.lblSauSoNgayConLai.Location = new System.Drawing.Point(187, 114);
            this.lblSauSoNgayConLai.Name = "lblSauSoNgayConLai";
            this.lblSauSoNgayConLai.Size = new System.Drawing.Size(82, 19);
            this.lblSauSoNgayConLai.TabIndex = 3;
            this.lblSauSoNgayConLai.Text = "Không rõ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày hết hạn";
            // 
            // lblSauNgayHetHan
            // 
            this.lblSauNgayHetHan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSauNgayHetHan.AutoSize = true;
            this.lblSauNgayHetHan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSauNgayHetHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSauNgayHetHan.Location = new System.Drawing.Point(186, 81);
            this.lblSauNgayHetHan.Name = "lblSauNgayHetHan";
            this.lblSauNgayHetHan.Size = new System.Drawing.Size(82, 19);
            this.lblSauNgayHetHan.TabIndex = 3;
            this.lblSauNgayHetHan.Text = "Không rõ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số ngày còn lại";
            // 
            // lblSauGiaHanCuoi
            // 
            this.lblSauGiaHanCuoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSauGiaHanCuoi.AutoSize = true;
            this.lblSauGiaHanCuoi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSauGiaHanCuoi.ForeColor = System.Drawing.Color.Purple;
            this.lblSauGiaHanCuoi.Location = new System.Drawing.Point(186, 46);
            this.lblSauGiaHanCuoi.Name = "lblSauGiaHanCuoi";
            this.lblSauGiaHanCuoi.Size = new System.Drawing.Size(82, 19);
            this.lblSauGiaHanCuoi.TabIndex = 2;
            this.lblSauGiaHanCuoi.Text = "Không rõ";
            // 
            // btnGiaHanSauna
            // 
            this.btnGiaHanSauna.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGiaHanSauna.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnGiaHanSauna.Appearance.Image = global::GymFitnessOlympic.Properties.Resources.birthday;
            this.btnGiaHanSauna.Appearance.Options.UseImage = true;
            this.btnGiaHanSauna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGiaHanSauna.Image = global::GymFitnessOlympic.Properties.Resources.giahan;
            this.btnGiaHanSauna.Location = new System.Drawing.Point(255, 217);
            this.btnGiaHanSauna.Name = "btnGiaHanSauna";
            this.btnGiaHanSauna.Size = new System.Drawing.Size(101, 44);
            this.btnGiaHanSauna.TabIndex = 5;
            this.btnGiaHanSauna.Text = "Gia hạn";
            this.btnGiaHanSauna.Click += new System.EventHandler(this.btnGiaHanSauna_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(212)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(13, 438);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(212)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(731, 133);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHoiVien";
            this.Column1.HeaderText = "Mã hội viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenHoiVien";
            this.Column2.HeaderText = "Tên hội viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DaInGYM";
            this.Column3.HeaderText = "Đã in phiếu GYM";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DaInSauna";
            this.Column4.HeaderText = "Đã in phiếu Sauna";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ThoiGian";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column6.HeaderText = "Thời gian đăng nhập";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnInGYM
            // 
            this.btnInGYM.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnInGYM.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnInGYM.Appearance.Image = global::GymFitnessOlympic.Properties.Resources.birthday;
            this.btnInGYM.Appearance.Options.UseImage = true;
            this.btnInGYM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInGYM.Image = global::GymFitnessOlympic.Properties.Resources.printerBlue;
            this.btnInGYM.Location = new System.Drawing.Point(480, 388);
            this.btnInGYM.Name = "btnInGYM";
            this.btnInGYM.Size = new System.Drawing.Size(129, 44);
            this.btnInGYM.TabIndex = 5;
            this.btnInGYM.Text = "In phiếu GYM";
            this.btnInGYM.Click += new System.EventHandler(this.btnInGYM_Click);
            // 
            // btnInSauna
            // 
            this.btnInSauna.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnInSauna.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnInSauna.Appearance.Image = global::GymFitnessOlympic.Properties.Resources.birthday;
            this.btnInSauna.Appearance.Options.UseImage = true;
            this.btnInSauna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInSauna.Image = global::GymFitnessOlympic.Properties.Resources.printer;
            this.btnInSauna.Location = new System.Drawing.Point(615, 388);
            this.btnInSauna.Name = "btnInSauna";
            this.btnInSauna.Size = new System.Drawing.Size(129, 44);
            this.btnInSauna.TabIndex = 5;
            this.btnInSauna.Text = "In phiếu Sauna";
            this.btnInSauna.Click += new System.EventHandler(this.btnInSauna_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(15, 398);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(281, 37);
            this.lblThongBao.TabIndex = 12;
            this.lblThongBao.Text = "Thẻ không hợp lệ";
            // 
            // FrmCheckinHoiVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.btnInSauna);
            this.Controls.Add(this.btnInGYM);
            this.Controls.Add(this.lblChucNang);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtMa);
            this.Name = "FrmCheckinHoiVien";
            this.Size = new System.Drawing.Size(758, 583);
            this.Load += new System.EventHandler(this.FrmCheckinHoiVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPT_SoNgayConLai;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblPT_NgayHetHan;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblPT_GiaHanCuoi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lblKetQuaGYM;
        private DevExpress.XtraEditors.SimpleButton btnGiaHanGYM;
        private System.Windows.Forms.Label lblChucNang;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Button btnCheckin;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label lblKetQuaSauna;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSauSoNgayConLai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSauNgayHetHan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSauGiaHanCuoi;
        private DevExpress.XtraEditors.SimpleButton btnGiaHanSauna;
        private DevExpress.XtraEditors.SimpleButton btnInGYM;
        private DevExpress.XtraEditors.SimpleButton btnInSauna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private CEMS.Controls.Commons.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblThongBao;

    }
}