namespace GymFitnessOlympic.View.UserControls.TacNghiep.Checkin.HoiVien
{
    partial class FrmKhachLe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.rdChiSauna = new System.Windows.Forms.RadioButton();
            this.rdChiGYM = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbSoTien = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new CEMS.Controls.Commons.DataGridViewEx();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rdHisCaHai = new System.Windows.Forms.RadioButton();
            this.rdHisSauna = new System.Windows.Forms.RadioButton();
            this.rdHisGym = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNhapIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnNhap = new DevExpress.XtraEditors.SimpleButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbGiamGiaGYM = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTienPhaiTra = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền";
            // 
            // rdChiSauna
            // 
            this.rdChiSauna.AutoSize = true;
            this.rdChiSauna.Location = new System.Drawing.Point(169, 88);
            this.rdChiSauna.Name = "rdChiSauna";
            this.rdChiSauna.Size = new System.Drawing.Size(56, 17);
            this.rdChiSauna.TabIndex = 10;
            this.rdChiSauna.Text = "Sauna";
            this.rdChiSauna.UseVisualStyleBackColor = true;
            this.rdChiSauna.CheckedChanged += new System.EventHandler(this.rdChiSauna_CheckedChanged);
            // 
            // rdChiGYM
            // 
            this.rdChiGYM.AutoSize = true;
            this.rdChiGYM.Checked = true;
            this.rdChiGYM.Location = new System.Drawing.Point(96, 88);
            this.rdChiGYM.Name = "rdChiGYM";
            this.rdChiGYM.Size = new System.Drawing.Size(49, 17);
            this.rdChiGYM.TabIndex = 11;
            this.rdChiGYM.TabStop = true;
            this.rdChiGYM.Text = "GYM";
            this.rdChiGYM.UseVisualStyleBackColor = true;
            this.rdChiGYM.CheckedChanged += new System.EventHandler(this.rdChiGYM_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại vé";
            // 
            // cbbSoTien
            // 
            this.cbbSoTien.FormattingEnabled = true;
            this.cbbSoTien.Location = new System.Drawing.Point(96, 111);
            this.cbbSoTien.Name = "cbbSoTien";
            this.cbbSoTien.Size = new System.Drawing.Size(147, 21);
            this.cbbSoTien.TabIndex = 12;
            this.cbbSoTien.TextChanged += new System.EventHandler(this.cbbSoTien_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Column5,
            this.Column2,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ExportFilePath = null;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(24, 225);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(212)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(750, 112);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.UseAsListBox = false;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(17, 18);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(439, 58);
            this.lblKetQua.TabIndex = 14;
            this.lblKetQua.Text = "Đăng ký khách lẻ";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(441, 203);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(16, 16);
            this.lblTongTien.TabIndex = 15;
            this.lblTongTien.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tổng tiền trong ngày";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rdHisCaHai
            // 
            this.rdHisCaHai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdHisCaHai.AutoSize = true;
            this.rdHisCaHai.Location = new System.Drawing.Point(159, 12);
            this.rdHisCaHai.Name = "rdHisCaHai";
            this.rdHisCaHai.Size = new System.Drawing.Size(55, 17);
            this.rdHisCaHai.TabIndex = 17;
            this.rdHisCaHai.Text = "Cả hai";
            this.rdHisCaHai.UseVisualStyleBackColor = true;
            this.rdHisCaHai.CheckedChanged += new System.EventHandler(this.rdHisCaHai_CheckedChanged);
            // 
            // rdHisSauna
            // 
            this.rdHisSauna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdHisSauna.AutoSize = true;
            this.rdHisSauna.Location = new System.Drawing.Point(79, 12);
            this.rdHisSauna.Name = "rdHisSauna";
            this.rdHisSauna.Size = new System.Drawing.Size(74, 17);
            this.rdHisSauna.TabIndex = 18;
            this.rdHisSauna.Text = "Chỉ Sauna";
            this.rdHisSauna.UseVisualStyleBackColor = true;
            this.rdHisSauna.CheckedChanged += new System.EventHandler(this.rdHisSauna_CheckedChanged);
            // 
            // rdHisGym
            // 
            this.rdHisGym.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdHisGym.AutoSize = true;
            this.rdHisGym.Checked = true;
            this.rdHisGym.Location = new System.Drawing.Point(6, 12);
            this.rdHisGym.Name = "rdHisGym";
            this.rdHisGym.Size = new System.Drawing.Size(67, 17);
            this.rdHisGym.TabIndex = 19;
            this.rdHisGym.TabStop = true;
            this.rdHisGym.Text = "Chỉ GYM";
            this.rdHisGym.UseVisualStyleBackColor = true;
            this.rdHisGym.CheckedChanged += new System.EventHandler(this.rdHisGym_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rdHisSauna);
            this.panel1.Controls.Add(this.rdHisCaHai);
            this.panel1.Controls.Add(this.rdHisGym);
            this.panel1.Location = new System.Drawing.Point(555, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 35);
            this.panel1.TabIndex = 20;
            // 
            // btnNhapIn
            // 
            this.btnNhapIn.Image = global::GymFitnessOlympic.Properties.Resources.printerBlue;
            this.btnNhapIn.Location = new System.Drawing.Point(386, 111);
            this.btnNhapIn.Name = "btnNhapIn";
            this.btnNhapIn.Size = new System.Drawing.Size(119, 38);
            this.btnNhapIn.TabIndex = 2;
            this.btnNhapIn.Text = "Nhập và in";
            this.btnNhapIn.Click += new System.EventHandler(this.btnNhapIn_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Image = global::GymFitnessOlympic.Properties.Resources.exit;
            this.btnNhap.Location = new System.Drawing.Point(261, 111);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(119, 38);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 328);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(788, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giảm giá";
            // 
            // cbbGiamGiaGYM
            // 
            this.cbbGiamGiaGYM.DisplayMember = "TenGiamGia";
            this.cbbGiamGiaGYM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGiamGiaGYM.FormattingEnabled = true;
            this.cbbGiamGiaGYM.Location = new System.Drawing.Point(96, 138);
            this.cbbGiamGiaGYM.Name = "cbbGiamGiaGYM";
            this.cbbGiamGiaGYM.Size = new System.Drawing.Size(147, 21);
            this.cbbGiamGiaGYM.TabIndex = 12;
            this.cbbGiamGiaGYM.SelectedIndexChanged += new System.EventHandler(this.cbbGiamGia_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Danh sách khách lẻ trong ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số tiền phải trả";
            // 
            // lblTienPhaiTra
            // 
            this.lblTienPhaiTra.AutoSize = true;
            this.lblTienPhaiTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienPhaiTra.Location = new System.Drawing.Point(115, 168);
            this.lblTienPhaiTra.Name = "lblTienPhaiTra";
            this.lblTienPhaiTra.Size = new System.Drawing.Size(16, 16);
            this.lblTienPhaiTra.TabIndex = 15;
            this.lblTienPhaiTra.Text = "0";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "ThoiGian";
            this.Column1.HeaderText = "Ngày giờ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "LoaiVe";
            this.Column5.HeaderText = "Loại vé";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "SoTien";
            this.Column2.HeaderText = "Số tiền";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FrmKhachLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTienPhaiTra);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbbGiamGiaGYM);
            this.Controls.Add(this.cbbSoTien);
            this.Controls.Add(this.rdChiSauna);
            this.Controls.Add(this.rdChiGYM);
            this.Controls.Add(this.btnNhapIn);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmKhachLe";
            this.Size = new System.Drawing.Size(788, 350);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnNhap;
        private System.Windows.Forms.ComboBox cbbSoTien;
        private System.Windows.Forms.RadioButton rdChiSauna;
        private System.Windows.Forms.RadioButton rdChiGYM;
        private System.Windows.Forms.Label label2;
        private CEMS.Controls.Commons.DataGridViewEx dataGridView1;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton rdHisCaHai;
        private System.Windows.Forms.RadioButton rdHisSauna;
        private System.Windows.Forms.RadioButton rdHisGym;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnNhapIn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbGiamGiaGYM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTienPhaiTra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}