namespace GymFitnessOlympic.View.Dialog
{
    partial class FrmChonCa
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
            this.rdCaSang = new System.Windows.Forms.RadioButton();
            this.rdCaChieu = new System.Windows.Forms.RadioButton();
            this.rdCaToi = new System.Windows.Forms.RadioButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdCaSang
            // 
            this.rdCaSang.AutoSize = true;
            this.rdCaSang.Checked = true;
            this.rdCaSang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCaSang.Location = new System.Drawing.Point(24, 20);
            this.rdCaSang.Name = "rdCaSang";
            this.rdCaSang.Size = new System.Drawing.Size(76, 20);
            this.rdCaSang.TabIndex = 0;
            this.rdCaSang.TabStop = true;
            this.rdCaSang.Text = "Ca sáng";
            this.rdCaSang.UseVisualStyleBackColor = true;
            this.rdCaSang.CheckedChanged += new System.EventHandler(this.rdCaSang_CheckedChanged);
            // 
            // rdCaChieu
            // 
            this.rdCaChieu.AutoSize = true;
            this.rdCaChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCaChieu.Location = new System.Drawing.Point(24, 46);
            this.rdCaChieu.Name = "rdCaChieu";
            this.rdCaChieu.Size = new System.Drawing.Size(78, 20);
            this.rdCaChieu.TabIndex = 0;
            this.rdCaChieu.Text = "Ca chiều";
            this.rdCaChieu.UseVisualStyleBackColor = true;
            this.rdCaChieu.CheckedChanged += new System.EventHandler(this.rdCaChieu_CheckedChanged);
            // 
            // rdCaToi
            // 
            this.rdCaToi.AutoSize = true;
            this.rdCaToi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCaToi.Location = new System.Drawing.Point(24, 72);
            this.rdCaToi.Name = "rdCaToi";
            this.rdCaToi.Size = new System.Drawing.Size(60, 20);
            this.rdCaToi.TabIndex = 0;
            this.rdCaToi.Text = "Ca tối";
            this.rdCaToi.UseVisualStyleBackColor = true;
            this.rdCaToi.CheckedChanged += new System.EventHandler(this.rdCaToi_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(101, 122);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 35);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Chọn";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCaSang);
            this.groupBox1.Controls.Add(this.rdCaChieu);
            this.groupBox1.Controls.Add(this.rdCaToi);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn ca";
            // 
            // FrmChonCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 169);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChonCa";
            this.Text = "Chọn ca";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdCaSang;
        private System.Windows.Forms.RadioButton rdCaChieu;
        private System.Windows.Forms.RadioButton rdCaToi;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}