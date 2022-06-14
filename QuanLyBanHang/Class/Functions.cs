using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLyBanHang.Class
{
    class Functions
    {
        public static SqlConnection Con;
        public static void Connect()
        {
            Con = new SqlConnection();  
            Con.ConnectionString = @"Data Source=.\LAPTOP-GQQGGF0U\MSSQLSERVER01;AttachDbFilename=" + Application.StartupPath + @"\Quanlybanhang.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            Con.Open();                
           

        }
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   
                Con.Dispose(); 	
                Con = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(); 
            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection = Functions.Con; 
            dap.SelectCommand.CommandText = sql; 
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; 
            cbo.DisplayMember = ten; 
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
        public static void RunSQL(string sql)
        {
            SqlCommand cmd; 
            cmd = new SqlCommand();
            cmd.Connection = Con; 
            cmd.CommandText = sql; 
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.Con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }        

    }
}
