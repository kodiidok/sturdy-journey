namespace MineField
{
    /// <summary>
    /// Represents a node in a graph, containing a value and references to adjacent nodes in all eight directions.
    /// </summary>
    class GraphNode
    {
        private string? _id;
        private int _value;
        private GraphNode? _upLeft;
        private GraphNode? _up;
        private GraphNode? _upRight;
        private GraphNode? _right;
        private GraphNode? _downRight;
        private GraphNode? _down;
        private GraphNode? _downLeft;
        private GraphNode? _left;

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNode"/> class with the specified value.
        /// </summary>
        /// <param name="value">The value to be stored in the node.</param>
        public GraphNode(int value)
        {
            _value = value;
            _upLeft = null;
            _up = null;
            _upRight = null;
            _right = null;
            _downRight = null;
            _down = null;
            _downLeft = null;
            _left = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNode"/> class with the specified value.
        /// </summary>
        /// <param name="value">The value to be stored in the node.</param>
        public GraphNode(int value, string id)
        {
            _value = value;
            _upLeft = null;
            _up = null;
            _upRight = null;
            _right = null;
            _downRight = null;
            _down = null;
            _downLeft = null;
            _left = null;
            _id = id;
        }

        /// <summary>
        /// Gets or sets the ID of the node.
        /// </summary>
        /// <value>The ID of the node.</value>
        public string? Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Gets or sets the value stored in the node.
        /// </summary>
        /// <value>The integer value of the node.</value>
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// Gets or sets the node that is diagonally up-left from this node.
        /// </summary>
        /// <value>A reference to the up-left <see cref="GraphNode"/>, or <c>null</c> if there is none.</value>
        public GraphNode? UpLeft
        {
            get { return _upLeft; }
            set { _upLeft = value; }
        }

        /// <summary>
        /// Gets or sets the node that is directly above this node.
        /// </summary>
        /// <value>A reference to the up <see cref="GraphNode"/>, or <c>null</c> if there is none.</value>
        public GraphNode? Up
        {
            get { return _up; }
            set { _up = value; }
        }

        /// <summary>
        /// Gets or sets the node that is diagonally up-right from this node.
        /// </summary>
        /// <value>A reference to the up-right <see cref="GraphNode"/>, or <c>null</c> if there is none.</value>
        public GraphNode? UpRight
        {
            get { return _upRight; }
            set { _upRight = value; }
        }

        /// <summary>
        /// Gets or sets the node that is directly to the right of this node.
        /// </summary>
        /// <value>A reference to the right <see cref="GraphNode"/>, or <c>null</c> if there is none.</value>
        public GraphNode? Right
        {
            get { return _right; }
            set { _right = value; }
        }

        /// <summary>
        /// Gets or sets the node that is diagonally down-right from this node.
        /// </summary>
        /// <value>A reference to the down-right <see cref="GraphNode"/>, or <c>null</c> if there is none.</value>
        public GraphNode? DownRight
        {
            get { return _downRight; }
            set { _downRight = value; }
        }

        /// <summary>
        /// Gets or sets the node that is directly below this node.
        /// </summary>
        /// <value>A reference to the down <see cref="GraphNode"/>, or <c>null</c> if there is none.</value>
        public GraphNode? Down
        {
            get { return _down; }
            set { _down = value; }
        }

        /// <summary>
        /// Gets or sets the node that is diagonally down-left from this node.
        /// </summary>
        /// <value>A reference to the down-left <see cref="GraphNode"/>, or <c>null</c> if there is none.</value>
        public GraphNode? DownLeft
        {
            get { return _downLeft; }
            set { _downLeft = value; }
        }

        /// <summary>
        /// Gets or sets the node that is directly to the left of this node.
        /// </summary>
        /// <value>A reference to the left <see cref="GraphNode"/>, or <c>null</c> if there is none.</value>
        public GraphNode? Left
        {
            get { return _left; }
            set { _left = value; }
        }
    }
}
