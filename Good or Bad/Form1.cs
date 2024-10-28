using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_or_Bad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            imgGood.Visible = true;
        }

        private void btnBad_Click(object sender, EventArgs e)
        {
            imgBad.Visible = true;
        }
    }
}
