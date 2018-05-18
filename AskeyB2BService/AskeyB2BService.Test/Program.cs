using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using AskeyB2BService.Common;

namespace AskeyB2BService.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            B2BDBService.B2BDBServiceClient client = new B2BDBService.B2BDBServiceClient();
            List<string> sqlList = new List<string>();
            for (int i = 0; i < 20000; i++)
            {
                sqlList.Add("INSERT INTO TB_TEST (ID,NAME) VALUES (" + i.ToString() + ",'AAAA" + i.ToString() + "')");
            }
            Stopwatch sw = new Stopwatch();
            sw.Start();
            bool b = client.ExecuteSqlTran(sqlList);
            sw.Stop();
            long time = sw.ElapsedMilliseconds;
            Console.WriteLine("Total time:" + time.ToString());
            Console.ReadLine();
        }
    }
}
