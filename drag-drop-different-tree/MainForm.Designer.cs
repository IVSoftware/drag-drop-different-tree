namespace drag_drop_different_tree
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Child-A0-0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Root-A-0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Root-A-1");
            this.treeViewA = new System.Windows.Forms.TreeView();
            this.treeViewB = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeViewA.Location = new System.Drawing.Point(21, 21);
            this.treeViewA.Name = "treeViewA";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Child-A0-0";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Root-A-0";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Root-A-1";
            this.treeViewA.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            this.treeViewA.Size = new System.Drawing.Size(182, 202);
            this.treeViewA.TabIndex = 0;
            // 
            // treeView2
            // 
            this.treeViewB.Location = new System.Drawing.Point(248, 21);
            this.treeViewB.Name = "treeViewB";
            this.treeViewB.Size = new System.Drawing.Size(182, 202);
            this.treeViewB.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.treeViewB);
            this.Controls.Add(this.treeViewA);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView treeViewA;
        private TreeView treeViewB;
    }
}