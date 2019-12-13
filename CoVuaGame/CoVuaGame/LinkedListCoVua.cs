using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoVuaGame
{
    public class LinkedListCoVua<T>  {
        public class Node  {
            public Node next;
            public T Info;
        }
        public Node Head;
 
        public LinkedListCoVua() {
            Head = new Node();
            Head.Info = default(T);
        }
        public int Add(T item)
        {
            Node temp = new Node();
            if (temp == null)
                return 0;
            temp.Info = item;
            temp.next = Head;
            Head = temp;
            return 1;
        }
        public void Remove()  {
            Head = Head.next;
        }
    }
}
