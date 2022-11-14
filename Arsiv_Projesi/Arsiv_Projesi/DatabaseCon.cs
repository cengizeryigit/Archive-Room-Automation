using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsiv_Projesi
{
    class DatabaseCon
    {
       
        public static SqlConnection conn =  new SqlConnection("Data Source=302-07;Initial Catalog=Arsiv_Projesi;User ID=WebMobile_302;Password=webmobile.302");
        //public static SqlConnection conn = new SqlConnection("Data Source = CENGIZ\\SQLEXPRESS; Initial Catalog = Proje_Arsiv; User ID = sa; Password=123456789");
    }
}
