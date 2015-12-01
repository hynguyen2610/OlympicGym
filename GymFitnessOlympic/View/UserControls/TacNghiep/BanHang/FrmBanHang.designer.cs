namespace TanHongPhat
{
    partial class FrmBanHang
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
            System.Windows.Forms.ColumnHeader columnHeader5;
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spnSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaVach = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.lbSanPham = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lvHangNhap = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblThongBao = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblTongTien = new DevExpress.XtraEditors.LabelControl();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnChiTietXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuet = new DevExpress.XtraEditors.SimpleButton();
            this.btnChiTietSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.spnSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 4;
            columnHeader5.Text = "Mã hàng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 197;
            // 
            // spnSoLuong
            // 
            this.spnSoLuong.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnSoLuong.Location = new System.Drawing.Point(430, 272);
            this.spnSoLuong.Name = "spnSoLuong";
            this.spnSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnSoLuong.Size = new System.Drawing.Size(173, 20);
            this.spnSoLuong.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(380, 239);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 13);
            this.labelControl6.TabIndex = 55;
            this.labelControl6.Text = "Tên hàng";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(430, 236);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.ReadOnly = true;
            this.txtTenHang.Size = new System.Drawing.Size(173, 20);
            this.txtTenHang.TabIndex = 46;
            // 
            // txtMaVach
            // 
            this.txtMaVach.Enabled = false;
            this.txtMaVach.Location = new System.Drawing.Point(430, 197);
            this.txtMaVach.Name = "txtMaVach";
            this.txtMaVach.ReadOnly = true;
            this.txtMaVach.Size = new System.Drawing.Size(173, 20);
            this.txtMaVach.TabIndex = 45;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(380, 275);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 53;
            this.labelControl3.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 79;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dtpThoiGian);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Location = new System.Drawing.Point(380, 93);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(222, 64);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin hóa đơn";
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CustomFormat = "dd/MM/yyyy";
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpThoiGian.Location = new System.Drawing.Point(63, 28);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(153, 20);
            this.dtpThoiGian.TabIndex = 0;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(5, 31);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(52, 13);
            this.labelControl10.TabIndex = 4;
            this.labelControl10.Text = "Ngày nhập";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(80, 94);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtTimKiem.Properties.Appearance.Options.UseFont = true;
            this.txtTimKiem.Properties.Appearance.Options.UseForeColor = true;
            this.txtTimKiem.Size = new System.Drawing.Size(275, 24);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.ToolTip = "Gõ để tìm kiếm, kết quả tức thì";
            this.txtTimKiem.EditValueChanged += new System.EventHandler(this.txtTenHangTim_EditValueChanged);
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenHangTim_KeyPress);
            // 
            // lbSanPham
            // 
            this.lbSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSanPham.DisplayMember = "TenHang";
            this.lbSanPham.Location = new System.Drawing.Point(29, 200);
            this.lbSanPham.Name = "lbSanPham";
            this.lbSanPham.Size = new System.Drawing.Size(326, 200);
            this.lbSanPham.TabIndex = 3;
            this.lbSanPham.SelectedIndexChanged += new System.EventHandler(this.lbHang_SelectedIndexChanged);
            this.lbSanPham.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lbSanPham_MeasureItem);
            this.lbSanPham.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSanPham_MouseDoubleClick);
            this.lbSanPham.Validating += new System.ComponentModel.CancelEventHandler(this.lbSanPham_Validating);
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(29, 178);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(99, 13);
            this.labelControl12.TabIndex = 51;
            this.labelControl12.Text = "Danh sách sản phẩm";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 52;
            this.labelControl2.Text = "Mã hàng";
            // 
            // lvHangNhap
            // 
            this.lvHangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvHangNhap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvHangNhap.FullRowSelect = true;
            this.lvHangNhap.Location = new System.Drawing.Point(638, 91);
            this.lvHangNhap.Name = "lvHangNhap";
            this.lvHangNhap.Size = new System.Drawing.Size(402, 168);
            this.lvHangNhap.TabIndex = 8;
            this.lvHangNhap.UseCompatibleStateImageBehavior = false;
            this.lvHangNhap.View = System.Windows.Forms.View.Details;
            this.lvHangNhap.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvHangNhap_DrawItem);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "Tên hàng";
            this.columnHeader1.Width = 132;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 87;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(638, 276);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(54, 16);
            this.labelControl7.TabIndex = 55;
            this.labelControl7.Text = "Tổng tiền";
            // 
            // lblThongBao
            // 
            this.lblThongBao.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblThongBao.Location = new System.Drawing.Point(116, 141);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(134, 16);
            this.lblThongBao.TabIndex = 51;
            this.lblThongBao.Text = "Không có mặt hàng này";
            this.lblThongBao.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(380, 312);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 55;
            this.labelControl1.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(430, 309);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(173, 20);
            this.txtDonGia.TabIndex = 5;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongTien.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(698, 265);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(17, 33);
            this.lblTongTien.TabIndex = 71;
            this.lblTongTien.Text = "0";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = global::GymFitnessOlympic.Properties.Resources._1447576907_ok;
            this.btnSave.Location = new System.Drawing.Point(629, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 52);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Tạo hóa đơn";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnChiTietXoa
            // 
            this.btnChiTietXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiTietXoa.Image = global::GymFitnessOlympic.Properties.Resources.delete;
            this.btnChiTietXoa.Location = new System.Drawing.Point(940, 50);
            this.btnChiTietXoa.Name = "btnChiTietXoa";
            this.btnChiTietXoa.Size = new System.Drawing.Size(100, 24);
            this.btnChiTietXoa.TabIndex = 8;
            this.btnChiTietXoa.Text = "Xóa";
            this.btnChiTietXoa.Click += new System.EventHandler(this.btnChiTietXoa_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.Image = global::GymFitnessOlympic.Properties.Resources.update;
            this.btnReset.Location = new System.Drawing.Point(839, 347);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(190, 52);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Hủy hóa đơn hiện tại";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnQuet
            // 
            this.btnQuet.Image = global::GymFitnessOlympic.Properties.Resources.Find;
            this.btnQuet.Location = new System.Drawing.Point(260, 128);
            this.btnQuet.Name = "btnQuet";
            this.btnQuet.Size = new System.Drawing.Size(95, 41);
            this.btnQuet.TabIndex = 2;
            this.btnQuet.Text = "Quyét";
            this.btnQuet.Click += new System.EventHandler(this.btnQuet_Click);
            // 
            // btnChiTietSua
            // 
            this.btnChiTietSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiTietSua.Image = global::GymFitnessOlympic.Properties.Resources.Edit;
            this.btnChiTietSua.Location = new System.Drawing.Point(839, 50);
            this.btnChiTietSua.Name = "btnChiTietSua";
            this.btnChiTietSua.Size = new System.Drawing.Size(95, 24);
            this.btnChiTietSua.TabIndex = 7;
            this.btnChiTietSua.Text = "Sửa";
            this.btnChiTietSua.Click += new System.EventHandler(this.btnChiTietSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = global::GymFitnessOlympic.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(430, 347);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(172, 52);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.ToolTip = "Thêm mặt hàng vào danh sách nhập, một khi đã click, không\r\nthể thay đổi nhà cung " +
    "cấp được nữa, trừ khi click \"Làm lại từ đầu\"\r\nđể tạo phiếu nhập mới.";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(24, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(228, 58);
            this.lblTitle.TabIndex = 52;
            this.lblTitle.Text = "Bán hàng";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(380, 200);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 55;
            this.labelControl4.Text = "Mã vạch";
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChiTietXoa);
            this.Controls.Add(this.lbSanPham);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnQuet);
            this.Controls.Add(this.btnChiTietSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtMaVach);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.spnSoLuong);
            this.Controls.Add(this.lvHangNhap);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmBanHang";
            this.Size = new System.Drawing.Size(1053, 423);
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spnSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader4;
        public DevExpress.XtraEditors.SpinEdit spnSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.SimpleButton btnThem;
        public System.Windows.Forms.TextBox txtTenHang;
        public System.Windows.Forms.TextBox txtMaVach;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        public System.Windows.Forms.DateTimePicker dtpThoiGian;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraEditors.TextEdit txtTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnChiTietXoa;
        private DevExpress.XtraEditors.SimpleButton btnChiTietSua;
        public DevExpress.XtraEditors.ListBoxControl lbSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public System.Windows.Forms.ListView lvHangNhap;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnQuet;
        private DevExpress.XtraEditors.LabelControl lblThongBao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public System.Windows.Forms.TextBox txtDonGia;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        public DevExpress.XtraEditors.LabelControl lblTongTien;
        private System.Windows.Forms.ErrorProvider ep;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}