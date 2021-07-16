using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futushki_Game
{
    public class SignBox : TextBox
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void ClearText()
        {
            this.Text = string.Empty;
        }
    }
}
