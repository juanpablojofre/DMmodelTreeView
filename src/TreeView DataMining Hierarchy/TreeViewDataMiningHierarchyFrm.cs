using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using adomd = Microsoft.AnalysisServices.AdomdClient;

namespace TreeView_DataMining_Hierarchy
{
    public partial class TreeViewDataMiningHierarchy : Form
    {
        DataTable resultsTable = new DataTable();
        public TreeViewDataMiningHierarchy()
        {
            InitializeComponent();
        }

        private void runQuery_Click(object sender, EventArgs e)
        {
            #region Validation Section
            if (   string.IsNullOrEmpty(serverName.Text) || string.IsNullOrEmpty(databaseName.Text ) || string.IsNullOrEmpty(miningModelName.Text))
            {
                MessageBox.Show(string.Format("'Server name' and 'Database name' and 'Query' fields must not be empty."), "ERROR: TreeView  over a DataMining Hierarchy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            adomd.AdomdConnection cnx = new adomd.AdomdConnection(string.Format("Data Source={0};Catalog={1}", serverName.Text, databaseName.Text));
            try
            {
                cnx.Open();
            }
            catch (Exception cnxException)
            {
                MessageBox.Show(string.Format("Connection to Database '[{0}].[{1}]' Failed!\nError message: {2}", serverName.Text, databaseName.Text, cnxException.Message), "ERROR: TreeView  over a DataMining Hierarchy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cnx.Close();
                return;
            }
            if (cnx.State != ConnectionState.Open)
            {
                MessageBox.Show(string.Format("Connection to Database '[{0}].[{1}]' Failed!\nConnection state is {2}", serverName.Text, databaseName.Text, cnx.State), "ERROR: TreeView  over a DataMining Hierarchy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cnx.Close();
                return;
            }
            
            #endregion

            #region Build DMX Query
            miningModelName.Text = miningModelName.Text.Trim();
            if (miningModelName.Text.Substring(0, 1) == "[")
                miningModelName.Text = miningModelName.Text.Substring(1);
            if (miningModelName.Text.Substring(miningModelName.Text.Length - 1, 1) == "]")
                miningModelName.Text = miningModelName.Text.Substring(0, miningModelName.Text.Length - 1);
            dataMiningQuery.Text = string.Format("SELECT * from [{0}].content", miningModelName.Text);
            #endregion

            #region Clean Up Section
            if (resultsTable!=null)
                resultsTable.Clear();
            dataMiningHierarchyTreeView.Nodes.Clear();
            #endregion

            adomd.AdomdCommand qry = new adomd.AdomdCommand(dataMiningQuery.Text, cnx);
            adomd.AdomdDataAdapter resultsDataAdapter = new adomd.AdomdDataAdapter(dataMiningQuery.Text, cnx);

            resultsDataAdapter.Fill(resultsTable);//The structure of the table is described in DMSCHEMA_MINING_MODEL_CONTENT Rowset (http://msdn.microsoft.com/en-us/library/ms126267.aspx)

            cnx.Close();
            resultsDataGridView.DataSource = resultsTable;
            foreach (DataRow r in resultsTable.Select("PARENT_UNIQUE_NAME is null"))//Skip empty nodes in the model
            {
                foreach(DataRow d in resultsTable.Select(string.Format("PARENT_UNIQUE_NAME ='{0}'", r["NODE_UNIQUE_NAME"].ToString())))//These are the first level of nodes
                {
                    dataMiningHierarchyTreeView.Nodes.Add(getParentChildTree(d["NODE_UNIQUE_NAME"].ToString()));
                }
            }            
        }
        /// <summary>
        /// recursively build the tree node, depth-first
        /// </summary>
        /// <param name="parentId">top node NODE_UNIQUE_NAME</param>
        /// <returns>A node to be added to the TreeView control</returns>
        TreeNode getParentChildTree(string parentId)
        {
            DataRow parentInfo = resultsTable.Select(string.Format("NODE_UNIQUE_NAME ='{0}'", parentId))[0];
            #region Extract Parent Node display information
            double marginalProbability = 0;
            double.TryParse(parentInfo["MARGINAL_PROBABILITY"].ToString(), out marginalProbability);
            double nodeProbability = 0;
            double.TryParse(parentInfo["NODE_PROBABILITY"].ToString(), out nodeProbability);
            string nodeCaption = parentInfo["NODE_CAPTION"].ToString();
            string nodeName = parentInfo["NODE_UNIQUE_NAME"].ToString();
            #endregion
            TreeNode parent = new TreeNode(string.Format("[{0:00.00%} | {1:00.00%}] {2}:{3}", marginalProbability, nodeProbability, nodeName, nodeCaption));
            parent.Tag = nodeName;
            //Retrieve children nodes
            DataRow[] children = resultsTable.Select(string.Format("PARENT_UNIQUE_NAME ='{0}'", parentId));
            foreach (DataRow d in children)
            {
                parent.Nodes.Add(getParentChildTree(d["NODE_UNIQUE_NAME"].ToString()));
            }
            return parent;
        }
    }
}
