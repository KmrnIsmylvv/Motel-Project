using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Motel
{
    public partial class frmMenfeet : Form
    {
        public frmMenfeet()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-50U56HO;Initial Catalog=ParadiseMotel;Integrated Security=True");
        private void frmMenfeet_Load(object sender, EventArgs e)
        {
            //Umumi gelir
            baglanti.Open();
            SqlCommand emr = new SqlCommand(" select sum(Mebleg) as toplam from MusteriElaveEt", baglanti);
            SqlDataReader oxu = emr.ExecuteReader();
            while (oxu.Read())
            {
                lblUmumiMebleg.Text = oxu["toplam"].ToString();
            }
            baglanti.Close();

            //Qida
            baglanti.Open();
            SqlCommand emr2 = new SqlCommand(" Select sum(Qida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oxu2 = emr2.ExecuteReader();
            while (oxu2.Read())
            {
                lblErzaqXerci1.Text = oxu2["toplam1"].ToString();
            }
            baglanti.Close();

            //Icki
            baglanti.Open();
            SqlCommand emr3 = new SqlCommand(" Select sum(Icki) as toplam2 from Stoklar", baglanti);
            SqlDataReader oxu3= emr3.ExecuteReader();
            while (oxu3.Read())
            {
                lblErzaqXerci2.Text = oxu3["toplam2"].ToString();
            }
            baglanti.Close();

            //Cerez
            baglanti.Open();
            SqlCommand emr4 = new SqlCommand(" Select sum(Cerez) as toplam3 from Stoklar", baglanti);
            SqlDataReader oxu4 = emr4.ExecuteReader();
            while (oxu4.Read())
            {
                lblErzaqXerci3.Text = oxu4["toplam3"].ToString();
            }
            baglanti.Close();

            //Isiq
            baglanti.Open();
            SqlCommand emr5 = new SqlCommand(" Select sum(Isiq) as toplam4 from Kommunal", baglanti);
            SqlDataReader oxu5 = emr5.ExecuteReader();
            while (oxu5.Read())
            {
                lblKommunalXercler1.Text = oxu5["toplam4"].ToString();
            }
            baglanti.Close();

            //Su
            baglanti.Open();
            SqlCommand emr6 = new SqlCommand(" Select sum(Su) as toplam5 from Kommunal", baglanti);
            SqlDataReader oxu6 = emr6.ExecuteReader();
            while (oxu6.Read())
            {
                lblKommunalXercler2.Text = oxu6["toplam5"].ToString();
            }
            baglanti.Close();

            //Internet
            baglanti.Open();
            SqlCommand emr7 = new SqlCommand(" Select sum(Internet) as toplam6 from Kommunal", baglanti);
            SqlDataReader oxu7 = emr7.ExecuteReader();
            while (oxu7.Read())
            {
                lblKommunalXercler3.Text = oxu7["toplam6"].ToString();
            }
            baglanti.Close();
        }

        private void btnHesabla_Click(object sender, EventArgs e)
        {
            int isci;
            isci = Convert.ToInt16(txtIsciSayi.Text);
            lblIsciMaaslari.Text = (isci * 300).ToString();

            int menfeet;
            menfeet = Convert.ToInt32(lblUmumiMebleg.Text) - (Convert.ToInt16(lblIsciMaaslari.Text) + Convert.ToInt16(lblErzaqXerci1.Text) + Convert.ToInt16(lblErzaqXerci2.Text) + Convert.ToInt16(lblErzaqXerci3.Text) + Convert.ToInt16(lblKommunalXercler1.Text) + Convert.ToInt16(lblKommunalXercler2.Text) + Convert.ToInt16(lblKommunalXercler3.Text));
            lblMenfeet.Text = menfeet.ToString();
        }
    }
}
