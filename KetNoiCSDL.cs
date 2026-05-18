using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BtlWF
{
    internal class KetNoiCSDL
    {
        
        string strCon = @"Data Source=DESKTOP-9B5OCLN;
                          Initial Catalog=quanlybanhang;
                          Integrated Security=True;
                          TrustServerCertificate=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataReader sqlRead;
        SqlDataAdapter sqlAdap;
        DataSet ds;
        
        public void KetNoi()
        {
            sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                //MessageBox.Show("Kết nối đến CSDl thành công");
            }
        }
      // Ngắt kết nối 
        public void NgatKetNoi()
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
        
        /// <param name="strSQL"
        public void ThucThi(string strSQL)
        {
            
            KetNoi();
            
            sqlCom = new SqlCommand(strSQL, sqlCon);
            sqlCom.ExecuteNonQuery();
           
            NgatKetNoi();
        }
        public void DocDuLieu(string strSQL)
        {
            
            KetNoi();
            
            sqlCom = new SqlCommand(strSQL, sqlCon);
            sqlRead = sqlCom.ExecuteReader();
           
            NgatKetNoi();
        }
        public int sbg(string strSQL)
        {
            KetNoi();
            sqlCom = new SqlCommand (strSQL, sqlCon);
            int sbg = (int)sqlCom.ExecuteScalar();
            return sbg;
        }
        public void ThucThiPKN(string strSQL)
        {
          
            sqlAdap = new SqlDataAdapter(strSQL, strCon);
            
            ds = new DataSet();
            sqlAdap.Fill(ds);
        }
        public DataTable GetDataTable(string sql, params SqlParameter[] pars)
        {
            KetNoi();

            SqlCommand cmd = new SqlCommand(sql, sqlCon);

            if (pars != null && pars.Length > 0)
            {
                cmd.Parameters.AddRange(pars);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            NgatKetNoi();
            return dt;
        }
        public void ExecuteNonQuery(string sql, SqlParameter[] pars)
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            if (pars != null)
                cmd.Parameters.AddRange(pars);
            cmd.ExecuteNonQuery();
            NgatKetNoi();
        }

    }
}
