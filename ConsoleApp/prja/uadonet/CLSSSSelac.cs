using System;
using System.Data;
using System.Data.SqlClient;

namespace prja.uadonet
{
    class CLSSSSelac
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
                Console.WriteLine(" for show specific rows");

                sqlcnn = new SqlConnection(CLSSSCnStr.cnStr);
                sqlcnn.Open();

                sqlcmd = new SqlCommand(qrySel, sqlcnn);

                sqlda = new SqlDataAdapter(sqlcmd);
                ds = new DataSet();
                sqlda.Fill(ds, "ematbl");
                dt = ds.Tables["ematbl"];

                Console.WriteLine("\n1st row (index: 0), 7 columns value");
                Console.Write(dt.Rows[0][0] + "\t");
                Console.Write(dt.Rows[0][1] + "\t");
                Console.Write(dt.Rows[0][2] + "\t");
                Console.Write(dt.Rows[0][3] + "\t");
                Console.Write(dt.Rows[0][4] + "\t");
                Console.Write(dt.Rows[0][5] + "\t");
                Console.Write(dt.Rows[0][6] + "\t");
                Console.WriteLine(dt.Rows[0][7] + "\t");

                Console.WriteLine("\n4th row (index: 3), 7 columns value");
                Console.Write(dt.Rows[3][0] + "\t");
                Console.Write(dt.Rows[3][1] + "\t");
                Console.Write(dt.Rows[3][2] + "\t");
                Console.Write(dt.Rows[3][3] + "\t");
                Console.Write(dt.Rows[3][4] + "\t");
                Console.Write(dt.Rows[3][5] + "\t");
                Console.Write(dt.Rows[3][6] + "\t");
                Console.WriteLine(dt.Rows[3][7] + "\t");

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