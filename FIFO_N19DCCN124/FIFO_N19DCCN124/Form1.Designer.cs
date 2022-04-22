
namespace FIFO_N19DCCN124
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Run = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.tb_Screen = new System.Windows.Forms.TextBox();
            this.tb_Tieude = new System.Windows.Forms.TextBox();
            this.at_Sotrang = new System.Windows.Forms.TextBox();
            this.at_Sokhungtrang = new System.Windows.Forms.TextBox();
            this.at_Chuoitrang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ThongBao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Run
            // 
            this.btn_Run.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Run.Location = new System.Drawing.Point(959, 24);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(160, 68);
            this.btn_Run.TabIndex = 0;
            this.btn_Run.Text = "Chạy chương trình";
            this.btn_Run.UseVisualStyleBackColor = false;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Reset.Location = new System.Drawing.Point(959, 114);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(160, 68);
            this.btn_Reset.TabIndex = 1;
            this.btn_Reset.Text = "Đặt lại";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // tb_Screen
            // 
            this.tb_Screen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tb_Screen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_Screen.Location = new System.Drawing.Point(4, 24);
            this.tb_Screen.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Screen.Multiline = true;
            this.tb_Screen.Name = "tb_Screen";
            this.tb_Screen.ReadOnly = true;
            this.tb_Screen.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Screen.Size = new System.Drawing.Size(915, 289);
            this.tb_Screen.TabIndex = 9;
            this.tb_Screen.WordWrap = false;
            // 
            // tb_Tieude
            // 
            this.tb_Tieude.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb_Tieude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_Tieude.Location = new System.Drawing.Point(4, 2);
            this.tb_Tieude.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Tieude.Name = "tb_Tieude";
            this.tb_Tieude.ReadOnly = true;
            this.tb_Tieude.Size = new System.Drawing.Size(891, 26);
            this.tb_Tieude.TabIndex = 10;
            this.tb_Tieude.Text = "Thuật toán thay thế trang FIPO\r\n";
            this.tb_Tieude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Tieude.TextChanged += new System.EventHandler(this.tb_Tieude_TextChanged);
            // 
            // at_Sotrang
            // 
            this.at_Sotrang.Location = new System.Drawing.Point(712, 377);
            this.at_Sotrang.Margin = new System.Windows.Forms.Padding(4);
            this.at_Sotrang.Multiline = true;
            this.at_Sotrang.Name = "at_Sotrang";
            this.at_Sotrang.Size = new System.Drawing.Size(207, 22);
            this.at_Sotrang.TabIndex = 11;
            this.at_Sotrang.Tag = "";
            this.at_Sotrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // at_Sokhungtrang
            // 
            this.at_Sokhungtrang.Location = new System.Drawing.Point(351, 377);
            this.at_Sokhungtrang.Margin = new System.Windows.Forms.Padding(4);
            this.at_Sokhungtrang.Name = "at_Sokhungtrang";
            this.at_Sokhungtrang.Size = new System.Drawing.Size(185, 22);
            this.at_Sokhungtrang.TabIndex = 12;
            this.at_Sokhungtrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.at_Sokhungtrang.TextChanged += new System.EventHandler(this.at_Sokhungtrang_TextChanged);
            // 
            // at_Chuoitrang
            // 
            this.at_Chuoitrang.Location = new System.Drawing.Point(321, 409);
            this.at_Chuoitrang.Margin = new System.Windows.Forms.Padding(4);
            this.at_Chuoitrang.Name = "at_Chuoitrang";
            this.at_Chuoitrang.Size = new System.Drawing.Size(594, 22);
            this.at_Chuoitrang.TabIndex = 13;
            this.at_Chuoitrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(926, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 60);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giảng viên: Huỳnh Thanh Tâm\r\nSinh viên: Nguyễn Trung Nguyên\r\nMSSV: N19DCCN124\r\nMô" +
    "n: Hệ Điều Hành";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tb_ThongBao
            // 
            this.tb_ThongBao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tb_ThongBao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ThongBao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ThongBao.Location = new System.Drawing.Point(160, 330);
            this.tb_ThongBao.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ThongBao.Name = "tb_ThongBao";
            this.tb_ThongBao.ReadOnly = true;
            this.tb_ThongBao.Size = new System.Drawing.Size(755, 30);
            this.tb_ThongBao.TabIndex = 15;
            this.tb_ThongBao.TextChanged += new System.EventHandler(this.tb_ThongBao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Thông báo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(156, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nhập số khung trang";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(567, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nhập số trang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(156, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nhập chuỗi trang";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(959, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ThongBao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.at_Chuoitrang);
            this.Controls.Add(this.at_Sotrang);
            this.Controls.Add(this.at_Sokhungtrang);
            this.Controls.Add(this.tb_Tieude);
            this.Controls.Add(this.tb_Screen);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Run);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox tb_Screen;
        private System.Windows.Forms.TextBox tb_Tieude;
        private System.Windows.Forms.TextBox at_Sokhungtrang;
        private System.Windows.Forms.TextBox at_Sotrang;
        private System.Windows.Forms.TextBox at_Chuoitrang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ThongBao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

