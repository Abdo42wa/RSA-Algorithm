using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_Algorithm
{
    class SQL
    {
        string conn = "Data Source = DESKTOP-V6NNKDQ; Initial Catalog=RSA; Integrated Security=True";

        public void InsertValues(string text, BigInteger e, BigInteger n)
        {

            try
            {

                string mySQL = string.Empty;

                mySQL += "INSERT INTO RsaData (text, E, N)";

                mySQL += "VALUES (@text,@e,@n)";

                Console.WriteLine("TEXT - > {0}, E - > {1}, N - > {2}", text, e, n);
                SqlConnection sql = new SqlConnection(conn);
                sql.Open();
                SqlCommand sqlCom = new SqlCommand(mySQL, sql);
                sqlCom.Parameters.AddWithValue("@text", text);
                sqlCom.Parameters.AddWithValue("@e", e.ToString());
                sqlCom.Parameters.AddWithValue("@n", n.ToString());

                sqlCom.ExecuteNonQuery();
                sql.Close();
                Console.WriteLine("Crypted Data successfuly inserted into database !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(" dataBase: {0}", ex);
            }
        }
    }
}
