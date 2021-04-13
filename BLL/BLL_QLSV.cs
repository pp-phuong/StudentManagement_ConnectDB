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

        public List<SV> GetListSV_BLL()
        {
            DAL_QLSV Dal = new DAL_QLSV();
            return Dal.GetListSV_DAL();
        }
        public bool AddSV_BLL(SV s)
        {
            DAL_QLSV Dal = new DAL_QLSV();
            Dal.AddSV_DAL(s);
            return true;
        }

}
}
