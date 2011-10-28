using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
using AXTemplateGenerator.Engine;
using AXTemplateGenerator.Forms.AX.AIF.SystemServices;

namespace AXTemplateGenerator.Forms
{
    public partial class TreeView : Form
    {
        private AxMetadataServiceClient _client;
        public TreeView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeTreeView();

            if (this.AOTTreeView != null)
            {
                if(_client != null)
                {
                    switch(_client.State)
                    {
                        case CommunicationState.Opened:
                        case CommunicationState.Opening:
                        case CommunicationState.Created:
                            _client.Close();
                        break;
                        case CommunicationState.Faulted:
                            _client.Abort();
                            break;

                    }

                }
                if(String.IsNullOrEmpty(serverAddress.Text))
                    _client = new AxMetadataServiceClient("MetadataServiceEndpoint", String.Format("net.tcp://localhost:8201/DynamicsAx/Services/MetadataService", this.serverAddress.Text));
                else
                    _client = new AxMetadataServiceClient("MetadataServiceEndpoint", String.Format("net.tcp://{0}/DynamicsAx/Services/MetadataService", this.serverAddress.Text));

                TreeViewProvider.GenerateTreeView(_client as dynamic, AOTTreeView);
            }

            
        }

    }
}
