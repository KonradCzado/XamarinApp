using SQLite;
using System;
using System.Collections.Generic;
using System.Text;



namespace App3.Resources
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
