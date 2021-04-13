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
        public Detail()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            BLL_QLSV bll = new BLL_QLSV();
            bll.AddSV_BLL(setSV());
            this.Dispose();
        }
        public SV setSV()
        {
            SV s = new SV();
            s.MSSV = Convert.ToInt32(txt_masv.Text);
            s.NameSV = txt_tensv.Text;

            if (radio_male.Checked == true)
            {
                s.Gender = true;
            }
            else s.Gender = false;
            s.Birthday = dtp_ngaysinh.Value;
            s.ClassID = 9;
            return s;
        }
     
    }
}
