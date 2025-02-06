using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OgrencıSıstemı
{
    internal class sqlbaglantisi
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=localhost;Initial Catalog=dbo.OgrencıSıstemı;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }
    }
}
