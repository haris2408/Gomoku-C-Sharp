using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomokucs
{
    public partial class Gomoku : Form
    {
        int dimen=0, Wincount=0;
        int turn = 0;
        celll[,] arr;
        public Gomoku()
        {
            InitializeComponent();
        }
        void loadcellss()
        {

            panelforthegame.Controls.Clear();
            arr = new celll[dimen, dimen];
            int sub = 0;
            if (dimen == 3)
                sub = 7;
            else if (dimen == 5)
                sub = 6;
            else if (dimen == 10)
                sub = 7;
            else if (dimen == 15)
                sub = 6;
            else if (dimen == 20)
                sub = 6;

            celll obj;
            for(int ri=0;ri<dimen;ri++)
            {
                for (int ci = 0; ci < dimen; ci++)
                {
                    obj = new celll(panelforthegame.Width / dimen - sub, panelforthegame.Height / dimen - sub);
                    
                    obj.Click += new System.EventHandler(this.celll_Click);
                    panelforthegame.Controls.Add(obj);
                    arr[ri, ci] = obj;
                }
            }
        }
        void loadcellss2()
        {

            panelforthegame.Controls.Clear();
            arr = new celll[dimen, dimen];
            int sub = 0;
            if (dimen == 3)
                sub = 7;
            else if (dimen == 5)
                sub = 6;
            else if (dimen == 10)
                sub = 7;
            else if (dimen == 15)
                sub = 6;
            else if (dimen == 20)
                sub = 6;

            celll obj;
            for (int ri = 0; ri < dimen; ri++)
            {
                for (int ci = 0; ci < dimen; ci++)
                {
                    obj = new celll(panelforthegame.Width / dimen - sub, panelforthegame.Height / dimen - sub);

                    obj.Click += new System.EventHandler(this.celll_Click2);
                    panelforthegame.Controls.Add(obj);
                    arr[ri, ci] = obj;
                }
            }
        }
        void turnchanger()
        {
            if (turn == 0)
                turn = 1;
            else
                turn = 0;
        }
        bool t2b(int r,int c)
        {
            for (int ri = r; ri < r + Wincount; ri++) 
            {
                if (arr[ri, c].getturn() != turn)
                    return false;
            }
            return true;
        }
        bool l2r(int r, int c)
        {
            if (c > dimen - Wincount)
                return false;
            for (int ci = c; ci < c + Wincount; ci++)
            {
                if (arr[r, ci].getturn() != turn)
                    return false;
            }
            return true;
        }
        bool diag1(int r,int c)
        {
            if (r >= dimen - Wincount||c>= dimen - Wincount)
                return false;
            for (int ri = r, ci = c; ri < r + Wincount || ci < c + Wincount; ci++, ri++) 
            {
                if (arr[ri, ci].getturn() != turn)
                    return false;
            }
            return true;
        }
        bool diag2(int r, int c)
        {
            if (r < Wincount || c < Wincount) 
                return false;
            for (int ri = r, ci = c; ri > r - Wincount; ri--, ci++) 
            {
                if (arr[ri, ci].getturn() != turn)
                    return false;
            }
            return true;
        }
        bool haswon()
        {
            for (int ri = 0; ri < dimen; ri++) 
            {
                for (int ci = 0; ci < dimen; ci++) 
                {
                    if(arr[ri,ci].getturn()==turn)
                    {
                        if (t2b(ri, ci) || diag1(ri, ci) || diag2(ri, ci) || l2r(ri, ci))
                            return true;
                    }
                    
                }
            }
            return false;
        }
        void gameend()
        {
            if (turn == 0)
                MessageBox.Show("Player 1 wins");
            else
                MessageBox.Show("Player 2 wins");
            panelforthegame.Controls.Clear();
            start.Text = "Replay";
            turn = 0;
            Wincount = 0;
        }
        private void celll_Click(object sender, EventArgs e)
        {
           
            celll obj = (celll)sender;
            if(obj.ocupied==true)
            {
                MessageBox.Show("Yara cheating tou na kar");
                return;
            }
            if (turn == 0)
                obj.BackColor = Color.DarkRed;
            else
                obj.BackColor = Color.DarkGray;
            obj.ocupied = true;
            obj.setturn(turn);
            if (haswon())
                gameend();
            else
                turnchanger();
            if (turn == 0)
                playerno.Text = "Player 1's turn";
            else
                playerno.Text = "Player 2's turn";
        }
        private void celll_Click2(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                celll obj = (celll)sender;
                if (obj.ocupied == true)
                {
                    MessageBox.Show("Yara cheating tou na kar");
                    return;
                }
                obj.BackColor = Color.DarkRed;
                obj.ocupied = true;
                obj.setturn(turn);
            }
            if (haswon())
                gameend();
            else
                turnchanger();
            computermove();
        }
        bool isvalid(int r,int c)
        {
            if ((r < 0 || r >= dimen || c < 0 || c >= dimen) || arr[r, c].getturn() != 3)
                return false;
            return true;
        }
        void computermove()
        {
            int Ri=99, Ci=99;
            bool WH = false;
            for (int r = 0; r < dimen; r++)
            {
                for (int c = 0; c < dimen; c++)
                {
                    WH = false;
                    if (arr[r,c].getturn() == 3)
                    {
                        arr[r,c].setturn(turn);
                        WH = (haswon());
                        arr[r, c].setturn(3);
                    }
                    if (WH)
                    {
                        Ri = r;
                        Ci = c;
                    }
                }
            }
            if(Ri==99)
            {
                turnchanger();
                for (int r = 0; r < dimen; r++)
                {
                    for (int c = 0; c < dimen; c++)
                    {
                        WH = false;
                        if (arr[r, c].getturn() == 3)
                        {
                            arr[r, c].setturn(turn);
                            WH = (haswon());
                            arr[r, c].setturn(3);
                        }
                        if (WH)
                        {
                            Ri = r;
                            Ci = c;
                        }
                    }
                }
                turnchanger();
            }
            if (Ri == 99)
            {
                Random rnd = new Random();
                do
                {
                    Ri = rnd.Next(0, dimen);
                    Ci = rnd.Next(0, dimen);
                } while (isvalid(Ri, Ci));
            }
            arr[Ri, Ci].BackColor = Color.DarkGray;
            arr[Ri, Ci].setturn(turn);
            arr[Ri, Ci].ocupied = true;
        }

        private void getc_TextChanged(object sender, EventArgs e)
        {

        }

        private void CvH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            if (HvH.Checked)
            {
                if (start.Text != "Replay")
                {
                    if (threetimesthree.Checked)
                        dimen = 3;
                    else if (fivetimesfive.Checked)
                        dimen = 5;
                    else if (teveltimestevel.Checked)
                        dimen = 10;
                    else if (fifteentimesfifteen.Checked)
                        dimen = 15;
                    else if (twoeonetimestwoeone.Checked)
                        dimen = 20;
                    if (dimen == 0)
                    {
                        MessageBox.Show("Please select a grid size to enjoy further");
                        return;
                    }
                    if (getc.Text != "")
                        Wincount = Int32.Parse(getc.Text);
                    if (Wincount <= 0 || Wincount > dimen)
                    {
                        MessageBox.Show("Please select a WinCount to enjoy further");
                        return;
                    }
                    loadcellss();
                    if (turn == 0)
                        playerno.Text = "Player 1's turn";
                    else
                        playerno.Text = "Player 2's turn";
                }
                else
                {
                    start.Text = "Start";
                    getc.Text = "";
                }
            }
            else if(CvH.Checked)
            {
                if (start.Text != "Replay")
                {
                    if (threetimesthree.Checked)
                        dimen = 3;
                    else if (fivetimesfive.Checked)
                        dimen = 5;
                    else if (teveltimestevel.Checked)
                        dimen = 10;
                    else if (fifteentimesfifteen.Checked)
                        dimen = 15;
                    else if (twoeonetimestwoeone.Checked)
                        dimen = 20;
                    if (dimen == 0)
                    {
                        MessageBox.Show("Please select a grid size to enjoy further");
                        return;
                    }
                    if (getc.Text != "")
                        Wincount = Int32.Parse(getc.Text);
                    if (Wincount <= 0 || Wincount > dimen)
                    {
                        MessageBox.Show("Please select a WinCount to enjoy further");
                        return;
                    }
                    loadcellss2();
                    if (turn == 0)
                    {
                        playerno.Text = "Player's turn";
                    }
                    else
                    {
                        playerno.Text = "Computer's turn";
                    }
                }
                else
                {
                    start.Text = "Start";
                    getc.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Select a game mode");
            }
        }
    }
}
