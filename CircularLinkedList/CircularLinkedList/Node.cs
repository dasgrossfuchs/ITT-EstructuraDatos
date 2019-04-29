using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircularLinkedList
{
    class Node
    {
        public Node next { get; set; }
        public int value { get; set; }
        public Node previous { get; set; }
        public Node(int val)
        {
            this.value = val;
            this.next = null;
            this.previous = null;
        }

    }
}
