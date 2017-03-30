using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using SQLite;

namespace Sednabank
{
    
    class DBHandler
    {
        

        const string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Docs\Documents\GitHub\WindowsPhoneApp\Documenten\KT2\W 2.1\Database.mdf;Integrated Security=True;Connect Timeout=30";

        static void CreateDB()
        {
            
        }

        static void Connect()
        {
            using (SQLiteConnection dbConn = new SQLiteConnection(conn))
            {
                SQLiteConnection.CreateFile("MyDatabase.sqlite");
            }
        }


    }
}
