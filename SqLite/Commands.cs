// MIT License
// 
// Copyright (c) 2018 reapler https://github.com/reapler
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using robotManager.Helpful;


namespace DatabaseManager.SqLite
{
    /// <summary>
    /// Internal usage
    /// </summary>
    internal class Commands
    {
        public static IEnumerable<DataRow> Get(string commandText)
        {
            try
            {
                DataTable data = new DataTable();
                Data.Connection.Open();
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(commandText, Data.Connection))
                {
                    adapter.AcceptChangesDuringUpdate = false;
                    adapter.Fill(data);
                }
                Data.Connection.Close();
                return data.Rows.Cast<DataRow>();
            }
            catch (Exception e)
            {
                Logging.WriteError("[WoWDb] " + System.Reflection.MethodBase.GetCurrentMethod().Name + " error:" +
                                   Utilities.Logging.ErrorData +
                                   "\nThrowed exception:\n" + e);
                return null;
            }
        }
        
        public static int Execute(string commandText)
        {
            try
            {
                Data.Connection.Open();
                int ret;
                using (var command = new SQLiteCommand(commandText, Data.Connection))
                {

                    ret = command.ExecuteNonQuery();
                }
                Data.Connection.Close();
                return ret;
            }
            catch (Exception e)
            {
                Logging.WriteError("[WoWDb] " + System.Reflection.MethodBase.GetCurrentMethod().Name + " error:" +
                                   Utilities.Logging.ErrorData +
                                   "\nThrowed exception:\n" + e);
                return 0;
            }
        }

        public static Task<int> ExecuteAsync(string commandText)
        {
            try
            {
                Data.Connection.Open();
                Task<int> task;
                using (var command = new SQLiteCommand(commandText, Data.Connection))
                {
                    task = command.ExecuteNonQueryAsync();
                }
                Data.Connection.Close();
                return task;
            }
            catch (Exception e)
            {
                Logging.WriteError("[WoWDb] " + System.Reflection.MethodBase.GetCurrentMethod().Name + " error:" +
                                   Utilities.Logging.ErrorData +
                                   "\nThrowed exception:\n" + e);
                return null;
            }
        }

        public static List<string> GetTableNames()
        {
            try
            {
                List<string> tables = new List<string>();
                Data.Connection.Open();
                DataTable data = Data.Connection.GetSchema("Tables");
                foreach (DataRow row in data.Rows)
                {
                    tables.Add((string) row[2]);
                }
                Data.Connection.Close();
                return tables;
            }
            catch (Exception e)
            {
                Logging.WriteError("[WoWDb] " + System.Reflection.MethodBase.GetCurrentMethod().Name + " error:" +
                                   Utilities.Logging.ErrorData +
                                   "\nThrowed exception:\n" + e);
                return new List<string>();
            }
        }
        
        public static bool TableDefined(string tableName)
        {
            return GetTableNames().Contains(tableName);
        }
    }
}









