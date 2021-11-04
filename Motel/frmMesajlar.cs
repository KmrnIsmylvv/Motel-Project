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
    public partial class frmMesajlar : Form
    {
        public frmMesajlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-50U56HO;Initial Catalog=ParadiseMotel;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand emr = new SqlCommand("select * from Mesajlar", baglanti);
            SqlDataReader oxu = emr.ExecuteReader();

            while (oxu.Read())
            {
                ListViewItem elaveet = new ListViewItem();
                elaveet.Text = oxu["Mesajid"].ToString();
                elaveet.SubItems.Add(oxu["Adsoyad"].ToString());
                elaveet.SubItems.Add(oxu["Mesaj"].ToString());
                listView1.Items.Add(elaveet);
            }
            baglanti.Close();
        }
        private void btnYaddaSaxla_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand emr = new SqlCommand("insert into Mesajlar (Adsoyad,Mesaj) values ('" + txtAdSoyad.Text + "','" + rtxMesaj.Text + "')", baglanti);
            emr.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void frmMesajlar_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdSoyad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            rtxMesaj.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
