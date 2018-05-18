using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using AskeyB2BService.DBUtility;
using Oracle.ManagedDataAccess.Client;

namespace AskeyB2BService.WCF
{
    public class B2BDBService : IB2BDBService
    {
        public bool ExecuteSqlTran(List<String> SQLStringList)
        {
            bool b = false;
            try
            {
                b = OracleHelper.ExecuteSqlTran(OracleHelper.B2BConnection, SQLStringList);
            }
            catch
            { 
                
            }
            return b;
        }

        public int ExecuteNonQuery(string cmdText)
        {
            int count = 0;
            try
            {
                count = OracleHelper.ExecuteNonQuery(OracleHelper.B2BConnection, cmdText);
            }
            catch
            {

            }
            return count;
        }

        public int ExecuteNonQueryWithParams(CommandType cmdType, string cmdText, params Oracle.ManagedDataAccess.Client.OracleParameter[] commandParameters)
        {
            int count = 0;
            try
            {
                count = OracleHelper.ExecuteNonQuery(OracleHelper.B2BConnection, CommandType.Text, cmdText, commandParameters);
            }
            catch (Exception ex)
            {
                
            }
            return count;
        }

        public DataTable Query(string SQLString)
        {
            DataTable dt = new DataTable();
            try
            {
                DataSet ds = OracleHelper.Query(OracleHelper.B2BConnection, SQLString);
                if (ds != null && ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {

            }
            return dt;
        }

        public DataTable QueryWithParams(string SQLString, params Oracle.ManagedDataAccess.Client.OracleParameter[] cmdParms)
        {
            DataTable dt = new DataTable();
            try
            {
                DataSet ds = OracleHelper.Query(OracleHelper.B2BConnection, SQLString,cmdParms);
                if (ds != null && ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {

            }
            return dt;
        }


        public object ExecuteScalar(string SQLString)
        {
            object o = new object();
            try
            {
                o = OracleHelper.GetSingle(OracleHelper.B2BConnection, SQLString);
            }
            catch
            {
                
            }
            return o;
        }

        public object ExecuteScalarWithParams(string SQLString, params Oracle.ManagedDataAccess.Client.OracleParameter[] cmdParms)
        {
            object o = new object();
            try
            {
                o = OracleHelper.GetSingle(OracleHelper.B2BConnection, SQLString,cmdParms);
            }
            catch
            {

            }
            return o; 
        }
    }
}
