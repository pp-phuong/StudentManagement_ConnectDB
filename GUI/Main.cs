using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.BLL;

namespace StudentManagement.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void cbbLSH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            show();
        }

        private void show()
        {
            BLL_QLSV bll = new BLL_QLSV();
            datagridview_dssv.DataSource = bll.GetListSV_BLL();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            GUI.Detail f2 = new GUI.Detail();
            f2.ShowDialog();
            show();
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            BLL_QLSV bll = new BLL_QLSV();
            //datagridview_dssv.DataSource = 
        }
    }
}
