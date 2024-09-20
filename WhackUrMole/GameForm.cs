using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhackUrMoleLib;

namespace WhackUrMole
{
    public partial class GameForm : Form
    {
        Renderer r;
        Game gameState;
        string username;
        public GameForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Form1_Paint(object sender, EventArgs e)
        {

            r = new Renderer(Canvas);
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void hideButtons()
        {
            easyDiffButton.Hide();
            middleDiffButton.Hide();
            hardDiffButton.Hide();
            label5.Hide();

            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
        }
        private void easyDiffButton_Click(object sender, EventArgs e)
        {
            hideButtons();
            DifficultyEasy df = new DifficultyEasy();
            gameState = new Game(Canvas, df, label1, label2);
            gameState.initTheHoles();
            gameState.Start();
        }

        private void middleDiffButton_Click(object sender, EventArgs e)
        {
            hideButtons();
            DifficultyNormal df = new DifficultyNormal();
            gameState = new Game(Canvas, df, label1, label2);
            gameState.initTheHoles();
            gameState.Start();


        }

        private void hardDiffButton_Click(object sender, EventArgs e)
        {
            hideButtons();
            DifficultyHard df = new DifficultyHard();
            gameState = new Game(Canvas, df, label1, label2);
            gameState.initTheHoles();
            gameState.Start();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        // I would listen for the timer to end directly
        // but my forms use a different version of a timer
        // without the "elapsed" method
        private void label2_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(label2.Text) == 0)
            {
                int finalScore = Int32.Parse(label1.Text) * gameState.difficulty.scoreModifier;
                
                
                if(finalScore < 0)
                {
                    finalScore = 0;
                }

                DashboardControls records = new DashboardControls();
                User user = new User(username, finalScore.ToString(), gameState.difficulty.name);
                records.AddRecord(user);
                MessageBox.Show($"Game over! \nyour score: {finalScore}");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
