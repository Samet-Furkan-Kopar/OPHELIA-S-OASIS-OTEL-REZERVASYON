﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace hotelOasis
{
    class Sql
    {
        public string Adres = System.IO.File.ReadAllText(@"C:\ADRES.txt");
        public SqlConnection baglanti()
        {

            SqlConnection baglan = new SqlConnection(Adres);
            baglan.Open();
            return baglan;

        }
    }
}
