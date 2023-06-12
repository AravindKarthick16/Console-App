using System;
using System.Data.SqlClient;

namespace prja.uadonet
{
    class CLSSSUpdaa
    {
        public static void Main()
        {
            SqlConnection sqlcnn = null;
            SqlCommand sqlcmd = null;

            string qryUpd = null, eid=null, ename = null, salary = null;
            try
            {
                qryUpd = "update ematbl set";
                qryUpd += " ename=@ename,";
                qryUpd += " salary=@salary";
                qryUpd += " where eid=@eid";

                Console.WriteLine("\nEmployee Salary Allowances for modify a row");
                Console.Write("\nID: ");
                eid = Console.ReadLine();

                Console.Write("\nName: ");
                ename = Console.ReadLine();

                Console.Write("\nSalary: ");
                salary = Console.ReadLine();

                sqlcnn = new SqlConnection(CLSSSCnStr.cnStr);
                sqlcnn.Open();

                sqlcmd = new SqlCommand(qryUpd, sqlcnn);
                sqlcmd.Parameters.AddWithValue("@eid", eid);
                sqlcmd.Parameters.AddWithValue("@ename", ename);
                sqlcmd.Parameters.AddWithValue("@salary", salary);

                int afrs = sqlcmd.ExecuteNonQuery();

                if (afrs > 0)
                {
                    Console.WriteLine("\nAffected 1 row");
                }
                else
                {
                    Console.WriteLine("\nAffected 0 row");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Err.:" + e.Message);
            }
            finally
            {
                sqlcnn.Close();
            }
        }
    }
}
