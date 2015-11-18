namespace GymFitnessOlympic.View.UserControls.ThongKe
{
    partial class FrmDangKyNhanh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMaThe = new DevExpress.XtraEditors.TextEdit();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dgrDangKy = new CEMS.Controls.Commons.DataGridViewEx();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbGoiGym = new System.Windows.Forms.ComboBox();
            this.cbbGoiSauna = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSoTienThanhToan = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblThanhCong = new System.Windows.Forms.Label();
            this.btnInGym = new DevExpress.XtraEditors.SimpleButton();
            this.btnInSauna = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbGiamGiaGYM = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbGiamGiaSauna = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaThe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(11, 10);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(280, 42);
            this.lblKetQua.TabIndex = 1;
            this.lblKetQua.Text = "Đăng ký nhanh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã thẻ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(118, 90);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(349, 20);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // txtMaThe
            // 
            this.txtMaThe.Location = new System.Drawing.Point(118, 64);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(349, 20);
            this.txtMaThe.TabIndex = 0;
            this.txtMaThe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaThe_KeyPress);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // dgrDangKy
            // 
            this.dgrDangKy.AllowUserToAddRows = false;
            this.dgrDangKy.AllowUserToDeleteRows = false;
            this.dgrDangKy.AllowUserToOrderColumns = true;
            this.dgrDangKy.AllowUserToResizeColumns = false;
            this.dgrDangKy.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.dgrDangKy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrDangKy.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgrDangKy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrDangKy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(212)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrDangKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrDangKy.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgrDangKy.EnableHeadersVisualStyles = false;
            this.dgrDangKy.ExportFilePath = null;
            this.dgrDangKy.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgrDangKy.Location = new System.Drawing.Point(17, 291);
            this.dgrDangKy.Name = "dgrDangKy";
            this.dgrDangKy.ReadOnly = true;
            this.dgrDangKy.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(212)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrDangKy.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgrDangKy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgrDangKy.Size = new System.Drawing.Size(757, 60);
            this.dgrDangKy.TabIndex = 9;
            this.dgrDangKy.UseAsListBox = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh sách đăng  ký nhanh trong ngày";
            // 
            // cbbGoiGym
            // 
            this.cbbGoiGym.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGoiGym.FormattingEnabled = true;
            this.cbbGoiGym.Location = new System.Drawing.Point(118, 117);
            this.cbbGoiGym.Name = "cbbGoiGym";
            this.cbbGoiGym.Size = new System.Drawing.Size(121, 21);
            this.cbbGoiGym.TabIndex = 2;
            this.cbbGoiGym.SelectedIndexChanged += new System.EventHandler(this.cbbGoiGym_SelectedIndexChanged);
            // 
            // cbbGoiSauna
            // 
            this.cbbGoiSauna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGoiSauna.FormattingEnabled = true;
            this.cbbGoiSauna.Location = new System.Drawing.Point(346, 117);
            this.cbbGoiSauna.Name = "cbbGoiSauna";
            this.cbbGoiSauna.Size = new System.Drawing.Size(121, 21);
            this.cbbGoiSauna.TabIndex = 3;
            this.cbbGoiSauna.SelectedIndexChanged += new System.EventHandler(this.cbbGoiSauna_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chọn gói GYM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Chọn gói Sauna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số tiền cần thanh toán:";
            // 
            // lblSoTienThanhToan
            // 
            this.lblSoTienThanhToan.AutoSize = true;
            this.lblSoTienThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTienThanhToan.Location = new System.Drawing.Point(138, 195);
            this.lblSoTienThanhToan.Name = "lblSoTienThanhToan";
            this.lblSoTienThanhToan.Size = new System.Drawing.Size(16, 16);
            this.lblSoTienThanhToan.TabIndex = 2;
            this.lblSoTienThanhToan.Text = "0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblThanhCong
            // 
            this.lblThanhCong.AutoSize = true;
            this.lblThanhCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhCong.Location = new System.Drawing.Point(447, 190);
            this.lblThanhCong.Name = "lblThanhCong";
            this.lblThanhCong.Size = new System.Drawing.Size(169, 20);
            this.lblThanhCong.TabIndex = 5;
            this.lblThanhCong.Text = "Đăng ký thành công";
            this.lblThanhCong.Visible = false;
            // 
            // btnInGym
            // 
            this.btnInGym.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInGym.Image = global::GymFitnessOlympic.Properties.Resources.printerBlue;
            this.btnInGym.Location = new System.Drawing.Point(426, 251);
            this.btnInGym.Name = "btnInGym";
            this.btnInGym.Size = new System.Drawing.Size(112, 31);
            this.btnInGym.TabIndex = 6;
            this.btnInGym.Text = "In vé GYM";
            this.btnInGym.Click += new System.EventHandler(this.btnInGym_Click);
            // 
            // btnInSauna
            // 
            this.btnInSauna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInSauna.Image = global::GymFitnessOlympic.Properties.Resources.printer;
            this.btnInSauna.Location = new System.Drawing.Point(544, 251);
            this.btnInSauna.Name = "btnInSauna";
            this.btnInSauna.Size = new System.Drawing.Size(112, 31);
            this.btnInSauna.TabIndex = 7;
            this.btnInSauna.Text = "In vé Sauna";
            this.btnInSauna.Click += new System.EventHandler(this.btnInSauna_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Image = global::GymFitnessOlympic.Properties.Resources.Edit;
            this.simpleButton1.Location = new System.Drawing.Point(662, 251);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(112, 31);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Chỉnh sửa";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Image = global::GymFitnessOlympic.Properties.Resources.flash;
            this.btnDangKy.Location = new System.Drawing.Point(346, 177);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(95, 41);
            this.btnDangKy.TabIndex = 4;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Giảm giá GYM";
            // 
            // cbbGiamGiaGYM
            // 
            this.cbbGiamGiaGYM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGiamGiaGYM.FormattingEnabled = true;
            this.cbbGiamGiaGYM.Location = new System.Drawing.Point(118, 150);
            this.cbbGiamGiaGYM.Name = "cbbGiamGiaGYM";
            this.cbbGiamGiaGYM.Size = new System.Drawing.Size(121, 21);
            this.cbbGiamGiaGYM.TabIndex = 3;
            this.cbbGiamGiaGYM.SelectedIndexChanged += new System.EventHandler(this.cbbGoiSauna_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Giảm giá Sauna";
            // 
            // cbbGiamGiaSauna
            // 
            this.cbbGiamGiaSauna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGiamGiaSauna.FormattingEnabled = true;
            this.cbbGiamGiaSauna.Location = new System.Drawing.Point(346, 150);
            this.cbbGiamGiaSauna.Name = "cbbGiamGiaSauna";
            this.cbbGiamGiaSauna.Size = new System.Drawing.Size(121, 21);
            this.cbbGiamGiaSauna.TabIndex = 3;
            this.cbbGiamGiaSauna.SelectedIndexChanged += new System.EventHandler(this.cbbGoiSauna_SelectedIndexChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaThe";
            this.Column1.HeaderText = "Mã thẻ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenHoiVien";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayGioDangKy";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Ngày đăng ký";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayHetHanGYM";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "GYM";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayHetHanSauna";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "Sauna";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DaCapNhatString";
            this.Column7.HeaderText = "Đã cập nhật hồ sơ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // FrmDangKyNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbGiamGiaSauna);
            this.Controls.Add(this.cbbGiamGiaGYM);
            this.Controls.Add(this.cbbGoiSauna);
            this.Controls.Add(this.cbbGoiGym);
            this.Controls.Add(this.dgrDangKy);
            this.Controls.Add(this.btnInGym);
            this.Controls.Add(this.btnInSauna);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtMaThe);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblThanhCong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSoTienThanhToan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKetQua);
            this.Name = "FrmDangKyNhanh";
            this.Size = new System.Drawing.Size(796, 361);
            this.Load += new System.EventHandler(this.FrmDangKyNhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaThe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtMaThe;
        private DevExpress.XtraEditors.SimpleButton btnDangKy;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private CEMS.Controls.Commons.DataGridViewEx dgrDangKy;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox cbbGoiSauna;
        private System.Windows.Forms.ComboBox cbbGoiGym;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoTienThanhToan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblThanhCong;
        private DevExpress.XtraEditors.SimpleButton btnInGym;
        private DevExpress.XtraEditors.SimpleButton btnInSauna;
        private System.Windows.Forms.ComboBox cbbGiamGiaSauna;
        private System.Windows.Forms.ComboBox cbbGiamGiaGYM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
