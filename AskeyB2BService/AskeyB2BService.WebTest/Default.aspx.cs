using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace AskeyB2BService.WebTest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            B2BTestDBService.B2BDBServiceClient client = new B2BTestDBService.B2BDBServiceClient();

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
        }
    }
}