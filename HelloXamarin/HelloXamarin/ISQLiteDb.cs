using SQLite;

namespace HelloXamarin
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection(string databaseName);
    }
}

