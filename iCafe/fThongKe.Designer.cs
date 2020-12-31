
namespace iCafe
{
    partial class fThongKe
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.cbThang = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.btnHienTatCa = new System.Windows.Forms.Button();
            this.MAHOADON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThang)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(174, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(464, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "ICAFE - THỐNG KÊ DOANH THU";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnQuayLai.Location = new System.Drawing.Point(12, 23);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(100, 33);
            this.btnQuayLai.TabIndex = 10;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHOADON,
            this.NGAYLAP,
            this.TENMON,
            this.DONGIA,
            this.SOLUONG,
            this.THANHTIEN});
            this.dgvDoanhThu.Location = new System.Drawing.Point(42, 234);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersVisible = false;
            this.dgvDoanhThu.RowHeadersWidth = 62;
            this.dgvDoanhThu.RowTemplate.Height = 28;
            this.dgvDoanhThu.Size = new System.Drawing.Size(723, 275);
            this.dgvDoanhThu.TabIndex = 11;
            // 
            // cbThang
            // 
            this.cbThang.Location = new System.Drawing.Point(180, 175);
            this.cbThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.cbThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(100, 26);
            this.cbThang.TabIndex = 12;
            this.cbThang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chọn tháng:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(317, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "THỐNG KÊ THÁNG";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.BackColor = System.Drawing.SystemColors.Control;
            this.txtTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.txtTongDoanhThu.Location = new System.Drawing.Point(524, 172);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.ReadOnly = true;
            this.txtTongDoanhThu.Size = new System.Drawing.Size(229, 26);
            this.txtTongDoanhThu.TabIndex = 15;
            this.txtTongDoanhThu.Text = "0 VND";
            this.txtTongDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnHienTatCa
            // 
            this.btnHienTatCa.BackColor = System.Drawing.Color.Red;
            this.btnHienTatCa.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnHienTatCa.Location = new System.Drawing.Point(662, 24);
            this.btnHienTatCa.Name = "btnHienTatCa";
            this.btnHienTatCa.Size = new System.Drawing.Size(126, 86);
            this.btnHienTatCa.TabIndex = 16;
            this.btnHienTatCa.Text = "HIỆN TẤT CẢ";
            this.btnHienTatCa.UseVisualStyleBackColor = false;
            this.btnHienTatCa.Click += new System.EventHandler(this.button2_Click);
            // 
            // MAHOADON
            // 
            this.MAHOADON.DataPropertyName = "MAHOADON";
            this.MAHOADON.HeaderText = "Mã Hóa Đơn";
            this.MAHOADON.MinimumWidth = 8;
            this.MAHOADON.Name = "MAHOADON";
            this.MAHOADON.Width = 150;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.HeaderText = "Ngày Lập";
            this.NGAYLAP.MinimumWidth = 8;
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.Width = 150;
            // 
            // TENMON
            // 
            this.TENMON.DataPropertyName = "TENMON";
            this.TENMON.HeaderText = "Tên Món";
            this.TENMON.MinimumWidth = 8;
            this.TENMON.Name = "TENMON";
            this.TENMON.Width = 150;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.MinimumWidth = 8;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Width = 150;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.MinimumWidth = 8;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 150;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            this.THANHTIEN.HeaderText = "Thành Tiền";
            this.THANHTIEN.MinimumWidth = 8;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.Width = 150;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(180, 123);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 26);
            this.txtNam.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Chọn năm:";
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.btnHienTatCa);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.label7);
            this.Name = "fThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.NumericUpDown cbThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.Button btnHienTatCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHOADON;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label2;
    }
}