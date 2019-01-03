using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ArcSoftFace.Utils
{
    public class DbUtil
    {
           public void Init()
        {
            string connetStr = "server=127.0.0.1;port=3306;user=root;password=1234; database=people;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();

            }
            catch(MySqlException e)
            {
                Console.WriteLine(e.ErrorCode);
            }
        }
    }
}