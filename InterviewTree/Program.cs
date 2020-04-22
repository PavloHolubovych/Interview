using System;
using System.Collections.Generic;
using System.Linq;

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

            root.Children.Add(new DeepNodeProvider().Get());
            //ForEach(root);
            ForEachRecursive(root);

            Console.ReadKey();
        }

        static void ForEachRecursive(Node root)
        {
            root.Do();
            if (root.Children != null && root.Children.Any())
            {
                foreach (Node node in root.Children)
                {
                    ForEachRecursive(node);
                }
            }
        }


        static void ForEach(Node root)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                item.Do();
                if (item.Children != null)
                {
                    foreach (var childNode in item.Children)
                    {
                        queue.Enqueue(childNode);
                    }
                }
            }
        }
    }
}