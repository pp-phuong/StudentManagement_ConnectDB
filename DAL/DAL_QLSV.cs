using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.DTO;
using System.Data;
namespace StudentManagement.DAL

{
    class DAL_QLSV
    {
        public List<SV> GetListSV_DAL()
        {
            List<SV> data = new List<SV>();
            string query = "select * from SV";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(set1SV(i));
            }
            return data;
        }
        public bool AddSV_DAL(SV s)
        {
            int gender = 1;
            if(s.Gender == true )
            {
                gender = 1;
            }    
            else
            {
                gender = 0;
            }    
            string query = "INSERT INTO SV VALUES('";
            query += s.MSSV + "', ' " + s.NameSV + "'," + gender + ", '" + s.Birthday + "'," + s.ClassID + ")";
            DBHelper.Instance.ExcuteDB(query);
            return true;
        }
        private SV set1SV(DataRow i)
        {
            SV s = new SV();
            s.MSSV = Convert.ToInt32(i["MSSV"].ToString());
            s.NameSV = i["NameSV"].ToString();
            s.Gender = Convert.ToBoolean(i["Gender"].ToString());
            s.Birthday = Convert.ToDateTime(i["Birthday"].ToString());
            s.ClassID = Convert.ToInt32(i["ClassID"].ToString());
            return s;
        }
        private LSH set1LSH(DataRow i)
        {
            LSH l = new LSH();
            l.ClassID = Convert.ToInt32(i["ClassID"].ToString());
            l.ClassName = i["ClassName"].ToString();
            return l;
        }
    }
}
