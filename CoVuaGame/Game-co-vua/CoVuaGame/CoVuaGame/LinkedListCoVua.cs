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
            public int X;
            public int Y;
        }
        public Node Head;
 
        public LinkedListCoVua() {
            Head = new Node();
            Head.Info = default(T);
            Head.X = 0;
            Head.Y = 0;
        }
        public int Add(T item, int x, int y)
        {
            Node temp = new Node();
            if (temp == null)
                return 0;
            temp.Info = item;
            temp.X = x;
            temp.Y = y;

            temp.next = Head;
            Head = temp;
            return 1;
        }
        public void Remove()  {
            Head = Head.next;
        }
    }
}
