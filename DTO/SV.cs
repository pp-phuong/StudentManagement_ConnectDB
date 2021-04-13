using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DTO
{
    public class SV
    {
        public int MSSV { get; set; }
        public string NameSV { get; set; }
        public Boolean Gender { get; set; }
        public DateTime Birthday { get; set; }
        public int ClassID { get; set; }
        public override string ToString()
        {
            return "MSSV:" + MSSV + ", NameSV:" + NameSV;
        }
        public static bool Compare_Name(object o1, object o2)
        {
            if (String.Compare(((SV)o1).getName(), ((SV)o2).getName()) < 0)
                return true;
            else
                return false;
        }
        public static bool Compare_MSSV(object o1, object o2)
        {
            if (((SV)o1).MSSV <= ((SV)o2).MSSV)
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
            if (String.Compare(((SV)o1).ClassID.ToString(), ((SV)o2).ClassID.ToString()) <= 0)
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
            if (String.Compare(((SV)o1).Gender.ToString(), ((SV)o2).Gender.ToString()) >= 0)
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
            if (String.Compare(((SV)o1).Birthday.ToString(), ((SV)o2).Birthday.ToString()) <= 0)
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
