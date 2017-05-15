namespace TreeView_DataMining_Hierarchy
{
    partial class TreeViewDataMiningHierarchy
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.serverName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.databaseName = new System.Windows.Forms.TextBox();
            this.dataMiningQuery = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataMiningHierarchyTreeView = new System.Windows.Forms.TreeView();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.runQuery = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.miningModelName = new System.Windows.Forms.TextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server name";
            // 
            // serverName
            // 
            this.serverName.Location = new System.Drawing.Point(86, 10);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(107, 20);
            this.serverName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database name";
            // 
            // databaseName
            // 
            this.databaseName.Location = new System.Drawing.Point(348, 10);
            this.databaseName.Name = "databaseName";
            this.databaseName.Size = new System.Drawing.Size(206, 20);
            this.databaseName.TabIndex = 1;
            // 
            // dataMiningQuery
            // 
            this.dataMiningQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataMiningQuery.Location = new System.Drawing.Point(3, 16);
            this.dataMiningQuery.Multiline = true;
            this.dataMiningQuery.Name = "dataMiningQuery";
            this.dataMiningQuery.ReadOnly = true;
            this.dataMiningQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dataMiningQuery.Size = new System.Drawing.Size(1086, 43);
            this.dataMiningQuery.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataMiningHierarchyTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.resultsDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1092, 671);
            this.splitContainer1.SplitterDistance = 364;
            this.splitContainer1.TabIndex = 6;
            // 
            // dataMiningHierarchyTreeView
            // 
            this.dataMiningHierarchyTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataMiningHierarchyTreeView.Location = new System.Drawing.Point(0, 0);
            this.dataMiningHierarchyTreeView.Name = "dataMiningHierarchyTreeView";
            this.dataMiningHierarchyTreeView.Size = new System.Drawing.Size(364, 671);
            this.dataMiningHierarchyTreeView.TabIndex = 0;
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.AllowUserToAddRows = false;
            this.resultsDataGridView.AllowUserToDeleteRows = false;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.resultsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.ReadOnly = true;
            this.resultsDataGridView.Size = new System.Drawing.Size(724, 671);
            this.resultsDataGridView.TabIndex = 5;
            // 
            // runQuery
            // 
            this.runQuery.Location = new System.Drawing.Point(964, 8);
            this.runQuery.MaximumSize = new System.Drawing.Size(118, 23);
            this.runQuery.Name = "runQuery";
            this.runQuery.Size = new System.Drawing.Size(118, 23);
            this.runQuery.TabIndex = 3;
            this.runQuery.Text = "Run Query";
            this.runQuery.UseVisualStyleBackColor = true;
            this.runQuery.Click += new System.EventHandler(this.runQuery_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataMiningQuery);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1092, 62);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(1, 37);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1092, 737);
            this.splitContainer2.SplitterDistance = 62;
            this.splitContainer2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mining Model";
            // 
            // miningModelName
            // 
            this.miningModelName.Location = new System.Drawing.Point(688, 10);
            this.miningModelName.Name = "miningModelName";
            this.miningModelName.Size = new System.Drawing.Size(259, 20);
            this.miningModelName.TabIndex = 11;
            // 
            // TreeViewDataMiningHierarchy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 774);
            this.Controls.Add(this.miningModelName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.runQuery);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.databaseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverName);
            this.Controls.Add(this.label1);
            this.Name = "TreeViewDataMiningHierarchy";
            this.Text = "TreeView  over a DataMining Hierarchy";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox databaseName;
        private System.Windows.Forms.TextBox dataMiningQuery;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView dataMiningHierarchyTreeView;
        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.Button runQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox miningModelName;
    }
}

