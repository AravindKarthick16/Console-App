using System;
using System.Data;
using System.Data.SqlClient;

namespace prja.uadonet
{
    class CLSSSSelab
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

                Console.Write("\nEmployee Salary Allowance table columns name ");


                sqlcnn = new SqlConnection(CLSSSCnStr.cnStr);
                sqlcnn.Open();

                sqlcmd = new SqlCommand(qrySel, sqlcnn);
                sqlda = new SqlDataAdapter(sqlcmd);

                ds = new DataSet();
                sqlda.Fill(ds, "ematbl");
                dt = ds.Tables["ematbl"];

                int cc = dt.Columns.Count;
                for (int c = 0; c < cc; c++)
                {
                    Console.Write(dt.Columns[c].ColumnName + "\t");
                }
                Console.WriteLine();
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
