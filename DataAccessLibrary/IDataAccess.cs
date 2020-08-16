﻿using System.Collections.Generic;

namespace DataAccessLibrary
{
    public interface IDataAccess
    {
        List<T> LoadData<T, U>(string sql, U parameters, string connectionString);
        void SaveData<T>(string sql, T parameters, string connectionString);
    }
}