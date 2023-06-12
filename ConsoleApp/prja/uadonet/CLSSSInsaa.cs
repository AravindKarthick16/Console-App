using System;
using System.Data.SqlClient;


namespace prja.uadonet
{
    class CLSSSInsaa
    {
       public static void Main()
       {
            SqlConnection sqlcnn = null;
            SqlCommand sqlcmd = null;

            string qryIns = null, ename = null, salary = null;
            try
            {
                qryIns = "insert into ematbl";
                qryIns += " (ename, salary)values";
                qryIns += " (@ename, @salary);";

                Console.WriteLine("\nEmployee Salary Allowances for make a row");
                Console.Write("\nName: ");
                ename = Console.ReadLine();

                Console.Write("\nSalary: ");
                salary = Console.ReadLine();

                sqlcnn = new SqlConnection(CLSSSCnStr.cnStr);
                sqlcnn.Open();

                sqlcmd = new SqlCommand(qryIns, sqlcnn);
                sqlcmd.Parameters.AddWithValue("@ename", ename);
                sqlcmd.Parameters.AddWithValue("@salary", salary);

                int afrs = sqlcmd.ExecuteNonQuery();

                if (afrs > 0)
                {
                    Console.WriteLine("\nAffected 1 row");
                }else
                {
                    Console.WriteLine("\nAffected 0 row");
                }

            }catch(Exception e)
            {
                Console.WriteLine("Err.:" + e.Message);
            }finally
            {
                sqlcnn.Close();
            }
       }
    }
}
