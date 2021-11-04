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
    public partial class frmAnaSehife : Form
    {
        public frmAnaSehife()
        {
            InitializeComponent();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            frmAdminGiris fr = new frmAdminGiris();
            fr.Show();
            this.Hide();

        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            frmYeniMusteri fr = new frmYeniMusteri();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOtaqlar fr = new frmOtaqlar();
            fr.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMusteriler fr = new frmMusteriler();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paradise Motel qeydiyyat proqramı by Kamran İsmayılov 2021");
        }

        private void frmAnaSehife_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenfeet_Click(object sender, EventArgs e)
        {
            frmMenfeet fr = new frmMenfeet();
            fr.Show();
        }

        private void btnErzaq_Click(object sender, EventArgs e)
        {
            frmErzaqKommunal fr = new frmErzaqKommunal();
            fr.Show();
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            frmRadio fr = new frmRadio();
            fr.Show();
        }

        private void btnQezetler_Click(object sender, EventArgs e)
        {
            frmQazet fr = new frmQazet();
            fr.Show();
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            frmSifreGuncelle fr = new frmSifreGuncelle();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMesajlar fr = new frmMesajlar();
            fr.Show();
        }
    }
}
