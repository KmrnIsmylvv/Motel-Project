﻿using System;
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
    public partial class frmOtaqlar : Form
    {
        public frmOtaqlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-50U56HO;Initial Catalog=ParadiseMotel;Integrated Security=True");
        private void frmOtaqlar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand emr1 = new SqlCommand("select * from Otaq101", baglanti);
            SqlDataReader oxu1 = emr1.ExecuteReader();
            while (oxu1.Read())
            {
                btnOtaq101.Text = oxu1["Adi"].ToString() +" "+ oxu1["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btnOtaq101.Text != "101")
            {
                btnOtaq101.BackColor = Color.Red;
            }
            baglanti.Open();
            SqlCommand emr2 = new SqlCommand("select * from Otaq102", baglanti);
            SqlDataReader oxu2 = emr2.ExecuteReader();
            while (oxu2.Read())
            {
                btnOtaq102.Text = oxu2["Adi"].ToString() + " " + oxu2["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btnOtaq102.Text != "102")
            {
                btnOtaq102.BackColor = Color.Red;
            }
            baglanti.Open();
            SqlCommand emr3 = new SqlCommand("select * from Otaq103", baglanti);
            SqlDataReader oxu3 = emr3.ExecuteReader();
            while (oxu3.Read())
            {
                btnOtaq103.Text = oxu3["Adi"].ToString() + " " + oxu3["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btnOtaq103.Text != "103")
            {
                btnOtaq103.BackColor = Color.Red;
            }
            baglanti.Open();
            SqlCommand emr4 = new SqlCommand("select * from Otaq104", baglanti);
            SqlDataReader oxu4 = emr4.ExecuteReader();
            while (oxu4.Read())
            {
                btnOtaq104.Text = oxu4["Adi"].ToString() + " " + oxu4["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btnOtaq104.Text != "104")
            {
                btnOtaq104.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand emr5 = new SqlCommand("select * from Otaq105", baglanti);
            SqlDataReader oxu5 = emr5.ExecuteReader();
            while (oxu5.Read())
            {
                btnOtaq105.Text = oxu5["Adi"].ToString() + " " + oxu5["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btnOtaq105.Text != "105")
            {
                btnOtaq105.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand emr6 = new SqlCommand("select * from Otaq106", baglanti);
            SqlDataReader oxu6 = emr6.ExecuteReader();
            while (oxu6.Read())
            {
                btnOtaq106.Text = oxu6["Adi"].ToString() + " " + oxu6["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btnOtaq106.Text != "106")
            {
                btnOtaq106.BackColor = Color.Red;
            }
            baglanti.Open();
            SqlCommand emr7 = new SqlCommand("select * from Otaq107", baglanti);
            SqlDataReader oxu7 = emr7.ExecuteReader();
            while (oxu7.Read())
            {
                btnOtaq107.Text = oxu7["Adi"].ToString() + " " + oxu7["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btnOtaq107.Text != "107")
            {
                btnOtaq107.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand emr8 = new SqlCommand("select * from Otaq108", baglanti);
            SqlDataReader oxu8 = emr8.ExecuteReader();
            while (oxu8.Read())
            {
                btnOtaq108.Text = oxu8["Adi"].ToString() + " " + oxu8["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btnOtaq108.Text != "108")
            {
                btnOtaq108.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand emr9 = new SqlCommand("select * from Otaq109", baglanti);
            SqlDataReader oxu9 = emr9.ExecuteReader();
            while (oxu9.Read())
            {
                btnOtaq109.Text = oxu9["Adi"].ToString() + " " + oxu9["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btnOtaq109.Text != "109")
            {
                btnOtaq109.BackColor = Color.Red;
            }
        }

        private void btnOtaq102_Click(object sender, EventArgs e)
        {

        }

        private void btnOtaq103_Click(object sender, EventArgs e)
        {

        }

        private void btnOtaq106_Click(object sender, EventArgs e)
        {

        }

        private void btnOtaq101_Click(object sender, EventArgs e)
        {

        }

        private void btnOtaq104_Click(object sender, EventArgs e)
        {

        }

        private void btnOtaq105_Click(object sender, EventArgs e)
        {

        }

        private void btnOtaq108_Click(object sender, EventArgs e)
        {

        }

        private void btnOtaq109_Click(object sender, EventArgs e)
        {

        }

        private void btnOtaq107_Click(object sender, EventArgs e)
        {

        }
    }
}
