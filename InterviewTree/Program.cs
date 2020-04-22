using System.Collections.Generic;

namespace InterviewTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Node
            {
                Label = "a",
                Children = new List<Node>
                {
                    new Node() {Label = "b"},
                    new Node() {Label = "c", Children = new List<Node> {new Node() {Label = "f"}}},
                    new Node() {Label = "d"}
                }
            };
           // to be uncommented later                                                                                                                                                                 root.Children.Add(new DeepNodeProvider().Get());
        }
    }
}