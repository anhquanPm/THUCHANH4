namespace THUCHANH4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_ma_benh_nhan = new System.Windows.Forms.ComboBox();
            this.tblBenhNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thamMyVienDataSet = new THUCHANH4.ThamMyVienDataSet();
            this.lb_dsdv = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_dich_vu = new System.Windows.Forms.ComboBox();
            this.tblDichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.tb_nam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_thang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ngay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ten_benh_nhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_chon = new System.Windows.Forms.Button();
            this.btn_tiptuc = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_kq = new System.Windows.Forms.Label();
            this.tblBenhNhanTableAdapter = new THUCHANH4.ThamMyVienDataSetTableAdapters.tblBenhNhanTableAdapter();
            this.tblDichVuTableAdapter = new THUCHANH4.ThamMyVienDataSetTableAdapters.tblDichVuTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblBenhNhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thamMyVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_ma_benh_nhan);
            this.groupBox1.Controls.Add(this.lb_dsdv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbb_dich_vu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_nam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_thang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_ngay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_ten_benh_nhan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1022, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // cbb_ma_benh_nhan
            // 
            this.cbb_ma_benh_nhan.DataSource = this.tblBenhNhanBindingSource;
            this.cbb_ma_benh_nhan.DisplayMember = "MaBN";
            this.cbb_ma_benh_nhan.FormattingEnabled = true;
            this.cbb_ma_benh_nhan.Location = new System.Drawing.Point(162, 46);
            this.cbb_ma_benh_nhan.Name = "cbb_ma_benh_nhan";
            this.cbb_ma_benh_nhan.Size = new System.Drawing.Size(238, 31);
            this.cbb_ma_benh_nhan.TabIndex = 14;
            this.cbb_ma_benh_nhan.ValueMember = "MaBN";
            this.cbb_ma_benh_nhan.SelectedIndexChanged += new System.EventHandler(this.cbb_ma_benh_nhan_SelectedIndexChanged_1);
            // 
            // tblBenhNhanBindingSource
            // 
            this.tblBenhNhanBindingSource.DataMember = "tblBenhNhan";
            this.tblBenhNhanBindingSource.DataSource = this.thamMyVienDataSet;
            // 
            // thamMyVienDataSet
            // 
            this.thamMyVienDataSet.DataSetName = "ThamMyVienDataSet";
            this.thamMyVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lb_dsdv
            // 
            this.lb_dsdv.BackColor = System.Drawing.Color.OldLace;
            this.lb_dsdv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_dsdv.Location = new System.Drawing.Point(680, 228);
            this.lb_dsdv.Name = "lb_dsdv";
            this.lb_dsdv.Size = new System.Drawing.Size(288, 165);
            this.lb_dsdv.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Danh sách dịch vụ";
            // 
            // cbb_dich_vu
            // 
            this.cbb_dich_vu.DataSource = this.tblDichVuBindingSource;
            this.cbb_dich_vu.DisplayMember = "tenDV";
            this.cbb_dich_vu.FormattingEnabled = true;
            this.cbb_dich_vu.Location = new System.Drawing.Point(162, 220);
            this.cbb_dich_vu.Name = "cbb_dich_vu";
            this.cbb_dich_vu.Size = new System.Drawing.Size(238, 31);
            this.cbb_dich_vu.TabIndex = 6;
            this.cbb_dich_vu.ValueMember = "tenDV";
            this.cbb_dich_vu.SelectedIndexChanged += new System.EventHandler(this.cbb_dich_vu_SelectedIndexChanged);
            // 
            // tblDichVuBindingSource
            // 
            this.tblDichVuBindingSource.DataMember = "tblDichVu";
            this.tblDichVuBindingSource.DataSource = this.thamMyVienDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Chọn dịch vụ";
            // 
            // tb_nam
            // 
            this.tb_nam.Location = new System.Drawing.Point(465, 150);
            this.tb_nam.Name = "tb_nam";
            this.tb_nam.Size = new System.Drawing.Size(64, 30);
            this.tb_nam.TabIndex = 5;
            this.tb_nam.TextChanged += new System.EventHandler(this.tb_nam_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Năm";
            // 
            // tb_thang
            // 
            this.tb_thang.Location = new System.Drawing.Point(283, 150);
            this.tb_thang.Name = "tb_thang";
            this.tb_thang.Size = new System.Drawing.Size(64, 30);
            this.tb_thang.TabIndex = 4;
            this.tb_thang.TextChanged += new System.EventHandler(this.tb_thang_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tháng";
            // 
            // tb_ngay
            // 
            this.tb_ngay.Location = new System.Drawing.Point(107, 150);
            this.tb_ngay.Name = "tb_ngay";
            this.tb_ngay.Size = new System.Drawing.Size(64, 30);
            this.tb_ngay.TabIndex = 3;
            this.tb_ngay.TextChanged += new System.EventHandler(this.tb_ngay_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên bệnh nhân";
            // 
            // tb_ten_benh_nhan
            // 
            this.tb_ten_benh_nhan.Location = new System.Drawing.Point(162, 99);
            this.tb_ten_benh_nhan.Name = "tb_ten_benh_nhan";
            this.tb_ten_benh_nhan.Size = new System.Drawing.Size(238, 30);
            this.tb_ten_benh_nhan.TabIndex = 1;
            this.tb_ten_benh_nhan.TextChanged += new System.EventHandler(this.tb_ten_benh_nhan_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bệnh nhân";
            // 
            // btn_chon
            // 
            this.btn_chon.Image = ((System.Drawing.Image)(resources.GetObject("btn_chon.Image")));
            this.btn_chon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chon.Location = new System.Drawing.Point(46, 435);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Size = new System.Drawing.Size(84, 33);
            this.btn_chon.TabIndex = 8;
            this.btn_chon.Text = "Chọn";
            this.btn_chon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_chon.UseVisualStyleBackColor = true;
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // btn_tiptuc
            // 
            this.btn_tiptuc.Image = ((System.Drawing.Image)(resources.GetObject("btn_tiptuc.Image")));
            this.btn_tiptuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tiptuc.Location = new System.Drawing.Point(210, 435);
            this.btn_tiptuc.Name = "btn_tiptuc";
            this.btn_tiptuc.Size = new System.Drawing.Size(103, 33);
            this.btn_tiptuc.TabIndex = 9;
            this.btn_tiptuc.Text = "Tiếp tục";
            this.btn_tiptuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tiptuc.UseVisualStyleBackColor = true;
            this.btn_tiptuc.Click += new System.EventHandler(this.btn_tiptuc_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(411, 435);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 33);
            this.button3.TabIndex = 10;
            this.button3.Text = "Thoát";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(42, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Kết quả";
            // 
            // lb_kq
            // 
            this.lb_kq.BackColor = System.Drawing.Color.Thistle;
            this.lb_kq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_kq.Location = new System.Drawing.Point(-6, 543);
            this.lb_kq.Name = "lb_kq";
            this.lb_kq.Size = new System.Drawing.Size(1042, 220);
            this.lb_kq.TabIndex = 13;
            // 
            // tblBenhNhanTableAdapter
            // 
            this.tblBenhNhanTableAdapter.ClearBeforeFill = true;
            // 
            // tblDichVuTableAdapter
            // 
            this.tblDichVuTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 760);
            this.Controls.Add(this.lb_kq);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_tiptuc);
            this.Controls.Add(this.btn_chon);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thẩm mỹ viện";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblBenhNhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thamMyVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_nam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_thang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ngay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ten_benh_nhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_chon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_dich_vu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_tiptuc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_kq;
        private System.Windows.Forms.Label lb_dsdv;
        private ThamMyVienDataSet thamMyVienDataSet;
        private System.Windows.Forms.BindingSource tblBenhNhanBindingSource;
        private ThamMyVienDataSetTableAdapters.tblBenhNhanTableAdapter tblBenhNhanTableAdapter;
        private System.Windows.Forms.BindingSource tblDichVuBindingSource;
        private ThamMyVienDataSetTableAdapters.tblDichVuTableAdapter tblDichVuTableAdapter;
        private System.Windows.Forms.ComboBox cbb_ma_benh_nhan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}

