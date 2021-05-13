using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathone
{
    public partial class TestLoginForm : Form
    {
        public TestLoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager.MainFrame.Navigate(new RunnerPage());
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager.MainFrame.Navigate(new PersonalPage());
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager.MainFrame.Navigate(new SponsorPage2());
            Close();
        }
    }
}
