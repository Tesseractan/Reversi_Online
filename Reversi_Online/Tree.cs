using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversi_Online
{
    class Tree<T>
    {
        public class AlienNodeException : Exception
        {
            private string message;
            public AlienNodeException()
            {
                this.message = "The node hooking up should belong to the same tree";
            }
            public override string Message => this.message;
        }
        public class Node
        {//Access restricted: the Node class can be instantiated only within the DataNetwork<T> class
            private Tree<T> tree;
            private T cargo;
            private List<Node> parents = new List<Node>(), children = new List<Node>();

            protected Node(T cargo, Tree<T> data_network)
            {
                this.tree = data_network;
                this.cargo = cargo;
            }

            public void Hook(Node parent)
            {
                if (parent.tree.Equals(this.tree))
                {
                    parent.children.Add(this);
                    this.parents.Add(parent);
                }
                else throw new AlienNodeException();
            }
            public Node[] Roots
            {
                get
                {
                    List<Node> roots = new List<Node>();
                    void penetrate_past(List<Node> nodes)
                    {
                        List<Node> ancestors = new List<Node>();
                        for (int i = 0; i < nodes.Count; i++)
                        {
                            List<Node> parents = nodes[i].parents;
                            if (parents.Count == 0) roots.Add(nodes[i]);
                            else ancestors.AddRange(parents);
                        }
                        if (ancestors.Count > 0) penetrate_past(ancestors);
                    }
                    List<Node> list = new List<Node>();
                    list.Add(this);
                    penetrate_past(list);
                    return roots.ToArray();
                }
            }
            public Node[] Crown
            {
                get
                {
                    List<Node> crown = new List<Node>();
                    void penetrate_future(List<Node> nodes)
                    {
                        List<Node> descendents = new List<Node>();
                        for (int i = 0; i < nodes.Count; i++)
                        {
                            List<Node> children = nodes[i].children;
                            if (children.Count == 0) crown.Add(nodes[i]);
                            else descendents.AddRange(children);
                        }
                        if (descendents.Count > 0) penetrate_future(descendents);
                    }
                    List<Node> list = new List<Node>();
                    list.Add(this);
                    penetrate_future(list);
                    return crown.ToArray();
                }
            }
            public Node[] Parents => this.parents.ToArray();

            public Node[] Children => this.children.ToArray();
            public T Cargo
            {
                get { return this.cargo; }
                set { this.cargo = value; }
            }

        }
        private class NodeInstance : Node
        {
            public NodeInstance(T cargo, Tree<T> data_network) : base(cargo, data_network) { }
        }

        private List<Node> nodes = new List<Node>();

        public Tree()
        {

        }
        public Node CreateNode(T cargo)
        {
            Node node = new NodeInstance(cargo, this);
            this.nodes.Add(node);
            return node;
        }
        public Node[] Nodes => this.nodes.ToArray();
    }
}
