using System.Collections;
using System.Reflection;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool checker;
        int plusOne;
        int[][] winOptions = { 
            new[] { 1, 2, 3 }, 
            new[] { 4, 5, 6 }, 
            new[] { 7, 8, 9 }, 
            new[] { 1, 4, 7 }, 
            new[] { 2, 5, 8 }, 
            new[] { 3, 6, 9 }, 
            new[] { 1, 5, 9 }, 
            new[] { 3, 5, 7 } };

        ArrayList cellsActiveX = new ArrayList();
        ArrayList cellsActiveO = new ArrayList();
        ArrayList winCellsX = new ArrayList();
        ArrayList winCellsO = new ArrayList();


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
            int cellSelected = Convert.ToInt32(btnSelected.Name.Last().ToString());
            if (checker && btnSelected.Text == string.Empty)
            {
                btnSelected.Text = "O";
                checker = false;
                cellsActiveO.Add(cellSelected);
            }
            else if(!checker && btnSelected.Text == string.Empty)
            {
                btnSelected.Text = "X";
                checker = true;
                cellsActiveX.Add(cellSelected);
            }
            EvalGame();
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
                DExit = MessageBox.Show("Confirm if you want to exit", "TicTacToe", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (DExit == DialogResult.Yes)
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
            foreach (var field in this.GetType().GetFields())
            {
                if (field.Name.Contains("btnTic"))
                {
                    Button myButton = (Button)field.GetValue(this);
                    myButton.Enabled = true;
                    myButton.Text = "";
                    myButton.BackColor = Color.White;
                }
            }
            cellsActiveX.Clear();
            cellsActiveO.Clear();
            winCellsX.Clear();
            winCellsO.Clear();

        }
        void EnableFalse()
        {
             foreach (var field in this.GetType().GetFields())
            {
                if (field.Name.Contains("btnTic"))
                {
                    Button myButton = (Button)field.GetValue(this);
                    myButton.Enabled = false;
                }
            }

        }

        void EvalGame()
        {
            foreach (var win in winOptions)
            {
                foreach (var itemWin in win)
                {
                    if (cellsActiveX.Contains(itemWin))
                    {
                        winCellsX.Add(itemWin);
                    }
                    if (cellsActiveO.Contains(itemWin))
                    {
                        winCellsO.Add(itemWin);
                    }
                }
                if (winCellsX.Count == 3)
                {
                    MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (var cell in winCellsX)
                    {
                        var field = this.GetType().GetField($"btnTic{cell.ToString()}");
                        Button myButton = (Button)field.GetValue(this);

                        myButton.BackColor = Color.PowderBlue;

                    }
                    plusOne = int.Parse(lblWinsPlayerX.Text);
                    plusOne++;
                    lblWinsPlayerX.Text = Convert.ToString(plusOne);
                    EnableFalse(); ;
                    break;
                }
                if (winCellsO.Count == 3)

                {
                    MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (var cell in winCellsO)
                    {
                        var field = this.GetType().GetField($"btnTic{cell.ToString()}");
                        Button myButton = (Button)field.GetValue(this);

                        myButton.BackColor = Color.PowderBlue;

                    }
                    plusOne = int.Parse(lblWinsPlayerO.Text);
                    plusOne++;
                    lblWinsPlayerO.Text = Convert.ToString(plusOne);
                    EnableFalse();

                    break;
                }
                winCellsX.Clear();
                winCellsO.Clear();
            }
            var totalCells = cellsActiveO.Count + cellsActiveX.Count;
            if (totalCells == 9)
            {

                MessageBox.Show("The game ended tied", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (var field in this.GetType().GetFields())
                {
                    if (field.Name.Contains("btnTic"))
                    {
                        Button myButton = (Button)field.GetValue(this);

                        myButton.BackColor = Color.PowderBlue;
                        myButton.Enabled = false;
                    }
                }           
            }
        }

    }
}