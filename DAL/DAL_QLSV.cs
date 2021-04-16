using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.DTO;
using System.Data;
using System.Windows.Forms;

namespace StudentManagement.DAL

{
    class DAL_QLSV
    {
        public List<SV> GetListSV_DAL( int classID)
        {
            List<SV> data = new List<SV>();
            string query = "select * from SV";
            switch(classID)
            {
                case 0:
                    break;
                default:
                    query += " where ID_Lop = " + classID;
                    break;
            } 
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(set1SV(i));
            }
            return data;
        }
        public List<LSH> GetListLSH_DAL()
        {
            List<LSH> data = new List<LSH>();
            string query = "select * from LopSH";
           
            foreach( DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(set1LSH(i));
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
            query += s.MSSV + "', N'" + s.NameSV + "'," + gender + ", '" + s.NS + "'," + s.ID_Lop + ")";
            DBHelper.Instance.ExcuteDB(query);
            return true;
        }

        public bool UpdateSV_DAL(SV s)
        {
            int gender = 1;
            if (s.Gender == true)
            {
                gender = 1;
            }
            else
            {
                gender = 0;
            }
           ;
            string query = "UPDATE SV SET NS = '";
            query += s.NS + "', NameSV = N'" + s.NameSV + "', Gender = '" + gender + "', ID_Lop = '" + s.ID_Lop + "' WHERE MSSV = " + s.MSSV;
            DBHelper.Instance.ExcuteDB(query);
            return true;
        }
        
        public bool  DeleteSV_DAL(String MSSV)
        {
            string query = "DELETE FROM SV WHERE MSSV = " +  MSSV;
            DBHelper.Instance.ExcuteDB(query);
            return true;
        }
        private SV set1SV(DataRow i)
        {
            SV s = new SV();
            s.MSSV = i["MSSV"].ToString();
            s.NameSV = i["NameSV"].ToString();
            s.Gender = Convert.ToBoolean(i["Gender"].ToString());
            s.NS = Convert.ToDateTime(i["NS"].ToString());
            s.ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString());
            return s;
        }
        public SV getSVbyMSSV(string MSSV)
        {
            string query = " select * from SV where MSSV = " + MSSV;
            SV s = set1SV(DBHelper.Instance.GetRecords(query).Rows[0]);
            return s;
        }
        private LSH set1LSH(DataRow i)
        {
            LSH l = new LSH();
            l.ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString());
            l.NameLop = i["NameLop"].ToString();
            return l;
        }
       
        public LSH get1LSH(int ID_Lop)
        {
            string query = " select * from SV where LopSH = " + ID_Lop;
            LSH lopsh = set1LSH(DBHelper.Instance.GetRecords(query).Rows[0]);
            return lopsh;
        }

        public string setNextMSSV()
        {
            List<SV> ListSV = GetListSV_DAL(0);
            string LastMSSV = ListSV[ListSV.Count - 1].MSSV;
            string nextMSSV = "";
            if (Convert.ToInt32(LastMSSV) + 1 < 10){
                nextMSSV = "00";
            }
            else if (Convert.ToInt32(LastMSSV) + 1 < 100)
            {
                nextMSSV = "0";
            }
            nextMSSV += (Convert.ToInt32(LastMSSV) + 1).ToString();
            return nextMSSV;
        }
    }
}
