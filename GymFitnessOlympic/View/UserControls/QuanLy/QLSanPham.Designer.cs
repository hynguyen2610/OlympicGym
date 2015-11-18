namespace GymFitnessOlympic.View.UserControls.QuanLy
{
    partial class QLSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLSanPham));
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTim = new DevExpress.XtraEditors.TextEdit();
            this.dgrHoiVien = new CEMS.Controls.Commons.DataGridViewEx();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblChucNang = new System.Windows.Forms.Label();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSeach = new DevExpress.XtraEditors.SimpleButton();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtTim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrHoiVien)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(297, -53);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(107, 16);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Danh sách hội viên";
            // 
            // txtTim
            // 
            this.txtTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTim.Location = new System.Drawing.Point(677, -58);
            this.txtTim.Name = "txtTim";
            this.txtTim.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Properties.Appearance.Options.UseFont = true;
            this.txtTim.Size = new System.Drawing.Size(190, 24);
            this.txtTim.TabIndex = 7;
            // 
            // dgrHoiVien
            // 
            this.dgrHoiVien.AllowUserToAddRows = false;
            this.dgrHoiVien.AllowUserToDeleteRows = false;
            this.dgrHoiVien.AllowUserToOrderColumns = true;
            this.dgrHoiVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.dgrHoiVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrHoiVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrHoiVien.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgrHoiVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrHoiVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrHoiVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrHoiVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrHoiVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrHoiVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgrHoiVien.EnableHeadersVisualStyles = false;
            this.dgrHoiVien.ExportFilePath = null;
            this.dgrHoiVien.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgrHoiVien.Location = new System.Drawing.Point(12, 130);
            this.dgrHoiVien.MultiSelect = false;
            this.dgrHoiVien.Name = "dgrHoiVien";
            this.dgrHoiVien.ReadOnly = true;
            this.dgrHoiVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrHoiVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgrHoiVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgrHoiVien.Size = new System.Drawing.Size(805, 292);
            this.dgrHoiVien.TabIndex = 9;
            this.dgrHoiVien.UseAsListBox = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(12, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 16);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Phòng";
            // 
            // lblChucNang
            // 
            this.lblChucNang.AutoSize = true;
            this.lblChucNang.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucNang.Location = new System.Drawing.Point(2, 0);
            this.lblChucNang.Name = "lblChucNang";
            this.lblChucNang.Size = new System.Drawing.Size(458, 58);
            this.lblChucNang.TabIndex = 15;
            this.lblChucNang.Text = "Quản lý sản phẩm";
            // 
            // cbbPhong
            // 
            this.cbbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(53, 100);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(121, 21);
            this.cbbPhong.TabIndex = 16;
            this.cbbPhong.SelectedIndexChanged += new System.EventHandler(this.cbbPhong_SelectedIndexChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Image = global::GymFitnessOlympic.Properties.Resources.delete;
            this.btnXoa.Location = new System.Drawing.Point(728, 99);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 25);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Image = global::GymFitnessOlympic.Properties.Resources.Edit;
            this.btnSua.Location = new System.Drawing.Point(633, 99);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 25);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Image = global::GymFitnessOlympic.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(538, 99);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 25);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSeach
            // 
            this.btnSeach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeach.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeach.Appearance.Options.UseFont = true;
            this.btnSeach.Image = ((System.Drawing.Image)(resources.GetObject("btnSeach.Image")));
            this.btnSeach.Location = new System.Drawing.Point(876, -58);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(93, 24);
            this.btnSeach.TabIndex = 6;
            this.btnSeach.Text = "Tìm kiếm";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaVachSanPham";
            this.Column4.HeaderText = "Mã sản phẩm";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenSanPham";
            this.Column1.FillWeight = 284.7716F;
            this.Column1.HeaderText = "Tên sản phẩm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Gia";
            this.Column2.FillWeight = 10.06491F;
            this.Column2.HeaderText = "Giá";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 5.16351F;
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // QLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbPhong);
            this.Controls.Add(this.lblChucNang);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.dgrHoiVien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSeach);
            this.Name = "QLSanPham";
            this.Size = new System.Drawing.Size(829, 436);
            ((System.ComponentModel.ISupportInitialize)(this.txtTim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrHoiVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtTim;
        private CEMS.Controls.Commons.DataGridViewEx dgrHoiVien;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSeach;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label lblChucNang;
        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;

    }
}