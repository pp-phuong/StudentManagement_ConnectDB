
namespace StudentManagement.GUI
{
    partial class Detail
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
            this.gb_ttsv = new System.Windows.Forms.GroupBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radio_male = new System.Windows.Forms.RadioButton();
            this.cbbLSH = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label_birthday = new System.Windows.Forms.Label();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_tensv = new System.Windows.Forms.TextBox();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.label_lsh = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_mssv = new System.Windows.Forms.Label();
            this.gb_ttsv.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_ttsv
            // 
            this.gb_ttsv.Controls.Add(this.groupBoxGender);
            this.gb_ttsv.Controls.Add(this.cbbLSH);
            this.gb_ttsv.Controls.Add(this.btn_cancel);
            this.gb_ttsv.Controls.Add(this.btn_confirm);
            this.gb_ttsv.Controls.Add(this.label_birthday);
            this.gb_ttsv.Controls.Add(this.dtp_ngaysinh);
            this.gb_ttsv.Controls.Add(this.txt_tensv);
            this.gb_ttsv.Controls.Add(this.txt_masv);
            this.gb_ttsv.Controls.Add(this.label_lsh);
            this.gb_ttsv.Controls.Add(this.label_name);
            this.gb_ttsv.Controls.Add(this.label_mssv);
            this.gb_ttsv.Location = new System.Drawing.Point(38, 21);
            this.gb_ttsv.Name = "gb_ttsv";
            this.gb_ttsv.Size = new System.Drawing.Size(336, 361);
            this.gb_ttsv.TabIndex = 2;
            this.gb_ttsv.TabStop = false;
            this.gb_ttsv.Text = "Thông tin SV";
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioFemale);
            this.groupBoxGender.Controls.Add(this.radio_male);
            this.groupBoxGender.Location = new System.Drawing.Point(33, 202);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(283, 73);
            this.groupBoxGender.TabIndex = 8;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(171, 32);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(59, 17);
            this.radioFemale.TabIndex = 0;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            this.radio_male.AutoSize = true;
            this.radio_male.Location = new System.Drawing.Point(83, 32);
            this.radio_male.Name = "radio_male";
            this.radio_male.Size = new System.Drawing.Size(48, 17);
            this.radio_male.TabIndex = 0;
            this.radio_male.TabStop = true;
            this.radio_male.Text = "Male";
            this.radio_male.UseVisualStyleBackColor = true;
            // 
            // cbbLSH
            // 
            this.cbbLSH.FormattingEnabled = true;
            this.cbbLSH.Location = new System.Drawing.Point(116, 128);
            this.cbbLSH.Name = "cbbLSH";
            this.cbbLSH.Size = new System.Drawing.Size(121, 21);
            this.cbbLSH.TabIndex = 3;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(116, 310);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(35, 310);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 6;
            this.btn_confirm.Text = "OK";
            this.btn_confirm.UseMnemonic = false;
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label_birthday
            // 
            this.label_birthday.AutoSize = true;
            this.label_birthday.Location = new System.Drawing.Point(30, 163);
            this.label_birthday.Name = "label_birthday";
            this.label_birthday.Size = new System.Drawing.Size(54, 13);
            this.label_birthday.TabIndex = 3;
            this.label_birthday.Text = "Ngày sinh";
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(116, 163);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(200, 20);
            this.dtp_ngaysinh.TabIndex = 4;
            // 
            // txt_tensv
            // 
            this.txt_tensv.Location = new System.Drawing.Point(116, 94);
            this.txt_tensv.Name = "txt_tensv";
            this.txt_tensv.Size = new System.Drawing.Size(100, 20);
            this.txt_tensv.TabIndex = 2;
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(116, 66);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(100, 20);
            this.txt_masv.TabIndex = 1;
            // 
            // label_lsh
            // 
            this.label_lsh.AutoSize = true;
            this.label_lsh.Location = new System.Drawing.Point(30, 128);
            this.label_lsh.Name = "label_lsh";
            this.label_lsh.Size = new System.Drawing.Size(47, 13);
            this.label_lsh.TabIndex = 0;
            this.label_lsh.Text = "Tên Lớp";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(30, 97);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(43, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Tên SV";
            // 
            // label_mssv
            // 
            this.label_mssv.AutoSize = true;
            this.label_mssv.Location = new System.Drawing.Point(30, 69);
            this.label_mssv.Name = "label_mssv";
            this.label_mssv.Size = new System.Drawing.Size(39, 13);
            this.label_mssv.TabIndex = 0;
            this.label_mssv.Text = "Mã SV";
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.gb_ttsv);
            this.Name = "Detail";
            this.Text = "Detail";
            this.gb_ttsv.ResumeLayout(false);
            this.gb_ttsv.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ttsv;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radio_male;
        private System.Windows.Forms.ComboBox cbbLSH;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label_birthday;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.TextBox txt_tensv;
        private System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.Label label_lsh;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_mssv;
    }
}