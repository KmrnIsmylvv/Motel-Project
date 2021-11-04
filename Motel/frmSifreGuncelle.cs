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
    public partial class frmSifreGuncelle : Form
    {
        public frmSifreGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-50U56HO;Initial Catalog=ParadiseMotel;Integrated Security=True");
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand emr = new SqlCommand("update AdminGiris set Istifadeci='" + txtIstifadeciAdi.Text + "',Sifre='" + txtSifre.Text + "'", baglanti);
            emr.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncəlləmə uğurla tamamlandı :)");
        }

        private void frmSifreGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
