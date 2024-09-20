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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rules rl = new Rules();
            rl.Show();
        }

        private void gameLink_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            GameForm gf = new GameForm(username);
            gf.Show();
        }

        private void recordBoardLink_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
        }

        private void usernameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
