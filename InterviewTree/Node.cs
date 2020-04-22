using System;
using System.Collections.Generic;

namespace InterviewTree
{
    public class Node
    {
        public string Label { get; set; }
        public List<Node> Children { get; set; }
        public void Do()
        {
            Console.WriteLine($"Do in {Label}");
        }
    }
}