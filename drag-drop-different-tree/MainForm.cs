namespace drag_drop_different_tree
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            treeViewA.AllowDrop = true;
            treeViewA.ItemDrag += onAnyItemDrag;
            treeViewA.DragDrop += onAnyDragDrop;
            treeViewA.DragOver += onAnyDragOver;

            treeViewB.AllowDrop = true;
            treeViewB.ItemDrag += onAnyItemDrag;
            treeViewB.DragDrop += onAnyDragDrop;
            treeViewB.DragOver += onAnyDragOver;
        }

        private void onAnyItemDrag(object? sender, ItemDragEventArgs e)
        {
            if(sender is TreeView treeView)
            {
                treeView.DoDragDrop(e.Item, DragDropEffects.Move);
            }
        }

        private void onAnyDragOver(object? sender, DragEventArgs e)
        {
            if (sender is TreeView treeView)
            {
                TreeNode
                    dragNode = (TreeNode)e.Data.GetData(typeof(TreeNode)),
                    dropNode = treeView.GetNodeAt(treeView.PointToClient(new Point(e.X, e.Y)));
                if(ReferenceEquals(dragNode, dropNode)) 
                {
                    e.Effect = 0;
                    // To Do
                    // Can't drop on descendant node either.
                }
                else
                {
                    e.Effect = e.AllowedEffect;
                }
            }
        }

        private void onAnyDragDrop(object? sender, DragEventArgs e)
        {
            if (sender is TreeView treeView)
            {
                TreeNode
                    dragNode = (TreeNode)e.Data.GetData(typeof(TreeNode)),
                    dropNode = treeView.GetNodeAt(treeView.PointToClient(new Point(e.X, e.Y)));
                // Remove from where it is now
                dragNode.Remove();
                if(dropNode == null)
                {
                    treeView.Nodes.Add(dragNode);
                }
                else
                {
                    dropNode.Nodes.Add(dragNode);
                }
                dragNode.Parent?.Expand();
            }
        }
    }
}