using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace AskeyB2BService.WCF
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼和組態檔中的介面名稱 "IB2BDBService"。
    [ServiceContract]
    public interface IB2BDBService
    {
        [OperationContract]
        bool ExecuteSqlTran(List<String> SQLStringList);
        [OperationContract]
        int ExecuteNonQuery(string cmdText);
        [OperationContract]
        int ExecuteNonQueryWithParams(CommandType cmdType, string cmdText, params Oracle.ManagedDataAccess.Client.OracleParameter[] commandParameters);
        [OperationContract]
        DataTable Query(string SQLString);
        [OperationContract]
        DataTable QueryWithParams(string SQLString, params Oracle.ManagedDataAccess.Client.OracleParameter[] cmdParms);
        [OperationContract]
        object ExecuteScalar(string SQLString);
        [OperationContract]
        object ExecuteScalarWithParams(string SQLString, params Oracle.ManagedDataAccess.Client.OracleParameter[] cmdParms);
    }
}
