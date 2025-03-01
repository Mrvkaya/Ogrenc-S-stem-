﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrencıSıstemı
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmGiris());

            // The following code should be part of a method that executes SQL commands
            using (SqlConnection connection = new SqlConnection("Server=localhost;Database='dbo.OgrencıSıstemı';Integrated Security=True;"))
            {
                connection.Open();
                string query = "ALTER TABLE dbo.TBL_OGRETMEN ALTER COLUMN OGRTTEL VARCHAR(15);";
               using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
