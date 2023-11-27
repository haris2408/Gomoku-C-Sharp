using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Gomokucs
{
    class celll:Button
    {
        public bool ocupied = false;
        private int turn;
        public celll(int w,int h)
        {
            this.Width = w;
            this.Height = h;
            turn = 3;
        }
        public void setturn(int tur)
        {
            this.turn = tur;
        }
        public int getturn()
        {
            return this.turn;
        }
    }
}
