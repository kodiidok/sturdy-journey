namespace MineField
{
    class SearchTreeNode
    {
        private GraphNode _node;
        private SearchTreeNode? _parent;
        private List<SearchTreeNode>? _children;

        public SearchTreeNode(GraphNode node)
        {
            _node = node;
            _parent = null;
            _children = null;
        }
    }
}