using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace KASA_EVSHOP
{
    class OLEDB_BAGLANTI
    {
        public OleDbConnection baglanti()
        {
            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");
            bag.Open();
            return bag;
        }
    }
}
