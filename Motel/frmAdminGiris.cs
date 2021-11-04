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
    public partial class frmAdminGiris : Form
    {
        public frmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-50U56HO;Initial Catalog=ParadiseMotel;Integrated Security=True");
        private void btnDaxilOl_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where Istifadeci=@Istifadeciadi AND Sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("Istifadeciadi", txtIstifadeciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", txtSifre.Text.Trim());
                SqlCommand emr = new SqlCommand(sql, baglanti);
                emr.Parameters.Add(prm1);
                emr.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(emr);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    frmAnaSehife fr = new frmAnaSehife();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("İstifadəçi adı və ya Şifrə Yanlışdır. Yenidən cəhd edin :(");
            }
        }

        private void frmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
