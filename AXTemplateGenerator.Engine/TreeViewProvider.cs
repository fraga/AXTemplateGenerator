using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AXTemplateGenerator.CommonTypes;

namespace AXTemplateGenerator.Engine
{
    public class TreeViewProvider
    {
        public static void GenerateTreeView(dynamic client, System.Windows.Forms.TreeView treeNodeView)
        {
            if(client != null && treeNodeView != null)
            {
                try
                {
                    string[] tables = client.GetTableNames();

                    foreach (var table in tables)
                    {
                        treeNodeView.TopNode.Nodes["DataDictionary"].Nodes["Tables"].Nodes.Add(new TreeNode(table));
                    }

                    string[] classes = client.GetClassNames();

                    foreach (var @class in classes)
                    {
                        treeNodeView.TopNode.Nodes["Classes"].Nodes.Add(new TreeNode(@class));
                    }


                    string[] edts = client.GetExtendedDataTypeNames();

                    foreach (var edt in edts)
                    {
                        treeNodeView.TopNode.Nodes["DataDictionary"].Nodes["EDT"].Nodes.Add(new TreeNode(edt));
                    }

                    string[] enums = client.GetEnumNames();

                    foreach (var @enum in enums)
                    {
                        treeNodeView.TopNode.Nodes["DataDictionary"].Nodes["BaseEnums"].Nodes.Add(new TreeNode(@enum));
                    }

                    string[] queries = client.GetQueryNames();

                    foreach (var query in queries)
                    {
                        treeNodeView.TopNode.Nodes["Queries"].Nodes.Add(new TreeNode(query));
                    }

                    string[] services = client.GetServiceNames();

                    foreach (var service in services)
                    {
                        treeNodeView.TopNode.Nodes["Services"].Nodes.Add(new TreeNode(service));
                    }

                    string[] forms = client.GetFormPartNames();

                    foreach (var form in forms)
                    {
                        treeNodeView.TopNode.Nodes["Forms"].Nodes.Add(new TreeNode(form));
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
    }
}
