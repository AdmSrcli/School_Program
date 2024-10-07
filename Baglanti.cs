using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BonusOkul
{
    internal class Baglanti
    {
        public string Adres = System.IO.File.ReadAllText(@"C:\\Adres\\OkulAdres.txt");

        
    }
}
