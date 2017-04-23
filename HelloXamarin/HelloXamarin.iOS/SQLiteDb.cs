using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using HelloXamarin.iOS;

[assembly: Dependency(typeof(SQLiteDb))]

namespace HelloXamarin.iOS
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection(string databaseName)
        {
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); 
            var path = Path.Combine(documentsPath, databaseName);
            return new SQLiteAsyncConnection(path);
        }
    }
}

