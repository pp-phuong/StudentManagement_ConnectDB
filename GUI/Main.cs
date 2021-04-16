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
        DialogResult result;
        public Main()
        {
            InitializeComponent();
            setCBBLSH();
            setCBBSort();
            setCBBSearch();
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
                        Text = i.NameLop,
                        Value = i.ID_Lop,
                    });
                }
                cbbLSH.SelectedItem = cbbLSH.Items[0];
        }
        private void setCBBSort()
        {
            SV s = new SV();
            foreach( var property in s.GetType().GetProperties())
            {
                cbb_Sort.Items.Add(property.Name);
            }
            cbb_Sort.Text = "Chọn kiểu sắp xếp";
        }
        private void setCBBSearch()
        {
            SV s = new SV();
            foreach (var property in s.GetType().GetProperties())
            {
                cbb_search_type.Items.Add(property.Name);
            }
            cbb_search_type.Text = "Chọn loại tìm kiếm";
        }
        private void cbbLSH_SelectedIndexChanged(object sender, EventArgs e)
        {
            show(1);
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            show(1);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            GUI.Detail f = new GUI.Detail();
            f.setInfo("-1");
            f.loadData += show;
            f.Show();
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection r = datagridview_dssv.SelectedRows;
            if (r.Count == 0 || r[0].Cells["MSSV"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn SV để chỉnh sửa !");

            }
            else
            {
                // get maGV 
                string MSSV = r[0].Cells["MSSV"].Value.ToString();
                GUI.Detail f = new GUI.Detail();
                f.setInfo(MSSV);
                f.loadData += show;
                f.Show();
            }
        }
        private void btn_sort_Click(object sender, EventArgs e)
        {
            if (cbb_Sort.SelectedItem != null)
            {
                BLL_QLSV bll = new BLL_QLSV();
                List<string> LMSSV = getListMSSV();
                string type = cbb_Sort.SelectedItem.ToString();
                datagridview_dssv.DataSource = bll.SortListSV(bll.GetListSVDTGV(LMSSV), type);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kiểu sắp xếp !");
            }
            
        }
      
        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = datagridview_dssv.SelectedRows;

            if (r.Count == 0 || r[0].Cells["MSSV"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn SV để xóa !");

            }
            else
            {
                string s = "";
                foreach (DataGridViewRow i in r)
                {
                    s += i.Cells["NameSV"].Value.ToString() + " ";
                    if (i.Cells == null)
                    {
                        MessageBox.Show("Vui lòng chọn toàn bộ nội dung SV để xóa !");
                    }
                    else
                    {
                        result = MessageBox.Show("Bạn chắc chắn muốn xóa SV " + s + " ?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            BLL_QLSV Bll = new BLL_QLSV();
                            string MSSV = i.Cells["MSSV"].Value.ToString();
                            if (Bll.DeleteSV_BLL(MSSV))
                            {
                                MessageBox.Show("Xóa thành công!");
                                show(1);
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa !");
                                s = "";
                                continue;
                            }
                        }
                        else
                        {
                            s = "";
                            continue;
                        }
                    }
                }
            }
        }
        private void search()
        {
            if (cbb_search_type.SelectedItem != null)
            {
                BLL_QLSV bll = new BLL_QLSV();
                string type = cbb_search_type.SelectedItem.ToString();
                string search_key = txt_search.Text;
                if (search_key == "")
                {
                    show(1);
                }
                else
                {
                    datagridview_dssv.DataSource = bll.filterSV(type, search_key, bll.GetListSV_BLL(getCurrentClassID()));
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kiểu tìm kiếm !");
            }
        }
        private void show(int type)
        {
            BLL_QLSV bll = new BLL_QLSV();
            if( type == 0)
            {
                datagridview_dssv.DataSource = bll.GetListSV_BLL(0);
            }    
            else
            {
                datagridview_dssv.DataSource = bll.GetListSV_BLL(getCurrentClassID());
            }
            if (datagridview_dssv.DataSource == null)
            {
                MessageBox.Show("Không có sinh viên nào !");
            }
        }
        private int getCurrentClassID()
        {
            return ((CBB_Item)cbbLSH.SelectedItem).Value;
        }

        private List<String> getListMSSV()
        {
            List<string> LMSSV = new List<string>();
            foreach (DataGridViewRow i in datagridview_dssv.Rows)
            {
                LMSSV.Add(i.Cells["MSSV"].Value.ToString());
            }
            return LMSSV;
        }

      
    }
}
