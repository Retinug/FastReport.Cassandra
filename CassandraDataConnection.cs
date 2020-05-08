using System;
using System.Collections.Generic;
using System.Data.Common;
using FastReport.Data.ConnectionEditors;
using System.Data;
using Cassandra;
using Cassandra.Data;
using System.Linq;

namespace FastReport.Data
{
    public class CassandraDataConnection : DataConnectionBase
    {
        public override string[] GetTableNames()
        {
            CassandraConnectionStringBuilder builder = new CassandraConnectionStringBuilder(ConnectionString);
            
            Cluster cluster = Cluster.Builder().WithConnectionString(ConnectionString).Build();
            cluster.Connect(builder.DefaultKeyspace);
            
            List<string> tables = cluster.Metadata.GetTables(builder.DefaultKeyspace).ToList();
            cluster.Dispose();

            return tables.ToArray();
        }

        public override string QuoteIdentifier(string value, DbConnection connection)
        {
            return "\"" + value + "\"";
        }

        protected override string GetConnectionStringWithLoginInfo(string userName, string password)
        {
            CassandraConnectionStringBuilder builder = new CassandraConnectionStringBuilder(ConnectionString);

            builder.Username = userName;
            builder.Password = password;

            return builder.ToString();
        }

        public override Type GetConnectionType()
        {
            return typeof(CqlConnection);
        }

        public override Type GetParameterType()
        {
            return typeof(ColumnTypeCode);
        }

        public override string GetConnectionId()
        {
            CassandraConnectionStringBuilder builder = new CassandraConnectionStringBuilder(ConnectionString);
            string info = "";
            try
            {
                info = builder.ClusterName;
            }
            catch
            {
            }
            return "Cassandra: " + info;
        }

        public override DbDataAdapter GetAdapter(string selectCommand, DbConnection connection, CommandParameterCollection parameters)
        {
            CqlDataAdapter adapter = new CqlDataAdapter();
            adapter.SelectCommand = new CqlCommand();
            adapter.SelectCommand.Connection = connection;
            adapter.SelectCommand.CommandText = selectCommand;
            foreach (DbParameter p in parameters)
            {
                CqlParameter parameter = new CqlParameter(p.ParameterName, p.Value);
                adapter.SelectCommand.Parameters.Add(parameter);
            }
            return adapter;
        }

        public override void FillTableSchema(DataTable table, string selectCommand, CommandParameterCollection parameters)
        {
            CassandraConnectionStringBuilder builder = new CassandraConnectionStringBuilder(ConnectionString);

            using(DbConnection connection = GetConnection())
            {
                OpenConnection(connection);
                selectCommand = $"select * from {builder.DefaultKeyspace}.{table.TableName}";

                using(DbDataAdapter adapter = GetAdapter(selectCommand, connection, parameters))
                {
                    adapter.SelectCommand.CommandTimeout = CommandTimeout;
                    adapter.Fill(table);
                }
            }
        }


        public override ConnectionEditorBase GetEditor()
        {
            return new CassandraConnectionEditor();
        }

    }
}
