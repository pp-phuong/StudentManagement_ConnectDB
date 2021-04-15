using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.DAL
{
    class DBHelper
    {
        private static DBHelper _Instance;

        public static DBHelper Instance
        {
            get
            {
                if(_Instance == null)
                {
              
                    _Instance = new DBHelper();
                }
                return _Instance;
            }
        }
      private SqlConnection _cnn;
        public DBHelper()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            _cnn = new SqlConnection(connectionString);
        }
        public DataTable GetRecords(string query)
        {
            //MessageBox.Show(query);
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, _cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            _cnn.Open();
            da.Fill(dt);
            SqlDataReader r = cmd.ExecuteReader();
            _cnn.Close();
            return dt;
        }
        public void ExcuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, _cnn);
            _cnn.Open();
            cmd.ExecuteNonQuery();
            _cnn.Close();

        }
        
    }
}
