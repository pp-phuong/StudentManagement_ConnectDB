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
using StudentManagement.DTO;

namespace StudentManagement.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            setCBBLSH();
            show(0);
        }
        private void setCBBLSH()
        {
            BLL_QLSV bll = new BLL_QLSV();
            cbbLSH.Items.Add(new CBB_Item()
                {
                    Text = "All",
                    Value = 0
                });
                foreach (LSH i in bll.GetListLSH_BLL())
                {

                    cbbLSH.Items.Add(new CBB_Item()
                    {
                        Text = i.ClassName,
                        Value = i.ClassID,
                    });
                }
                cbbLSH.SelectedItem = cbbLSH.Items[0];
        }
        private void cbbLSH_SelectedIndexChanged(object sender, EventArgs e)
        {
            show(getCurrentClassID());
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            show(getCurrentClassID());
        }

        private void show(int type)
        {
            BLL_QLSV bll = new BLL_QLSV();
            datagridview_dssv.DataSource = bll.GetListSV_BLL(getCurrentClassID());
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            GUI.Detail f2 = new GUI.Detail();
            f2.ShowDialog();
            show(1);
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            BLL_QLSV bll = new BLL_QLSV();
            //datagridview_dssv.DataSource = 
        }
        private int getCurrentClassID()
        {
            return ((CBB_Item)cbbLSH.SelectedItem).Value;
        }
    }
}
