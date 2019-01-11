using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHA_1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTheory_Click(object sender, EventArgs e)
        {
            Theory form = new Theory();
            form.ShowDialog();
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            Practice practice = new Practice();
            practice.ShowDialog();

            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
