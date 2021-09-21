using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace hastaneotomasyon
{
    class sql_baglantısı
    {
        public SqlConnection baglanti()
        {
           SqlConnection baglan = new SqlConnection("Data Source=NIRVANA;Initial Catalog=hastaneproje;Integrated Security=True");
           baglan.Open();
           return baglan;
         }
    }
}
