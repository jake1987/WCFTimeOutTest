﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AskeyB2BService.WebTest.B2BTestDBService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="B2BTestDBService.IB2BDBService")]
    public interface IB2BDBService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IB2BDBService/ExecuteSqlTran", ReplyAction="http://tempuri.org/IB2BDBService/ExecuteSqlTranResponse")]
        bool ExecuteSqlTran(System.Collections.Generic.List<string> SQLStringList);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IB2BDBService/ExecuteNonQuery", ReplyAction="http://tempuri.org/IB2BDBService/ExecuteNonQueryResponse")]
        int ExecuteNonQuery(string cmdText);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IB2BDBService/ExecuteNonQueryWithParams", ReplyAction="http://tempuri.org/IB2BDBService/ExecuteNonQueryWithParamsResponse")]
        int ExecuteNonQueryWithParams(System.Data.CommandType cmdType, string cmdText, System.Collections.Generic.List<Oracle.ManagedDataAccess.Client.OracleParameter> commandParameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IB2BDBService/Query", ReplyAction="http://tempuri.org/IB2BDBService/QueryResponse")]
        System.Data.DataTable Query(string SQLString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IB2BDBService/QueryWithParams", ReplyAction="http://tempuri.org/IB2BDBService/QueryWithParamsResponse")]
        System.Data.DataTable QueryWithParams(string SQLString, System.Collections.Generic.List<Oracle.ManagedDataAccess.Client.OracleParameter> cmdParms);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IB2BDBService/ExecuteScalar", ReplyAction="http://tempuri.org/IB2BDBService/ExecuteScalarResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Data.CommandType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Data.DbType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Data.ParameterDirection))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Data.DataRowVersion))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<Oracle.ManagedDataAccess.Client.OracleParameter>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Oracle.ManagedDataAccess.Client.OracleParameter))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<Oracle.ManagedDataAccess.Client.OracleParameterStatus>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Oracle.ManagedDataAccess.Client.OracleParameterStatus))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Oracle.ManagedDataAccess.Client.OracleCollectionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Oracle.ManagedDataAccess.Client.OracleDbType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Data.Common.DbParameter))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.MarshalByRefObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<string>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<int>))]
        object ExecuteScalar(string SQLString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IB2BDBService/ExecuteScalarWithParams", ReplyAction="http://tempuri.org/IB2BDBService/ExecuteScalarWithParamsResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Data.CommandType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Data.DbType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Data.ParameterDirection))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Data.DataRowVersion))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<Oracle.ManagedDataAccess.Client.OracleParameter>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Oracle.ManagedDataAccess.Client.OracleParameter))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<Oracle.ManagedDataAccess.Client.OracleParameterStatus>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Oracle.ManagedDataAccess.Client.OracleParameterStatus))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Oracle.ManagedDataAccess.Client.OracleCollectionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Oracle.ManagedDataAccess.Client.OracleDbType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Data.Common.DbParameter))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.MarshalByRefObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<string>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<int>))]
        object ExecuteScalarWithParams(string SQLString, System.Collections.Generic.List<Oracle.ManagedDataAccess.Client.OracleParameter> cmdParms);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IB2BDBServiceChannel : AskeyB2BService.WebTest.B2BTestDBService.IB2BDBService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class B2BDBServiceClient : System.ServiceModel.ClientBase<AskeyB2BService.WebTest.B2BTestDBService.IB2BDBService>, AskeyB2BService.WebTest.B2BTestDBService.IB2BDBService {
        
        public B2BDBServiceClient() {
        }
        
        public B2BDBServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public B2BDBServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public B2BDBServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public B2BDBServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool ExecuteSqlTran(System.Collections.Generic.List<string> SQLStringList) {
            return base.Channel.ExecuteSqlTran(SQLStringList);
        }
        
        public int ExecuteNonQuery(string cmdText) {
            return base.Channel.ExecuteNonQuery(cmdText);
        }
        
        public int ExecuteNonQueryWithParams(System.Data.CommandType cmdType, string cmdText, System.Collections.Generic.List<Oracle.ManagedDataAccess.Client.OracleParameter> commandParameters) {
            return base.Channel.ExecuteNonQueryWithParams(cmdType, cmdText, commandParameters);
        }
        
        public System.Data.DataTable Query(string SQLString) {
            return base.Channel.Query(SQLString);
        }
        
        public System.Data.DataTable QueryWithParams(string SQLString, System.Collections.Generic.List<Oracle.ManagedDataAccess.Client.OracleParameter> cmdParms) {
            return base.Channel.QueryWithParams(SQLString, cmdParms);
        }
        
        public object ExecuteScalar(string SQLString) {
            return base.Channel.ExecuteScalar(SQLString);
        }
        
        public object ExecuteScalarWithParams(string SQLString, System.Collections.Generic.List<Oracle.ManagedDataAccess.Client.OracleParameter> cmdParms) {
            return base.Channel.ExecuteScalarWithParams(SQLString, cmdParms);
        }
    }
}