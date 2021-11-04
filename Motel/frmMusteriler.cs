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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-50U56HO;Initial Catalog=ParadiseMotel;Integrated Security=True");

        public void verilerigoster(string veriler)
        {
            
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster("select * from MusteriElaveEt");

        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand emr = new SqlCommand("delete from MusteriElaveEt where Adi=@adi", baglanti);
            emr.Parameters.AddWithValue("@adi", txtSilinecekMelumat.Text);         
            emr.ExecuteNonQuery();
            verilerigoster("select * From MusteriElaveEt");
            baglanti.Close();
            txtSilinecekMelumat.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand emr = new SqlCommand("Select *From MusteriElaveEt where Adi like '%" + txtAxtarilacaqMelumat.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(emr);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
