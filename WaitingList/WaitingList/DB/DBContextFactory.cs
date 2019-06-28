using System;
using System.IO;
using System.Linq;

namespace WaitingList.Data
{
    class DBContextFactory // 쿼리문을 보기 위해서
    {
        private const string FilePath = @"d:\AB.log";

        private static readonly string[] PrefixList = { "SELECT", "INSERT", "UPDATE", "DELETE" };

        private static void Write(string log)
        {
            if (PrefixList.All(x => log.StartsWith(x) == false))
                return;

            string contents;

            if (File.Exists(FilePath))
                contents = File.ReadAllText(FilePath);
            else
                contents = "";

            string time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            string formattedLog = $"[{time}]\r\n{log}\r\n=============================\r\n\r\n";

            contents = formattedLog + contents;

            File.WriteAllText(FilePath, contents);
        }

        public static ChinookEntities Create()
        {
            ChinookEntities context = new ChinookEntities();

            context.Database.Log = Write; // 쿼리문

            return context;
        }
    }
}
