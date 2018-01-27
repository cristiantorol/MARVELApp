using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarvelNEWS
{
    public partial class infinitywar : Form
    {
        public infinitywar()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=aAoKqx9wb1I");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
}
