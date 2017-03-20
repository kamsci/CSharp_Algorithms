using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Node
    {
        public Node() { }

        public Node(int input)
        {
            data = input;
        }

        private int data;
        private Node next;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

    }
}
