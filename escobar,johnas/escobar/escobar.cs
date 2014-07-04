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
    public partial class escobar : Form
    {
        public johnas form1 = new johnas();
        public escobar()
        {
            InitializeComponent();
        }

        private void escobar_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            form1.button1.Text = (int.Parse(form1.button1.Text) + int.Parse(textBox1.Text)).ToString();
        }
    }
}
