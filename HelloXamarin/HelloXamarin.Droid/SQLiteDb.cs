using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using HelloXamarin.Droid;

[assembly: Dependency(typeof(SQLiteDb))]

namespace HelloXamarin.Droid
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

