using System.Collections.Generic;

namespace InterviewTree
{
    class DeepNodeProvider
    {
        private static Node _last;

        public Node Get()
        {
            var node = CreateDeepNode(10000);
            _last.Children = new List<Node> {CreateDeepNode(10000)};
            return node;
        }

        private static Node CreateDeepNode(int rest)
        {
            if (rest == 0)
            {
                _last = new Node() {Label = "last"};
                return _last;
            }

            return new Node() {Label = "deep", Children = new List<Node>() {CreateDeepNode(rest - 1)}};
        }
    }
}