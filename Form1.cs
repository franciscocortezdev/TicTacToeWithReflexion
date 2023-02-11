using System.Reflection;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool checker;
        int plusOne;

        void EnableFalse()
        {
            for (int i = 1; i<10; i++)
            {
                FieldInfo myField = this.GetType().GetField($"btnTic{i}");
                Button myButton = (Button)myField.GetValue(this);
                myButton.Enabled = false;
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
            ResetValues();
            lblWinsPlayerX.Text = "0";
            lblWinsPlayerO.Text = "0";
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DExit;
                DExit = MessageBox.Show("Confirm if you want to exit", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (DExit == DialogResult.OK)
                {
                    Application.Exit();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        public void ResetValues()
        {
            for (int i = 1; i < 10; i++)
            {
                FieldInfo myField = this.GetType().GetField($"btnTic{i}");

                Button myButton = (Button)myField.GetValue(this);

                myButton.Enabled = true;
                myButton.Text = "";
                myButton.BackColor = Color.White;
            }
        }

        void Score()
        {
            if (btnTic1.Text == "X" && btnTic2.Text == "X" && btnTic3.Text == "X")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic2.BackColor = Color.PowderBlue;
                btnTic3.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}