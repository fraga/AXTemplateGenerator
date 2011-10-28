namespace AXTemplateGenerator.Forms
{
    partial class TreeView
    {
        private System.Windows.Forms.TreeNode treeNode3;
        private System.Windows.Forms.TreeNode treeNode2;
        private System.Windows.Forms.TreeNode treeNode1;
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
            this.serverAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //InitializeTreeView();
            // 
            // serverAddress
            // 
            this.serverAddress.Location = new System.Drawing.Point(84, 6);
            this.serverAddress.Name = "serverAddress";
            this.serverAddress.Size = new System.Drawing.Size(158, 20);
            this.serverAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "AOS Server:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverAddress);
            this.Controls.Add(this.AOTTreeView);
            this.Name = "TreeView";
            this.Text = "AOT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeTreeView()
        {
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Tables");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Extended Data Types");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Base Enums");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Data Dictionary", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Classes");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Queries");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Services");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Forms");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("AOT", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26});
            this.AOTTreeView = new System.Windows.Forms.TreeView();

            // 
            // AOTTreeView
            // 
            this.AOTTreeView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AOTTreeView.Location = new System.Drawing.Point(0, 32);
            this.AOTTreeView.Name = "AOTTreeView";
            treeNode19.Name = "Tables";
            treeNode19.Text = "Tables";
            treeNode20.Name = "EDT";
            treeNode20.Text = "Extended Data Types";
            treeNode21.Name = "BaseEnums";
            treeNode21.Text = "Base Enums";
            treeNode22.Name = "DataDictionary";
            treeNode22.Text = "Data Dictionary";
            treeNode23.Name = "Classes";
            treeNode23.Text = "Classes";
            treeNode24.Name = "Queries";
            treeNode24.Text = "Queries";
            treeNode25.Name = "Services";
            treeNode25.Text = "Services";
            treeNode26.Name = "Forms";
            treeNode26.Text = "Forms";
            treeNode27.Name = "AOT";
            treeNode27.Text = "AOT";
            this.AOTTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {treeNode27});
            this.AOTTreeView.Size = new System.Drawing.Size(295, 426);
            this.AOTTreeView.TabIndex = 0;
            this.Controls.Add(this.AOTTreeView);
        }

        #endregion

        private System.Windows.Forms.TreeView AOTTreeView;
        private System.Windows.Forms.TextBox serverAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

