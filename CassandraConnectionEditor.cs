using System;
using System.Windows.Forms;
using FastReport.Data.ConnectionEditors;
using FastReport.Forms;
using Cassandra;
using Cassandra.Data;

namespace FastReport.Data
{
	public partial class CassandraConnectionEditor : ConnectionEditorBase
	{
		private string FConnectionString;

		private void btnAdvanced_Click(object sender, EventArgs e)
		{
			using (AdvancedConnectionPropertiesForm form = new AdvancedConnectionPropertiesForm())
			{
				CassandraConnectionStringBuilder builder = new CassandraConnectionStringBuilder(ConnectionString);
				form.AdvancedProperties = builder;
				if (form.ShowDialog() == DialogResult.OK)
				ConnectionString = form.AdvancedProperties.ToString();
			}
		}

		private void Localize()
		{
			//todo: localize
		}

		protected override string GetConnectionString()
		{
			CassandraConnectionStringBuilder builder = new CassandraConnectionStringBuilder(FConnectionString);

			builder.ClusterName = "Test cluster";
			builder.Username = "cassandra";
			builder.Password = "cassandra";
			builder.DefaultKeyspace = "emp";
			//builder.ClusterName = tbClusterName.Text;
			//builder.Username = tbUserName.Text;
			//builder.Password = tbPassword.Text;
			//builder.DefaultKeyspace = tbKeyspace.Text;

			builder.ContactPoints = new string[1] { "127.0.0.1" };
	  
			return builder.ToString();
		}

		protected override void SetConnectionString(string value)
		{
			FConnectionString = value;

			CassandraConnectionStringBuilder builder = new CassandraConnectionStringBuilder(value);

			tbClusterName.Text = "Test cluster";
			tbUserName.Text = "cassandra";
			tbPassword.Text = "cassandra";
			tbKeyspace.Text = "emp";

			//tbClusterName.Text = builder.ClusterName;
			//tbUserName.Text = builder.Username;
			//tbPassword.Text = builder.Password;
			//tbKeyspace.Text = builder.DefaultKeyspace;
		}

		public CassandraConnectionEditor()
		{
			InitializeComponent();
			Localize();
		}
	}
}
