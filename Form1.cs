using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkBox07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb1.Clear(); 
            tb1.AppendText(cb1.SelectedItem.ToString());
        }
    }
}
