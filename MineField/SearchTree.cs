namespace MineField
{
    class SearchTree
    {

        private SearchTreeNode? _root;

        public SearchTree()
        {
            _root = null;
        }

        public SearchTree(GraphNode root)
        {
            _root = new SearchTreeNode(root);
        }

        public SearchTreeNode? Root { get => _root; set => _root = value; }
    }
}