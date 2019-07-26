using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace XF.Facilista.Config
{
    class DBHelper
    {
        string db = "/data/data/SpecDroid.SpecDroid/databases/eng.sqlite";
        string rootDbPath = "/data/data/SpecDroid.SpecDroid/eng.sqlite";

        private static string DB_PATH = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        private static string DB_NAME = "mock_data.db";
        private static int VERSION = 1;

        public bool GetSQLiteDBPath(Stream streamSQLite, FileStream streamWriter)
        {

                try
            {
                bool isSuccess = false;
                int lenght = 256;
                Byte[] buffer = new Byte[lenght];
                try
                {
                    int bytesRead = streamSQLite.Read(buffer, 0, lenght);
                    while (bytesRead > 0)
                    {
                        streamWriter.Write(buffer, 0, bytesRead);
                        bytesRead = streamSQLite.Read(buffer, 0, lenght);
                    }
                    isSuccess = true;
                }
                catch { }
                finally
                {
                    streamSQLite.Close();
                    streamWriter.Close();
                }
                return isSuccess;
            }
            catch { }

            return false;
        }

    }
}
