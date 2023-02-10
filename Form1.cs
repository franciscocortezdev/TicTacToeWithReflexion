namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool checker;
        int plusOne;

        void EnableFalse()
        {
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic4.Enabled = false;
            btnTic5.Enabled = false;
            btnTic6.Enabled = false;
            btnTic7.Enabled = false;
            btnTic8.Enabled = false;
            btnTic9.Enabled = false;

        }

        void Score()
        {
            if(btnTic1.Text == "X" && btnTic2.Text == "X" && btnTic3.Text == "X")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic2.BackColor = Color.PowderBlue;
                btnTic3.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is player X","TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblWinsPlayerX.Text);
                plusOne++;
                lblWinsPlayerX.Text = Convert.ToString(plusOne);
                EnableFalse();
            }
            if (btnTic4.Text == "X" && btnTic5.Text == "X" && btnTic6.Text == "X")
            {
                btnTic4.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic6.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblWinsPlayerX.Text);
                plusOne++;
                lblWinsPlayerX.Text = Convert.ToString(plusOne);
                EnableFalse();
            }
            if (btnTic7.Text == "X" && btnTic8.Text == "X" && btnTic9.Text == "X")
            {
                btnTic7.BackColor = Color.PowderBlue;
                btnTic8.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblWinsPlayerX.Text);
                plusOne++;
                lblWinsPlayerX.Text = Convert.ToString(plusOne);
                EnableFalse();
            }

            if (btnTic1.Text == "X" && btnTic4.Text == "X" && btnTic7.Text == "X")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic4.BackColor = Color.PowderBlue;
                btnTic7.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblWinsPlayerX.Text);
                plusOne++;
                lblWinsPlayerX.Text = Convert.ToString(plusOne);
                EnableFalse();
            }


            if (btnTic2.Text == "X" && btnTic5.Text == "X" && btnTic8.Text == "X")
            {
                btnTic2.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic8.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblWinsPlayerX.Text);
                plusOne++;
                lblWinsPlayerX.Text = Convert.ToString(plusOne);
                EnableFalse();
            }
            if (btnTic3.Text == "X" && btnTic6.Text == "X" && btnTic9.Text == "X")
            {
                btnTic3.BackColor = Color.PowderBlue;
                btnTic6.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblWinsPlayerX.Text);
                plusOne++;
                lblWinsPlayerX.Text = Convert.ToString(plusOne);
                EnableFalse();
            }
            if (btnTic1.Text == "X" && btnTic5.Text == "X" && btnTic9.Text == "X")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblWinsPlayerX.Text);
                plusOne++;
                lblWinsPlayerX.Text = Convert.ToString(plusOne);
                EnableFalse();
            }
            if (btnTic3.Text == "X" && btnTic5.Text == "X" && btnTic7.Text == "X")
            {
                btnTic3.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic7.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblWinsPlayerX.Text);
                plusOne++;
                lblWinsPlayerX.Text = Convert.ToString(plusOne);
                EnableFalse();
            }

            //===============================Player O=========================================

            if (btnTic1.Text == "O" && btnTic2.Text == "O" && btnTic3.Text == "O")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic2.BackColor = Color.PowderBlue;
                btnTic3.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblWinsPlayerO.Text);
                plusOne++;
                lblWinsPlayerO.Text = Convert.ToString(plusOne);
                EnableFalse();
            }
            if (btnTic4.Text == "O" && btnTic5.Text == "O" && btnTic6.Text == "O")
            {
                btnTic4.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic6.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblWinsPlayerO.Text);
                plusOne++;
                lblWinsPlayerO.Text = Convert.ToString(plusOne);
                EnableFalse();
            }
            if (btnTic7.Text == "O" && btnTic8.Text == "O" && btnTic9.Text == "O")
            {
                btnTic7.BackColor = Color.PowderBlue;
                btnTic8.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblWinsPlayerO.Text);
                plusOne++;
                lblWinsPlayerO.Text = Convert.ToString(plusOne);
                EnableFalse();
            }

            if (btnTic1.Text == "O" && btnTic4.Text == "O" && btnTic7.Text == "O")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic4.BackColor = Color.PowderBlue;
                btnTic7.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblWinsPlayerO.Text);
                plusOne++;
                lblWinsPlayerO.Text = Convert.ToString(plusOne);
                EnableFalse();
            }


            if (btnTic2.Text == "O" && btnTic5.Text == "O" && btnTic8.Text == "O")
            {
                btnTic2.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic8.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblWinsPlayerO.Text);
                plusOne++;
                lblWinsPlayerO.Text = Convert.ToString(plusOne);
                EnableFalse();
            }
            if (btnTic3.Text == "O" && btnTic6.Text == "O" && btnTic9.Text == "O")
            {
                btnTic3.BackColor = Color.PowderBlue;
                btnTic6.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblWinsPlayerO.Text);
                plusOne++;
                lblWinsPlayerO.Text = Convert.ToString(plusOne);
                EnableFalse();
            }
            if (btnTic1.Text == "O" && btnTic5.Text == "O" && btnTic9.Text == "O")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblWinsPlayerO.Text);
                plusOne++;
                lblWinsPlayerO.Text = Convert.ToString(plusOne);
                EnableFalse();
            }
            if (btnTic3.Text == "O" && btnTic5.Text == "O" && btnTic7.Text == "O")
            {
                btnTic3.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic7.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblWinsPlayerO.Text);
                plusOne++;
                lblWinsPlayerO.Text = Convert.ToString(plusOne);
                EnableFalse();
            }



        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTic1_Click(object sender, EventArgs e)
        {

            var btnSelected = (Button)sender;

            if (checker)
            {
                btnSelected.Text = "O";
                checker = false;
            }
            else
            {
                btnSelected.Text = "X";
                checker = true;
            }

            Score();

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            btnTic1.Enabled = true;
            btnTic2.Enabled = true;
            btnTic3.Enabled = true;
            btnTic4.Enabled = true;
            btnTic5.Enabled = true;
            btnTic6.Enabled = true;
            btnTic7.Enabled = true;
            btnTic8.Enabled = true;
            btnTic9.Enabled = true;

            btnTic1.Text = "";
            btnTic2.Text = "";
            btnTic3.Text = "";
            btnTic4.Text = "";
            btnTic5.Text = "";
            btnTic6.Text = "";
            btnTic7.Text = "";
            btnTic8.Text = "";
            btnTic9.Text = "";

            lblWinsPlayerX.Text = "0";
            lblWinsPlayerO.Text = "0";

            btnTic1.BackColor = Color.White;
            btnTic2.BackColor = Color.White;
            btnTic3.BackColor = Color.White;
            btnTic4.BackColor = Color.White;
            btnTic5.BackColor = Color.White;
            btnTic6.BackColor = Color.White;
            btnTic7.BackColor = Color.White;
            btnTic8.BackColor = Color.White;
            btnTic9.BackColor = Color.White;

        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            btnTic1.Enabled = true;
            btnTic2.Enabled = true;
            btnTic3.Enabled = true;
            btnTic4.Enabled = true;
            btnTic5.Enabled = true;
            btnTic6.Enabled = true;
            btnTic7.Enabled = true;
            btnTic8.Enabled = true;
            btnTic9.Enabled = true;

            btnTic1.Text = "";
            btnTic2.Text = "";
            btnTic3.Text = "";
            btnTic4.Text = "";
            btnTic5.Text = "";
            btnTic6.Text = "";
            btnTic7.Text = "";
            btnTic8.Text = "";
            btnTic9.Text = "";


            btnTic1.BackColor = Color.White;
            btnTic2.BackColor = Color.White;
            btnTic3.BackColor = Color.White;
            btnTic4.BackColor = Color.White;
            btnTic5.BackColor = Color.White;
            btnTic6.BackColor = Color.White;
            btnTic7.BackColor = Color.White;
            btnTic8.BackColor = Color.White;
            btnTic9.BackColor = Color.White;

        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DExit;
                DExit = MessageBox.Show("Confirm if you want to exit", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if( DExit == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}