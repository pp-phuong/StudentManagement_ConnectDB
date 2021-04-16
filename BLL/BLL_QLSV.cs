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
        public delegate bool Compare(object o1, object o2);
        public Compare cmp;

        public object GV { get; private set; }

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
        public SV GetSV_BLL(string MSSV)
        {
            DAL_QLSV Dal = new DAL_QLSV();
            return Dal.getSVbyMSSV(MSSV);
        }
        public bool AddSV_BLL(SV s)
        {
            DAL_QLSV Dal = new DAL_QLSV();
            Dal.AddSV_DAL(s);
            return true;
        }
        public bool UpdateSV_BLL(SV s)
        {
            DAL_QLSV Dal = new DAL_QLSV();
            Dal.UpdateSV_DAL(s);
            return true;
        }
        public bool DeleteSV_BLL(String MSSV)
        {
            DAL_QLSV Dal = new DAL_QLSV();
            Dal.DeleteSV_DAL(MSSV);
            return true;
        }
        public List<SV> GetListSVDTGV(List<string> LMSSV)
        {
            List<SV> data = new List<SV>();
            DAL_QLSV Dal = new DAL_QLSV();
            foreach( string i in LMSSV)
            {
                data.Add(Dal.getSVbyMSSV(i));
            }
            return data;
        }
        public List<SV> filterSV(string type, string search_key, List<SV> list)
        {
            List<SV> result = new List<SV>();
            switch (type)
            {
                case "":
                    result = list;
                    break;
                case "MSSV":
                    result = list.FindAll(i => i.MSSV.ToString().Contains(search_key));
                    break;
                case "NameSV":
                    result = list.FindAll(i => i.NameSV.ToString().ToUpper().Contains(search_key.ToUpper()));
                    break;
                case "Gender":
                    result = list.FindAll(i => i.Gender.ToString().ToUpper().Contains(search_key.ToUpper()));
                    break;
                case "NS":
                    result = list.FindAll(i => i.NS.ToString().Contains(search_key));
                    break;
                case "ID_Lop":
                    result = list.FindAll(i => i.ID_Lop.ToString().Contains(search_key));
                    break;

            }
            return result;
        }
        public List<SV> SortListSV(List<SV> list, string type)
        {
            switch(type ){
                case "MSSV":
                    cmp = SV.Compare_MSSV;
                    break;
                case "NameSV":
                    cmp = SV.Compare_Name;
                    break;
                case "Gender":
                    cmp = SV.Compare_Gender;
                    break;
                case "ClassID":
                    cmp = SV.Compare_ClassID;
                    break;
                case "Birthday":
                    cmp = SV.Compare_Birth;
                    break;
                default:
                    break;
            }    

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (cmp(list[i],list[j]))
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
        public string setNextMSSV()
        {
            DAL_QLSV Dal = new DAL_QLSV();
            return Dal.setNextMSSV();
        }
    }
}
