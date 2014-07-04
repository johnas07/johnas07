using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace escobar
{
    public partial class johnas : Form
    {
        public johnas()
        {
            InitializeComponent();
        }

        private void johnas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            escobar form = new escobar();
            form.form1 = this;
            form.ShowDialog();
        }
    }
}
