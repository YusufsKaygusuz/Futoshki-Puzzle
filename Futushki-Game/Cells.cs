using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futushki_Game
{
   public class Cells : Button
    {
        public int Value { get; set; }
        public bool IsLocked { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Clear()
        {
            this.Text = string.Empty;
            this.IsLocked = false;
        }


    }
}
