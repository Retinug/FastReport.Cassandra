using System;
using System.Windows.Forms;
using FastReport.Data.ConnectionEditors;
using FastReport.Forms;
using Cassandra;

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
			//gbServer.Text =;
			//lblClusterName.Text =;
			//lblKeyspace.Text =;
			//lblContactPoint.Text =;

			//gbAuthentication.Text =;
			//lblUserName.Text =;
			//lblPassword.Text =;
			//btnAdvanced.Text =;
		}

		protected override string GetConnectionString()
		{
			CassandraConnectionStringBuilder builder = new CassandraConnectionStringBuilder(FConnectionString);

			builder.ClusterName = tbClusterName.Text;
			builder.DefaultKeyspace = tbKeyspace.Text;
			builder.ContactPoints = new string[1] { tbContactPoint.Text };
			builder.Username = tbUserName.Text;
			builder.Password = tbPassword.Text;

			return builder.ToString();
		}

		protected override void SetConnectionString(string value)
		{
			FConnectionString = value;

			CassandraConnectionStringBuilder builder = new CassandraConnectionStringBuilder(value);

			tbClusterName.Text = builder.ClusterName;
			tbKeyspace.Text = builder.DefaultKeyspace;
			try
			{
				tbContactPoint.Text = builder.ContactPoints[0];
			}
			catch
			{
				tbContactPoint.Text = "";
			}

			tbUserName.Text = builder.Username;
			tbPassword.Text = builder.Password;
			
		}

		public CassandraConnectionEditor()
		{
			InitializeComponent();
			Localize();
		}
	}
}
