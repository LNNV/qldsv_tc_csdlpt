using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Quan_Ly_Diem_SV_TC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=LAPTOP-A2R2157O;Initial Catalog=QLDSV_TC;Integrated Security=True";

        public static SqlDataReader myReader;
        public static String servername = "LAPTOP-A2R2157O";
        public static String username = "";
        public static String mlogin = "sa";
        public static String password = "1408";
        public static String hoten = "";
        public static String nhom = "";
        public static String masv = "";
        public static String passwordSV = "";

        public static String database = "QLDSV_TC";
        public static String remotelogin = "htkn";
        public static String remotepassword = "1408";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String serverDN = "";
        public static int khoaID = 0;

        public static BindingSource bds_dspm = new BindingSource();
        public static frmMain frmChinh;

        public static int KetNoi()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open) conn.Close();
            try
            {
                connstr = "Data Source=" + servername + ";Initial Catalog=" +
                      database + ";User ID=" +
                      mlogin + ";Password=" + password;
                conn.ConnectionString = connstr;

                conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("---> Lỗi kết nối cơ sở dữ liệu.\n---> Bạn xem lại Username và Password.\n " + e.Message, string.Empty, MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strlenh)
        {
            SqlDataReader myReader;
            SqlCommand cmd = new SqlCommand(strlenh, conn);

            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                myReader = cmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int CheckDataHelper(String query)
        {
            SqlDataReader dataReader = Program.ExecSqlDataReader(query);

            // nếu null thì thoát luôn  ==> lỗi kết nối
            if (dataReader == null)
            {
                return -1;
            }
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            return result;
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}
