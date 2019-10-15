using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoVuaGame
{
    public abstract class GeneralMethods
    {
        public void CanMove(List<List<Button>> Matrix, Point point)
        { }
        public void CanKill(List<List<Button>> Matrix, Point pointSource)
        { }
        public bool IsTeamMate(string btnName1, string btnName2)
        {
            btnName1 = btnName1.Substring(0, 1);
            btnName2 = btnName2.Substring(0, 1);

            if (btnName1 == btnName2)
                return true;
            else
                return false;
        }
    }
}
