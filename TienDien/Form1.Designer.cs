namespace TienDien
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbHoTenChuHo = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNhapMoi = new System.Windows.Forms.Button();
            this.btnTienDien = new System.Windows.Forms.Button();
            this.btnTienDienMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txbSCTDThangTruoc = new System.Windows.Forms.TextBox();
            this.txbSCTDThangNay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên chủ hộ";
            // 
            // txbHoTenChuHo
            // 
            this.txbHoTenChuHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHoTenChuHo.Location = new System.Drawing.Point(32, 131);
            this.txbHoTenChuHo.Name = "txbHoTenChuHo";
            this.txbHoTenChuHo.Size = new System.Drawing.Size(264, 30);
            this.txbHoTenChuHo.TabIndex = 1;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiaChi.Location = new System.Drawing.Point(324, 131);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(264, 30);
            this.txbDiaChi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số công tơ điện tháng này";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số công tơ điện tháng trước";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phần mềm tính tiền điện";
            // 
            // btnNhapMoi
            // 
            this.btnNhapMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapMoi.Location = new System.Drawing.Point(32, 266);
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Size = new System.Drawing.Size(113, 36);
            this.btnNhapMoi.TabIndex = 9;
            this.btnNhapMoi.Text = "Nhập mới";
            this.btnNhapMoi.UseVisualStyleBackColor = true;
            this.btnNhapMoi.Click += new System.EventHandler(this.btnNhapMoi_Click);
            // 
            // btnTienDien
            // 
            this.btnTienDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienDien.Location = new System.Drawing.Point(174, 266);
            this.btnTienDien.Name = "btnTienDien";
            this.btnTienDien.Size = new System.Drawing.Size(113, 36);
            this.btnTienDien.TabIndex = 10;
            this.btnTienDien.Text = "Tiền điện";
            this.btnTienDien.UseVisualStyleBackColor = true;
            this.btnTienDien.Click += new System.EventHandler(this.btnTienDien_Click);
            // 
            // btnTienDienMoi
            // 
            this.btnTienDienMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienDienMoi.Location = new System.Drawing.Point(324, 266);
            this.btnTienDienMoi.Name = "btnTienDienMoi";
            this.btnTienDienMoi.Size = new System.Drawing.Size(113, 36);
            this.btnTienDienMoi.TabIndex = 11;
            this.btnTienDienMoi.Text = "TĐ mới";
            this.btnTienDienMoi.UseVisualStyleBackColor = true;
            this.btnTienDienMoi.Click += new System.EventHandler(this.btnTienDienMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(475, 266);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 36);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txbSCTDThangTruoc
            // 
            this.txbSCTDThangTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSCTDThangTruoc.Location = new System.Drawing.Point(324, 211);
            this.txbSCTDThangTruoc.Name = "txbSCTDThangTruoc";
            this.txbSCTDThangTruoc.Size = new System.Drawing.Size(264, 30);
            this.txbSCTDThangTruoc.TabIndex = 14;
            this.txbSCTDThangTruoc.Text = "0";
           
            // 
            // txbSCTDThangNay
            // 
            this.txbSCTDThangNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSCTDThangNay.Location = new System.Drawing.Point(32, 211);
            this.txbSCTDThangNay.Name = "txbSCTDThangNay";
            this.txbSCTDThangNay.Size = new System.Drawing.Size(264, 30);
            this.txbSCTDThangNay.TabIndex = 13;
            this.txbSCTDThangNay.Text = "0";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 329);
            this.Controls.Add(this.txbSCTDThangTruoc);
            this.Controls.Add(this.txbSCTDThangNay);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTienDienMoi);
            this.Controls.Add(this.btnTienDien);
            this.Controls.Add(this.btnNhapMoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbHoTenChuHo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbHoTenChuHo;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNhapMoi;
        private System.Windows.Forms.Button btnTienDien;
        private System.Windows.Forms.Button btnTienDienMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txbSCTDThangTruoc;
        private System.Windows.Forms.TextBox txbSCTDThangNay;
    }
}

