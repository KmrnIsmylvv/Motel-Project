using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motel
{
    public partial class frmQazet : Form
    {
        public frmQazet()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://qafqazinfo.az/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milli.az/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.azerbaijan-news.az/");
        }

        private void frmQazet_Load(object sender, EventArgs e)
        {

        }
    }
}
