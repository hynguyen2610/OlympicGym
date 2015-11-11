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
            this.label1 = new System.Windows.Forms.Label();
            this.rdChiSauna = new System.Windows.Forms.RadioButton();
            this.rdChiGYM = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(24, 185);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(750, 152);
            this.dataGridView1.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "ThoiGian";
            this.Column1.HeaderText = "Ngày giờ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "SoTien";
            this.Column2.HeaderText = "Số tiền";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "LoaiVe";
            this.Column5.HeaderText = "Loại vé";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(17, 18);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(317, 42);
            this.lblKetQua.TabIndex = 14;
            this.lblKetQua.Text = "Đăng ký khách lẻ";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(84, 154);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(16, 16);
            this.lblTongTien.TabIndex = 15;
            this.lblTongTien.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tổng tiền";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rdHisCaHai
            // 
            this.rdHisCaHai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdHisCaHai.AutoSize = true;
            this.rdHisCaHai.Location = new System.Drawing.Point(161, 6);
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
            this.rdHisSauna.Location = new System.Drawing.Point(81, 6);
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
            this.rdHisGym.Location = new System.Drawing.Point(8, 6);
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
            this.panel1.Location = new System.Drawing.Point(556, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 35);
            this.panel1.TabIndex = 20;
            // 
            // btnNhapIn
            // 
            this.btnNhapIn.Image = global::GymFitnessOlympic.Properties.Resources.printerBlue;
            this.btnNhapIn.Location = new System.Drawing.Point(406, 94);
            this.btnNhapIn.Name = "btnNhapIn";
            this.btnNhapIn.Size = new System.Drawing.Size(119, 38);
            this.btnNhapIn.TabIndex = 2;
            this.btnNhapIn.Text = "Nhập và in";
            this.btnNhapIn.Click += new System.EventHandler(this.btnNhapIn_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Image = global::GymFitnessOlympic.Properties.Resources.exit;
            this.btnNhap.Location = new System.Drawing.Point(281, 94);
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
            // FrmKhachLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rdChiSauna);
            this.Controls.Add(this.rdChiGYM);
            this.Controls.Add(this.btnNhapIn);
            this.Controls.Add(this.btnNhap);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rdChiSauna;
        private System.Windows.Forms.RadioButton rdChiGYM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
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
    }
}