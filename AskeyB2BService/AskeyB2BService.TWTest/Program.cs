using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using AskeyB2BService.Common;


namespace AskeyB2BService.TWTest
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
            Console.WriteLine("WCF Total time:" + time.ToString());


            SqlHelper.Service service = new SqlHelper.Service();
            List<string> sqlList1 = new List<string>();
            for (int j = 0; j < 20000; j++)
            {
                sqlList1.Add("INSERT INTO TB_TEST (ID,NAME) VALUES (" + j.ToString() + ",'AAAA" + j.ToString() + "')");
            }
            string[] arrSql = new string[sqlList1.Count];
            sqlList1.CopyTo(arrSql);
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            bool b1 = service.ExecuteSqlTran(arrSql);
            sw1.Stop();
            long time1 = sw1.ElapsedMilliseconds;
            Console.WriteLine("Web Service Total time:" + time1.ToString());
            Console.ReadLine();
        }
    }
}
