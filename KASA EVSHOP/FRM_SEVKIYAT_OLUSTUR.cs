using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;

namespace KASA_EVSHOP
{
    public partial class FRM_SEVKIYAT_OLUSTUR : DevExpress.XtraEditors.XtraForm
    {
        public FRM_SEVKIYAT_OLUSTUR()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        private void FRM_SEVKIYAT_OLUSTUR_Load(object sender, EventArgs e)
        {
            sevkiyat1();
            sevkiyat2();
        }

        // SEVKİYAT İSMİ VERI TABANINDAN ÇEKME
        public void sevkiyat1()
        {
            OleDbCommand kmt = new OleDbCommand("Select * from sevkiyatci where kullanici_kod=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", 1);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
               btn_sevkiyat1.Text = oku["adi_soyadi"].ToString();

            }


        }
        public void sevkiyat2()
        {
            OleDbCommand kmt = new OleDbCommand("Select * from sevkiyatci where kullanici_kod=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", 2);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                btn_sevkiyat2.Text = oku["adi_soyadi"].ToString();

            }

        }

        private void btn_sevkiyat1_Click(object sender, EventArgs e)
        {
            FRM_SEVKIYAT_1 frm_sevkiyat_1 = new FRM_SEVKIYAT_1();
            frm_sevkiyat_1.Text = btn_sevkiyat1.Text + " SEVKİYAT LİSTESİ";
            frm_sevkiyat_1.Show();
        }

        private void btn_sevkiyat2_Click(object sender, EventArgs e)
        {
            FRM_SEVKIYAT_2 frm_sevkiyat_2 = new FRM_SEVKIYAT_2();
            frm_sevkiyat_2.Text = btn_sevkiyat2.Text + " SOR LİSTESİ";
            frm_sevkiyat_2.Show();
        }
    }
}