using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENTPORTAL_PROJECT.GUI
{
    public partial class WrongGUI : Form
    {
        private string text;
        public WrongGUI()
        {
            InitializeComponent();
        }
        public WrongGUI(String txt)
        {
            InitializeComponent();
            this.text = txt;
            label1.Text = text;
        }

        private void WrongGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
