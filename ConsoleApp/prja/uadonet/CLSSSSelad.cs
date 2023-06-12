using System;
using System.Data;
using System.Data.SqlClient;

namespace prja.uadonet
{
    class CLSSSSelad
    {
        public static void Main()
        {
            SqlConnection sqlcnn = null;
            SqlCommand sqlcmd = null;
            SqlDataAdapter sqlda = null;
            DataSet ds = null;
            DataTable dt = null;

            string qrySel = null, eid = null;

            try
            {
                qrySel = "select * from ematbl";


                Console.WriteLine("\nEmployee Salary Allownace for show a rows");

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
                    Console.Write(dt.Columns[c].ColumnName);

                    if (c > 1)
                    {
                        Console.Write("\t\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
                int rc = dt.Columns.Count;

                for (int r = 0; r < rc; r++)
                {
                    for (int c = 0; c < cc; c++)
                    {
                        Console.Write(dt.Rows[r][c] + "\t");
                    }
                    Console.WriteLine();
                }
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

