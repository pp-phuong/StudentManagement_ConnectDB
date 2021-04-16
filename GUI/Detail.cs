using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.DTO;
using StudentManagement.BLL;
namespace StudentManagement.GUI
{
    public partial class Detail : Form
    {
        public delegate void delLoadData(int type);
        public delLoadData loadData;
        private SV s;
        private string MSSV;
        public Detail()
        {
            InitializeComponent();
            setCBBLSH();
        }
        private void setCBBLSH()
        {
            BLL_QLSV bll = new BLL_QLSV();
            foreach (LSH i in bll.GetListLSH_BLL())
            {
                CBB_Item item = new CBB_Item()
                {
                    Text = i.NameLop,
                    Value = i.ID_Lop,
                };
                cbbLSH.Items.Add(item);
            
            } 
        }
        public void setInfo(string MSSV)
        {
            this.MSSV = MSSV;
            if( MSSV == "-1")
            {
                BLL_QLSV bll = new BLL_QLSV();
                gb_ttsv.Text = "Thêm Sinh Viên mới ";
                cbbLSH.SelectedIndex = 0;
                radio_male.Checked = true;
                txt_masv.Text = bll.setNextMSSV();
                txt_masv.Enabled = false;

            }    
            else
            {
                gb_ttsv.Text = "Chỉnh sửa thông tin Sinh Viên ";
                BLL_QLSV bll = new BLL_QLSV();
                s = bll.GetSV_BLL(MSSV);
                txt_masv.Text = s.MSSV;
                txt_masv.Enabled = false;
                txt_tensv.Text = s.NameSV;
                txt_masv.Text = s.MSSV.ToString();
                txt_tensv.Text = s.NameSV;
                foreach (CBB_Item i in cbbLSH.Items)
                {
                    if (s.ID_Lop == i.Value)
                    {
                        cbbLSH.SelectedItem = i;
                    }
                }
                if (s.Gender)
                {
                    radio_male.Checked = true;
                }
                else radioFemale.Checked = true;
                dtp_ngaysinh.Value = Convert.ToDateTime(s.NS);
            }
           

        }
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (validateForm() != 0)
            {
                switch (validateForm())
                {
                    case 1:
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin ");
                        break;
                    case 2:
                        MessageBox.Show("Vui Lòng Nhập Mã SV không chứa kí tự!");
                        break;
                }
                return;
            }
            else
            {
                BLL_QLSV bll = new BLL_QLSV();
                if ( MSSV != "-1")
                {
                    bll.UpdateSV_BLL(setSV());
                    MessageBox.Show("Chỉnh sửa SV thành công !");
                    loadData(1);
                    this.Dispose();
                }
                else
                {
                    if (bll.AddSV_BLL(setSV()))
                    {
                        MessageBox.Show("Thêm SV thành công !");
                        loadData(1);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Mã SV đã tồn tại!");
                    }
                }
            }
        }
        private int validateForm()
        {
            if (txt_masv.Text == "" || txt_tensv.Text == "" || cbbLSH.SelectedItem == null)
            {

                return 1;

            }
            for (int i = 0; i < txt_masv.Text.Length; i++)
            {
                if (char.IsLetter(txt_masv.Text[i]) == true)
                {
                    return 2;
                }

            }
            return 0;
        }
        public SV setSV()
        {
            SV s = new SV();
            s.MSSV = txt_masv.Text;
            s.NameSV = txt_tensv.Text;

            if (radio_male.Checked == true)
            {
                s.Gender = true;
            }
            else s.Gender = false;
            s.NS = dtp_ngaysinh.Value;
            s.ID_Lop = ((CBB_Item)cbbLSH.SelectedItem).Value;
            return s;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
