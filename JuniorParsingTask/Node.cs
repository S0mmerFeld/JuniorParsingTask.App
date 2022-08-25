﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorParsingTask
{
    public class Node
    {
        public readonly string Value;
        public readonly List<Node> Children;


        public Node(string value)
        {
            Value = value;
            Children = new List<Node>();
        }

        public void AddChild(Node child)
        {
            Children.Add(child);
        }

        public void AddChildren(params Node[] children)
        {
            Children.AddRange(children);
        }

    }
}