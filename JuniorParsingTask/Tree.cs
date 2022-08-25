using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorParsingTask
{
    public class Tree
    {
        public readonly Node Root;
        public int Size { get; set; }

        public Tree(Node root)
        {
            Root = root;
        }

        public Node GetNode(string search, Node node)
        {
            foreach (Node item in node.Children)
            {
                if (item.Value == search)
                {
                    return item;
                }
                else
                {
                    Node test = GetNode(search, item);
                    if (test != null)
                        return test;
                }
            }
            return null;
        }


        public bool TryGetNode(string search, out Node nodeitem)
        {
            nodeitem = GetNode(search, Root);

            if(nodeitem == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



    }

}