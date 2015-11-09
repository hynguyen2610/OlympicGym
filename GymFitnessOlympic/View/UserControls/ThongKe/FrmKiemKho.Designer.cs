﻿namespace GymFitnessOlympic.View.ActForm
{
    partial class FrmKiemKho
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhapVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BanRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.rdTheoThang = new System.Windows.Forms.RadioButton();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbTheoThangThang = new System.Windows.Forms.ComboBox();
            this.rdTheoKhoangNgay = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTheoThangNam = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbPhong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.NhapVao,
            this.Column2,
            this.BanRa,
            this.Column3,
            this.Ton});
            this.dataGridView1.Location = new System.Drawing.Point(20, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(914, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "SanPham";
            this.Column1.HeaderText = "Tên hàng";
            this.Column1.Name = "Column1";
            // 
            // NhapVao
            // 
            this.NhapVao.DataPropertyName = "SoNhap";
            this.NhapVao.HeaderText = "Số lượng nhập vào";
            this.NhapVao.Name = "NhapVao";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TienNhap";
            this.Column2.HeaderText = "Tiền nhập vào";
            this.Column2.Name = "Column2";
            // 
            // BanRa
            // 
            this.BanRa.DataPropertyName = "SoBan";
            this.BanRa.HeaderText = "Số lượng bán ra";
            this.BanRa.Name = "BanRa";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TienBan";
            this.Column3.HeaderText = "Tiền bán ra";
            this.Column3.Name = "Column3";
            // 
            // Ton
            // 
            this.Ton.DataPropertyName = "Ton";
            this.Ton.HeaderText = "Tồn hiện tại";
            this.Ton.Name = "Ton";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.rdTheoThang);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbTheoThangThang);
            this.groupBox1.Controls.Add(this.rdTheoKhoangNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbTheoThangNam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 110);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chế độ lọc";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(532, 74);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 21);
            this.dtpTo.TabIndex = 3;
            // 
            // rdTheoThang
            // 
            this.rdTheoThang.AutoSize = true;
            this.rdTheoThang.Checked = true;
            this.rdTheoThang.Location = new System.Drawing.Point(163, 18);
            this.rdTheoThang.Name = "rdTheoThang";
            this.rdTheoThang.Size = new System.Drawing.Size(80, 17);
            this.rdTheoThang.TabIndex = 0;
            this.rdTheoThang.TabStop = true;
            this.rdTheoThang.Text = "Theo tháng";
            this.rdTheoThang.UseVisualStyleBackColor = true;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(532, 48);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 21);
            this.dtpFrom.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Đến ngày";
            // 
            // cbbTheoThangThang
            // 
            this.cbbTheoThangThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTheoThangThang.FormattingEnabled = true;
            this.cbbTheoThangThang.Items.AddRange(new object[] {
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
            this.cbbTheoThangThang.Location = new System.Drawing.Point(213, 54);
            this.cbbTheoThangThang.Name = "cbbTheoThangThang";
            this.cbbTheoThangThang.Size = new System.Drawing.Size(123, 21);
            this.cbbTheoThangThang.TabIndex = 1;
            // 
            // rdTheoKhoangNgay
            // 
            this.rdTheoKhoangNgay.AutoSize = true;
            this.rdTheoKhoangNgay.Location = new System.Drawing.Point(462, 16);
            this.rdTheoKhoangNgay.Name = "rdTheoKhoangNgay";
            this.rdTheoKhoangNgay.Size = new System.Drawing.Size(114, 17);
            this.rdTheoKhoangNgay.TabIndex = 0;
            this.rdTheoKhoangNgay.Text = "Theo khoảng ngày";
            this.rdTheoKhoangNgay.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm";
            // 
            // cbbTheoThangNam
            // 
            this.cbbTheoThangNam.FormattingEnabled = true;
            this.cbbTheoThangNam.Location = new System.Drawing.Point(213, 81);
            this.cbbTheoThangNam.Name = "cbbTheoThangNam";
            this.cbbTheoThangNam.Size = new System.Drawing.Size(123, 21);
            this.cbbTheoThangNam.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Từ ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tháng";
            // 
            // cbbPhong
            // 
            this.cbbPhong.Location = new System.Drawing.Point(81, 146);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbPhong.Size = new System.Drawing.Size(182, 20);
            this.cbbPhong.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Phòng";
            // 
            // btnTim
            // 
            this.btnTim.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTim.Image = global::GymFitnessOlympic.Properties.Resources.statistics3;
            this.btnTim.Location = new System.Drawing.Point(802, 33);
            this.btnTim.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(105, 94);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Lọc";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // FrmKiemKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbPhong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmKiemKho";
            this.Size = new System.Drawing.Size(947, 544);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhapVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BanRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ton;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.RadioButton rdTheoThang;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbTheoThangThang;
        private System.Windows.Forms.RadioButton rdTheoKhoangNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTheoThangNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cbbPhong;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}
