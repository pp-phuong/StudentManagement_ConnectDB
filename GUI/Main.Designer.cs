
namespace StudentManagement.GUI
{
    partial class Main
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_search_type = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cbbLSH = new System.Windows.Forms.ComboBox();
            this.label_lsh = new System.Windows.Forms.Label();
            this.groupBox_DSSV = new System.Windows.Forms.GroupBox();
            this.datagridview_dssv = new System.Windows.Forms.DataGridView();
            this.cbb_Sort = new System.Windows.Forms.ComboBox();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox_DSSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_dssv)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(278, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nội dung tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tìm kiếm theo";
            // 
            // cbb_search_type
            // 
            this.cbb_search_type.FormattingEnabled = true;
            this.cbb_search_type.Location = new System.Drawing.Point(631, 71);
            this.cbb_search_type.Name = "cbb_search_type";
            this.cbb_search_type.Size = new System.Drawing.Size(121, 21);
            this.cbb_search_type.TabIndex = 20;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(677, 132);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 22;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(652, 103);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 21;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // cbbLSH
            // 
            this.cbbLSH.FormattingEnabled = true;
            this.cbbLSH.Location = new System.Drawing.Point(49, 102);
            this.cbbLSH.Name = "cbbLSH";
            this.cbbLSH.Size = new System.Drawing.Size(121, 21);
            this.cbbLSH.TabIndex = 18;
            this.cbbLSH.Text = "Chọn lớp sinh hoạt";
            this.cbbLSH.SelectedIndexChanged += new System.EventHandler(this.cbbLSH_SelectedIndexChanged);
            // 
            // label_lsh
            // 
            this.label_lsh.AutoSize = true;
            this.label_lsh.Location = new System.Drawing.Point(49, 74);
            this.label_lsh.Name = "label_lsh";
            this.label_lsh.Size = new System.Drawing.Size(75, 13);
            this.label_lsh.TabIndex = 19;
            this.label_lsh.Text = "Lớp Sinh Hoạt";
            // 
            // groupBox_DSSV
            // 
            this.groupBox_DSSV.Controls.Add(this.datagridview_dssv);
            this.groupBox_DSSV.Controls.Add(this.cbb_Sort);
            this.groupBox_DSSV.Controls.Add(this.btn_sort);
            this.groupBox_DSSV.Controls.Add(this.btn_delete);
            this.groupBox_DSSV.Controls.Add(this.btn_edit);
            this.groupBox_DSSV.Controls.Add(this.btn_add);
            this.groupBox_DSSV.Location = new System.Drawing.Point(52, 159);
            this.groupBox_DSSV.Name = "groupBox_DSSV";
            this.groupBox_DSSV.Size = new System.Drawing.Size(700, 254);
            this.groupBox_DSSV.TabIndex = 17;
            this.groupBox_DSSV.TabStop = false;
            this.groupBox_DSSV.Text = "Danh sách Sinh Viên";
            // 
            // datagridview_dssv
            // 
            this.datagridview_dssv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_dssv.EnableHeadersVisualStyles = false;
            this.datagridview_dssv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridview_dssv.Location = new System.Drawing.Point(20, 32);
            this.datagridview_dssv.Name = "datagridview_dssv";
            this.datagridview_dssv.ReadOnly = true;
            this.datagridview_dssv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_dssv.Size = new System.Drawing.Size(657, 150);
            this.datagridview_dssv.TabIndex = 11;
            // 
            // cbb_Sort
            // 
            this.cbb_Sort.FormattingEnabled = true;
            this.cbb_Sort.Location = new System.Drawing.Point(556, 214);
            this.cbb_Sort.Name = "cbb_Sort";
            this.cbb_Sort.Size = new System.Drawing.Size(121, 21);
            this.cbb_Sort.TabIndex = 10;
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(481, 212);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(46, 23);
            this.btn_sort.TabIndex = 9;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(145, 212);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(42, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Del";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(76, 212);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(42, 23);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(11, 212);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(43, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(197, 100);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_search_type);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.cbbLSH);
            this.Controls.Add(this.label_lsh);
            this.Controls.Add(this.groupBox_DSSV);
            this.Name = "Main";
            this.Text = "Main";
            this.groupBox_DSSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_dssv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_search_type;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cbbLSH;
        private System.Windows.Forms.Label label_lsh;
        private System.Windows.Forms.GroupBox groupBox_DSSV;
        private System.Windows.Forms.DataGridView datagridview_dssv;
        private System.Windows.Forms.ComboBox cbb_Sort;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btnShow;
    }
}