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

        public override void FillTableSchema(DataTable table, string selectCommand, CommandParameterCollection parameters)
        {
            //using (DbConnection conn = GetConnection())
            //{
            //    OpenConnection(conn);
            //    // prepare select command
            //    selectCommand = PrepareSelectCommand(selectCommand, table.TableName, conn);
            //    // read the table schema
            //    using (DbDataAdapter adapter = GetAdapter(selectCommand, conn, parameters))
            //    {
            //        adapter.SelectCommand.CommandTimeout = CommandTimeout;
            //        adapter.FillSchema(table, SchemaType.Source);
            //    }
            //}
            throw new Exception();
        }

        public override void FillTableData(DataTable table, string selectCommand, CommandParameterCollection parameters)
        {
            //using (DbConnection conn = GetConnection())
            //{
            //    OpenConnection(conn);
            //    // prepare select command
            //    selectCommand = PrepareSelectCommand(selectCommand, table.TableName, conn);
            //    // read the table
            //    using (DbDataAdapter adapter = GetAdapter(selectCommand, conn, parameters))
            //    {
            //        adapter.SelectCommand.CommandTimeout = CommandTimeout;
            //        table.Clear();
            //        adapter.Fill(table);
            //    }
            //}
            throw new Exception();
        }


        public override ConnectionEditorBase GetEditor()
        {
            return new CassandraConnectionEditor();
        }

    }
}
