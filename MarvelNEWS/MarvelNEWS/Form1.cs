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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BlackPanther bp = new BlackPanther();
            bp.StartPosition = FormStartPosition.CenterScreen;
            bp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            infinitywar inf = new infinitywar();
            inf.StartPosition = FormStartPosition.CenterScreen;
            inf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AntWasp aw = new AntWasp();
            aw.StartPosition = FormStartPosition.CenterScreen;
            aw.Show();
        }
    }
}
