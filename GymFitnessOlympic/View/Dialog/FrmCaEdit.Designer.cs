namespace GymFitnessOlympic.View.Dialog
{
    partial class FrmCaEdit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spnPhutKetThuc = new DevExpress.XtraEditors.SpinEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.spnPhutBatDau = new DevExpress.XtraEditors.SpinEdit();
            this.spnGioKetThuc = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.spnGioBatDau = new DevExpress.XtraEditors.SpinEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnPhutKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPhutBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnGioKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnGioBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spnPhutKetThuc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.spnPhutBatDau);
            this.groupBox1.Controls.Add(this.spnGioKetThuc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.spnGioBatDau);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 138);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian làm việc";
            // 
            // spnPhutKetThuc
            // 
            this.spnPhutKetThuc.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPhutKetThuc.Location = new System.Drawing.Point(272, 92);
            this.spnPhutKetThuc.Name = "spnPhutKetThuc";
            this.spnPhutKetThuc.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnPhutKetThuc.Properties.Appearance.Options.UseFont = true;
            this.spnPhutKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnPhutKetThuc.Size = new System.Drawing.Size(55, 26);
            this.spnPhutKetThuc.TabIndex = 1;
            this.spnPhutKetThuc.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.spnPhutKetThuc_EditValueChanging);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phút";
            // 
            // spnPhutBatDau
            // 
            this.spnPhutBatDau.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPhutBatDau.Location = new System.Drawing.Point(272, 35);
            this.spnPhutBatDau.Name = "spnPhutBatDau";
            this.spnPhutBatDau.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnPhutBatDau.Properties.Appearance.Options.UseFont = true;
            this.spnPhutBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnPhutBatDau.Size = new System.Drawing.Size(55, 26);
            this.spnPhutBatDau.TabIndex = 1;
            this.spnPhutBatDau.EditValueChanged += new System.EventHandler(this.spnPhutBatDau_EditValueChanged);
            this.spnPhutBatDau.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.spnPhutBatDau_EditValueChanging);
            // 
            // spnGioKetThuc
            // 
            this.spnGioKetThuc.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnGioKetThuc.Location = new System.Drawing.Point(125, 91);
            this.spnGioKetThuc.Name = "spnGioKetThuc";
            this.spnGioKetThuc.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnGioKetThuc.Properties.Appearance.Options.UseFont = true;
            this.spnGioKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnGioKetThuc.Size = new System.Drawing.Size(55, 26);
            this.spnGioKetThuc.TabIndex = 1;
            this.spnGioKetThuc.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.spnGioKetThuc_EditValueChanging);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phút";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giờ";
            // 
            // spnGioBatDau
            // 
            this.spnGioBatDau.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnGioBatDau.Location = new System.Drawing.Point(125, 36);
            this.spnGioBatDau.Name = "spnGioBatDau";
            this.spnGioBatDau.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnGioBatDau.Properties.Appearance.Options.UseFont = true;
            this.spnGioBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnGioBatDau.Properties.IsFloatValue = false;
            this.spnGioBatDau.Properties.Mask.EditMask = "N00";
            this.spnGioBatDau.Size = new System.Drawing.Size(55, 26);
            this.spnGioBatDau.TabIndex = 1;
            this.spnGioBatDau.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.spnGioBatDau_EditValueChanging);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giờ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bắt đầu";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(68, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 58);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(252, 182);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(148, 58);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Hủy";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // FrmCaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 268);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCaEdit";
            this.Text = "Chỉnh sửa giờ làm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnPhutKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPhutBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnGioKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnGioBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SpinEdit spnPhutKetThuc;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SpinEdit spnPhutBatDau;
        private DevExpress.XtraEditors.SpinEdit spnGioKetThuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SpinEdit spnGioBatDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;

    }
}