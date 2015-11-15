namespace GymFitnessOlympic.View.Dialog
{
    partial class FrmGiamGiaEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenGiamGia = new System.Windows.Forms.TextBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên giảm giá";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTenGiamGia
            // 
            this.txtTenGiamGia.Location = new System.Drawing.Point(101, 12);
            this.txtTenGiamGia.Name = "txtTenGiamGia";
            this.txtTenGiamGia.Size = new System.Drawing.Size(298, 21);
            this.txtTenGiamGia.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(208, 103);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(86, 31);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Hủy";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(101, 40);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(298, 21);
            this.dtpNgayBatDau.TabIndex = 4;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(101, 67);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(298, 21);
            this.dtpNgayKetThuc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày bắt đầu";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày kết thúc";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = global::GymFitnessOlympic.Properties.Resources._1447576907_ok;
            this.btnCapNhat.Location = new System.Drawing.Point(101, 103);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(101, 31);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // FrmGiamGiaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 146);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtTenGiamGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FrmGiamGiaEdit";
            this.Text = "Chỉnh sửa chi tiết hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenGiamGia;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}