using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using HelloXamarin.Windows;
using Windows.Storage;

[assembly: Dependency(typeof(SQLiteDb))]

namespace HelloXamarin.Windows
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection(string databaseName)
        {
			var documentsPath = ApplicationData.Current.LocalFolder.Path;
        	var path = Path.Combine(documentsPath, databaseName);
        	return new SQLiteAsyncConnection(path);
        }
    }
}

