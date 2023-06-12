using System;
using System.Data;
using System.Data.SqlClient;

namespace prja.uadonet
{
    class CLSSSSelaa
    {
        public static void Main()
        {
            SqlConnection sqlcnn = null;
            SqlCommand sqlcmd = null;
            SqlDataAdapter sqlda = null;
            DataSet ds = null;
            DataTable dt = null;

            string qrySel = null;

            try
            {
                qrySel = "select * from ematbl";

                Console.Write("\nEmployee Salary Allowance");
                Console.WriteLine(" for show no. of columns and rows\n");

                sqlcnn = new SqlConnection(CLSSSCnStr.cnStr);
                sqlcnn.Open();

                sqlcmd = new SqlCommand(qrySel, sqlcnn);

                sqlda = new SqlDataAdapter(sqlcmd);
                ds = new DataSet();
                sqlda.Fill(ds, "ematbl");
                dt = ds.Tables["ematbl"];

                Console.WriteLine("No. of columns: " + dt.Columns.Count);
                Console.WriteLine("No. of rows: " + dt.Rows.Count);
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Err.: " + e.Message);

            }
            finally
            {
                sqlcnn.Close();

            }
        }
    }
}
