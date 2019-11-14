using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoVuaGame
{
    public class StackCoVua<T>
    {
        int top;
        LinkedListCoVua<T> list;
        public StackCoVua() {
            list = new LinkedListCoVua<T>();
            top = -1;
        }
        public void Push(T item, int X, int Y){
            if (list.Add(item, X, Y) == 0) {
                MessageBox.Show("Lỗi bộ nhớ!", "Thông báo!!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                top--;
            }
            ++top;
        }
        public T Pop()  {
            T item = list.Head.Info;
            list.Remove();
            --top;
            return item;
        }
        public T Top()  {
            return list.Head.Info;
        }

        public int X { get { return list.Head.X; } }

        public int Y { get { return list.Head.Y; } }

        public int Count   {  get { return top + 1; } }
    }
}
