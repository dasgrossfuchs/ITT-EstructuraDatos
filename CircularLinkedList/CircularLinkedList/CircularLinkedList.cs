using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircularLinkedList
{
    class LinkedList
    {
         public Node header;
        public Node pointer;

        public LinkedList()
        {
            header = null;
            pointer = null;
        }

        public void Add(int e)
        {
            Node n = new Node(e);
            if (header == null)
            {
                header = n;
                pointer = n;
                pointer.next = header;
                header.previous = pointer;
            }
            else
            {
                pointer.next = n;
                pointer.next.previous = pointer;
                pointer = pointer.next;
                pointer.next = header;
            }
        }
public void Delete(int v)
        {
            Node n = header;
            if (header.value == v)
            {
                header = header.next;
                pointer.next = header;
            }
            do
            {
                if (n.value == v)
                {
                    n.previous.next = n.next;
                    n.next.previous = n.previous;

                }
                n = n.next;
            } while (n != header);

        }

    }
}
