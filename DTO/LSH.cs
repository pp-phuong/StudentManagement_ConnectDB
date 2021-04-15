using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DTO
{
    class LSH
    {
        public string NameLop { get; set; }
        public int ID_Lop { get; set; }
        public override string ToString()
        {
            return NameLop;
        }
    }
}
