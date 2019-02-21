using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class SinglePlayer : Form
    {
        List<int> li = new List<int>() { 1,2,3,4,5,6,7,8,9};
        int player = 1;
        int btn_Clicked1 = 0, btn_Clicked2 = 0, btn_Clicked3 = 0, btn_Clicked4 = 0, btn_Clicked5 = 0, btn_Clicked6 = 0, btn_Clicked7 = 0, btn_Clicked8 = 0, btn_Clicked9 = 0;
        public SinglePlayer()
        {
            InitializeComponent();
        }
        private void ResultCheck() 
        {
            if ((btn_Clicked1 ==1 && btn_Clicked2 ==1 && btn_Clicked3 == 1) || (btn_Clicked1==1 && btn_Clicked4==1 &&btn_Clicked7 == 1) || (btn_Clicked1 ==1 && btn_Clicked5 ==1 && btn_Clicked9 == 1) || (btn_Clicked3==1 && btn_Clicked6==1 && btn_Clicked9 == 1) || (btn_Clicked3==1 && btn_Clicked5==1 && btn_Clicked7 == 1 )|| (btn_Clicked7==1 && btn_Clicked8==1 && btn_Clicked9 == 1) || (btn_Clicked2==1 && btn_Clicked5==1 && btn_Clicked8 == 1) || (btn_Clicked4==1 && btn_Clicked5==1 && btn_Clicked6 == 1))
            {
                lbl_Winner.Text = "You Won";

                btn_One.Enabled = false;
                btn_Two.Enabled = false;
                btn_Three.Enabled = false;
                btn_Four.Enabled = false;
                btn_Five.Enabled = false;
                btn_Six.Enabled = false;
                btn_Seven.Enabled = false;
                btn_Eight.Enabled = false;
                btn_Nine.Enabled = false;
            }
            else if ((btn_Clicked1 == 2 && btn_Clicked2 == 2 && btn_Clicked3 == 2) || (btn_Clicked1 == 2 && btn_Clicked4 == 2 && btn_Clicked7 == 2) || (btn_Clicked1 == 2 && btn_Clicked5 == 2 && btn_Clicked9 == 2) || (btn_Clicked3 == 2 && btn_Clicked6 == 2 && btn_Clicked9 == 2) || (btn_Clicked3 == 2 && btn_Clicked5 == 2 && btn_Clicked7 == 2) || (btn_Clicked7 == 2 && btn_Clicked8 == 2 && btn_Clicked9 == 2) || (btn_Clicked2 == 2 && btn_Clicked5 == 2 && btn_Clicked8 == 2) || (btn_Clicked4 == 2 && btn_Clicked5 == 2 && btn_Clicked6 == 2))
            {
                lbl_Winner.Text = "You Lose";

                btn_One.Enabled = false;
                btn_Two.Enabled = false;
                btn_Three.Enabled = false;
                btn_Four.Enabled = false;
                btn_Five.Enabled = false;
                btn_Six.Enabled = false;
                btn_Seven.Enabled = false;
                btn_Eight.Enabled = false;
                btn_Nine.Enabled = false;
            }
            else if (btn_Clicked1 > 0 && btn_Clicked2 > 0 && btn_Clicked3 > 0 && btn_Clicked4 > 0 && btn_Clicked5 > 0 && btn_Clicked6 > 0 && btn_Clicked7 > 0 && btn_Clicked8 > 0 && btn_Clicked9 > 0)
            {
                lbl_Winner.Text = "Tie";

                btn_One.Enabled = false;
                btn_Two.Enabled = false;
                btn_Three.Enabled = false;
                btn_Four.Enabled = false;
                btn_Five.Enabled = false;
                btn_Six.Enabled = false;
                btn_Seven.Enabled = false;
                btn_Eight.Enabled = false;
                btn_Nine.Enabled = false;
            }
            else{}
        }
        private void PlayerTwoAction() 
        {
            Random rndm = new Random();
            int x = rndm.Next(li.Count);
            try
            {
                if (li[x] == 1)
                {
                    btn_One.Text = "O";
                    btn_Clicked1 = 2;
                    li.Remove(1);
                }
                else if (li[x] == 2)
                {
                    btn_Two.Text = "O";
                    btn_Clicked2 = 2;
                    li.Remove(2);
                }
                else if (li[x] == 3)
                {
                    btn_Three.Text = "O";
                    btn_Clicked3 = 2;
                    li.Remove(3);
                }
                else if (li[x] == 4)
                {
                    btn_Four.Text = "O";
                    btn_Clicked4 = 2;
                    li.Remove(4);
                }
                else if (li[x] == 5)
                {
                    btn_Five.Text = "O";
                    btn_Clicked5 = 2;
                    li.Remove(5);
                }
                else if (li[x] == 6)
                {
                    btn_Six.Text = "O";
                    btn_Clicked6 = 2;
                    li.Remove(6);
                }
                else if (li[x] == 7)
                {
                    btn_Seven.Text = "O";
                    btn_Clicked7 = 2;
                    li.Remove(7);
                }
                else if (li[x] == 8)
                {
                    btn_Eight.Text = "O";
                    btn_Clicked8 = 2;
                    li.Remove(8);
                }
                else if (li[x] == 9)
                {
                    btn_Nine.Text = "O";
                    btn_Clicked9 = 2;
                    li.Remove(9);
                }
            }
            catch{}
            player = 1;
            this.ResultCheck();
        }
        private void btn_One_Click(object sender, EventArgs e)
        {
            if (player == 1 && btn_Clicked1 == 0)
            {
                btn_One.Text = "X";
                player = 2;
                btn_Clicked1 = 1;
                li.Remove(1);
                this.ResultCheck();
                this.PlayerTwoAction();
            }
            else { }
        }

        private void btn_Two_Click(object sender, EventArgs e)
        {
            if (player == 1 && btn_Clicked2 == 0)
            {
                btn_Two.Text = "X";
                player = 2;
                btn_Clicked2 = 1;
                li.Remove(2);
                this.ResultCheck();
                this.PlayerTwoAction();
            }
            else { }
        }

        private void btn_Three_Click(object sender, EventArgs e)
        {
            if (player == 1 && btn_Clicked3 == 0)
            {
                btn_Three.Text = "X";
                player = 2;
                btn_Clicked3 = 1;
                li.Remove(3);
                this.ResultCheck();
                this.PlayerTwoAction();
            }
            else { }
        }

        private void btn_Four_Click(object sender, EventArgs e)
        {
            if (player == 1 && btn_Clicked4 == 0)
            {
                btn_Four.Text = "X";
                player = 2;
                btn_Clicked4 = 1;
                li.Remove(4);
                this.ResultCheck();
                this.PlayerTwoAction();
            }
            else { }
        }

        private void btn_Five_Click(object sender, EventArgs e)
        {
            if (player == 1 && btn_Clicked5 == 0)
            {
                btn_Five.Text = "X";
                player = 2;
                btn_Clicked5 = 1;
                li.Remove(5);
                this.ResultCheck();
                this.PlayerTwoAction();
            }
            else { }
        }

        private void btn_Six_Click(object sender, EventArgs e)
        {
            if (player == 1 && btn_Clicked6 == 0)
            {
                btn_Six.Text = "X";
                player = 2;
                btn_Clicked6 = 1;
                li.Remove(6);
                this.ResultCheck();
                this.PlayerTwoAction();
            }
            else { }
        }

        private void btn_Seven_Click(object sender, EventArgs e)
        {
            if (player == 1 && btn_Clicked7 == 0)
            {
                btn_Seven.Text = "X";
                player = 2;
                btn_Clicked7 = 1;
                li.Remove(7);
                this.ResultCheck();
                this.PlayerTwoAction();
            }
            else { }
        }

        private void btn_Eight_Click(object sender, EventArgs e)
        {
            if (player == 1 && btn_Clicked8 == 0)
            {
                btn_Eight.Text = "X";
                player = 2;
                btn_Clicked8 = 1;
                li.Remove(8);
                this.ResultCheck();
                this.PlayerTwoAction();
            }
            else { }
        }

        private void btn_Nine_Click(object sender, EventArgs e)
        {
            if (player == 1 && btn_Clicked9 == 0)
            {
                btn_Nine.Text = "X";
                player = 2;
                btn_Clicked9 = 1;
                li.Remove(9);
                this.ResultCheck();
                this.PlayerTwoAction();
            }
            else { }
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            SinglePlayer sp = new SinglePlayer();
            sp.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
