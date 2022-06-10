using SQlite;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Net_swag;


namespace Net_swag_ordering_app
{
    public class SwagDatabase
    {
      private SQliteConnection_database;

      public static SwagDatabase Instance = new SwagDatabase();
      
     public SwagDatabase()
     {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocaApplicationData);
           
            string filePath = Path.Combine(path, "swagdata.db");
            _database = new SQliteConnection(filePath, SQliteOpenFlags.Readwrite | SQliteOpenFlags.Create | SQLiteOpenFlags.SharedCache);
            
            _database.CreateTable<SwagItem>();
       
     }
        public List<SwagItem> GetSwagItem()
        {
            return_database.Table<SwagItem>().ToList();

        }

    }
}
