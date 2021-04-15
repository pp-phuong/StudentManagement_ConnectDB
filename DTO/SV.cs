using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DTO
{
    public class SV
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public Boolean Gender { get; set; }
        public DateTime NS { get; set; }
        public int ID_Lop { get; set; }
        public override string ToString()
        {
            return "MSSV:" + MSSV + ", NameSV:" + NameSV;
        }
        public static bool Compare_Name(object o1, object o2)
        {
            if (String.Compare(((SV)o1).getName(), ((SV)o2).getName()) > 0)
                return true;
            else
                return false;
        }
        public static bool Compare_MSSV(object o1, object o2)
        {
            if (String.Compare(((SV)o1).MSSV, ((SV)o2).MSSV) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Compare_ClassID(object o1, object o2)
        {
            if (String.Compare(((SV)o1).ID_Lop.ToString(), ((SV)o2).ID_Lop.ToString()) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Compare_Gender(object o1, object o2)
        {
            if (String.Compare(((SV)o1).Gender.ToString(), ((SV)o2).Gender.ToString()) <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Compare_Birth(object o1, object o2)
        {
            if (String.Compare(((SV)o1).NS.ToString(), ((SV)o2).NS.ToString()) <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string getName()
        {
            string name = "";
            for (int i = NameSV.Length - 1; i >= 0; i--)
            {
                if (" " == NameSV[i].ToString())
                {
                    break;
                }
                else
                {
                    name += NameSV[i];
                }
            }
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            return new string(nameArray);
        }
    }
}
