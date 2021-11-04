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
    public partial class frmErzaqKommunal : Form
    {
        public frmErzaqKommunal()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-50U56HO;Initial Catalog=ParadiseMotel;Integrated Security=True");
        
        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand emr = new SqlCommand("select *from Stoklar", baglanti);
            SqlDataReader oxu = emr.ExecuteReader();
            while (oxu.Read())
            {
                ListViewItem elaveet = new ListViewItem();
                elaveet.Text = oxu["Qida"].ToString();
                elaveet.SubItems.Add(oxu["Icki"].ToString());
                elaveet.SubItems.Add(oxu["Cerez"].ToString());
                listView1.Items.Add(elaveet);
            }
            baglanti.Close();
        }

        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand emr2 = new SqlCommand("select *from Kommunal", baglanti);
            SqlDataReader oxu2 = emr2.ExecuteReader();
            while (oxu2.Read())
            {
                ListViewItem elaveet = new ListViewItem();
                elaveet.Text = oxu2["Isiq"].ToString();
                elaveet.SubItems.Add(oxu2["Su"].ToString());
                elaveet.SubItems.Add(oxu2["Internet"].ToString());
                listView2.Items.Add(elaveet);
            }
            baglanti.Close();
        }
        private void btnYaddaSaxla_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand emr = new SqlCommand("insert into Stoklar (Qida,Icki,Cerez) values('" + txtQidaMeblegi.Text + "','" + txtİckiMeblegi.Text + "','" + txtCerezMeblegi.Text + "')", baglanti);
            emr.ExecuteNonQuery();
            baglanti.Close();
            veriler();
            
        }

        private void frmErzaq_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void btnKommunalYaddaSaxla_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand emr2 = new SqlCommand("insert into Kommunal (Isiq,Su,Internet) values('" + txtIsiq.Text + "','" + txtSu.Text + "','" + txtInternet.Text + "')", baglanti);
            emr2.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
        }
    }
}
