using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_B
{
    class Class1
    {
        public SqlConnection con;

        public void Connection()
        {
            con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\dvide\OneDrive\Documenten\Data.mdf; Integrated Security = True; Connect Timeout = 30");
        }
    }
}
