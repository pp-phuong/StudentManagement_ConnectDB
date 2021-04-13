using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.DTO;
using StudentManagement.DAL;
namespace StudentManagement.BLL
{
    class BLL_QLSV
    {

        public List<SV> GetListSV_BLL( int ClassID)
        {
            DAL_QLSV Dal = new DAL_QLSV();
            return Dal.GetListSV_DAL( ClassID);
        }
        public List<LSH> GetListLSH_BLL()
        {
            DAL_QLSV Dal = new DAL_QLSV();
            return Dal.GetListLSH_DAL();
        }
        public bool AddSV_BLL(SV s)
        {
            DAL_QLSV Dal = new DAL_QLSV();
            Dal.AddSV_DAL(s);
            return true;
        }
        public List<SV> GetListSVDTGV(List<int> LMSSV)
        {
            List<SV> data = new List<SV>();
            DAL_QLSV Dal = new DAL_QLSV();
            foreach( int i in LMSSV)
            {
                data.Add(Dal.getSVbyMSSV(i));
            }
            return data;
        }
        public List<SV> SortListSV(List<SV> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].MSSV > list[j].MSSV)
                    {
                        SV temp = new SV();
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }

            }
            return list;
        }

}
}
