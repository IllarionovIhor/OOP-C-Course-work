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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DashboardControls board = new DashboardControls();
            board.showTableRecords(RecordsTable);
        }
    }
}
