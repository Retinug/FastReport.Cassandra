namespace FastReport.Data
{
  partial class CassandraConnectionEditor
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.gbAuthentication = new System.Windows.Forms.GroupBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblKeyspace = new System.Windows.Forms.Label();
            this.tbKeyspace = new System.Windows.Forms.TextBox();
            this.label1 = new FastReport.Controls.LabelLine();
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.lblContactPoint = new System.Windows.Forms.Label();
            this.tbContactPoint = new System.Windows.Forms.TextBox();
            this.lblClusterName = new System.Windows.Forms.Label();
            this.tbClusterName = new System.Windows.Forms.TextBox();
            this.gbAuthentication.SuspendLayout();
            this.gbServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdvanced.AutoSize = true;
            this.btnAdvanced.Location = new System.Drawing.Point(251, 234);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(77, 23);
            this.btnAdvanced.TabIndex = 5;
            this.btnAdvanced.Text = "Advanced...";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // gbAuthentication
            // 
            this.gbAuthentication.Controls.Add(this.tbUserName);
            this.gbAuthentication.Controls.Add(this.lblPassword);
            this.gbAuthentication.Controls.Add(this.lblUserName);
            this.gbAuthentication.Controls.Add(this.tbPassword);
            this.gbAuthentication.Location = new System.Drawing.Point(8, 157);
            this.gbAuthentication.Name = "gbAuthentication";
            this.gbAuthentication.Size = new System.Drawing.Size(320, 71);
            this.gbAuthentication.TabIndex = 1;
            this.gbAuthentication.TabStop = false;
            this.gbAuthentication.Text = "Authentication";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(120, 19);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(188, 20);
            this.tbUserName.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 47);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 22);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(62, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User name:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(120, 43);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(188, 20);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblKeyspace
            // 
            this.lblKeyspace.AutoSize = true;
            this.lblKeyspace.Location = new System.Drawing.Point(9, 63);
            this.lblKeyspace.Name = "lblKeyspace";
            this.lblKeyspace.Size = new System.Drawing.Size(57, 13);
            this.lblKeyspace.TabIndex = 3;
            this.lblKeyspace.Text = "Keyspace:";
            // 
            // tbKeyspace
            // 
            this.tbKeyspace.Location = new System.Drawing.Point(12, 79);
            this.tbKeyspace.Name = "tbKeyspace";
            this.tbKeyspace.Size = new System.Drawing.Size(296, 20);
            this.tbKeyspace.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 17);
            this.label1.TabIndex = 2;
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.lblContactPoint);
            this.gbServer.Controls.Add(this.tbContactPoint);
            this.gbServer.Controls.Add(this.lblKeyspace);
            this.gbServer.Controls.Add(this.lblClusterName);
            this.gbServer.Controls.Add(this.tbKeyspace);
            this.gbServer.Controls.Add(this.tbClusterName);
            this.gbServer.Location = new System.Drawing.Point(8, 4);
            this.gbServer.Name = "gbServer";
            this.gbServer.Size = new System.Drawing.Size(320, 147);
            this.gbServer.TabIndex = 3;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "Server";
            // 
            // lblContactPoint
            // 
            this.lblContactPoint.AutoSize = true;
            this.lblContactPoint.Location = new System.Drawing.Point(9, 102);
            this.lblContactPoint.Name = "lblContactPoint";
            this.lblContactPoint.Size = new System.Drawing.Size(76, 13);
            this.lblContactPoint.TabIndex = 6;
            this.lblContactPoint.Text = "Contact point:";
            // 
            // tbContactPoint
            // 
            this.tbContactPoint.Location = new System.Drawing.Point(12, 118);
            this.tbContactPoint.Name = "tbContactPoint";
            this.tbContactPoint.Size = new System.Drawing.Size(296, 20);
            this.tbContactPoint.TabIndex = 2;
            // 
            // lblClusterName
            // 
            this.lblClusterName.AutoSize = true;
            this.lblClusterName.Location = new System.Drawing.Point(9, 24);
            this.lblClusterName.Name = "lblClusterName";
            this.lblClusterName.Size = new System.Drawing.Size(74, 13);
            this.lblClusterName.TabIndex = 4;
            this.lblClusterName.Text = "Cluster name:";
            // 
            // tbClusterName
            // 
            this.tbClusterName.Location = new System.Drawing.Point(12, 40);
            this.tbClusterName.Name = "tbClusterName";
            this.tbClusterName.Size = new System.Drawing.Size(296, 20);
            this.tbClusterName.TabIndex = 0;
            // 
            // CassandraConnectionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbAuthentication);
            this.Controls.Add(this.btnAdvanced);
            this.Name = "CassandraConnectionEditor";
            this.Size = new System.Drawing.Size(336, 283);
            this.gbAuthentication.ResumeLayout(false);
            this.gbAuthentication.PerformLayout();
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnAdvanced;
    private System.Windows.Forms.GroupBox gbAuthentication;
    private System.Windows.Forms.Label lblKeyspace;
    private System.Windows.Forms.TextBox tbPassword;
    private System.Windows.Forms.TextBox tbUserName;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.Label lblUserName;
    private FastReport.Controls.LabelLine label1;
    private System.Windows.Forms.GroupBox gbServer;
    private System.Windows.Forms.Label lblClusterName;
    private System.Windows.Forms.TextBox tbClusterName;
    private System.Windows.Forms.TextBox tbKeyspace;
        private System.Windows.Forms.Label lblContactPoint;
        private System.Windows.Forms.TextBox tbContactPoint;
    }
}
