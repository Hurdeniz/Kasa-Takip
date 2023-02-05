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
    public partial class FRM_KULLANICI_GIRIS : DevExpress.XtraEditors.XtraForm
    {
        public FRM_KULLANICI_GIRIS()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        private void btn_giris_Click(object sender, EventArgs e)
        {
            giris();
        }
        // KULLANICI GİRİŞ YETKİSİ
        void giris()
        {
            if (comboBoxEdit1.Text == "")// EĞER KULLANICI BOŞ İSE
            {

                XtraMessageBox.Show("LÜTFEN KULLANICI ADI VE ŞİFRE GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_sifre.Text == "")// EĞER ŞİFRE BOŞ İSE
            {
                XtraMessageBox.Show("LÜTFEN ŞİFRE GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OleDbCommand kmt = new OleDbCommand("select * from kullanici_giris where kullanici_adi=@p1 and sifre=@p2 ", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", comboBoxEdit1.Text);
                kmt.Parameters.AddWithValue("@p2", txt_sifre.Text);
                OleDbDataReader dr = kmt.ExecuteReader();
                if (dr.Read())
                {
                    int sayi;

                    sayi = Convert.ToInt32(dr["yetki"].ToString());// KULLANICI GİRİŞ YETKİSİ



                    FRM_MAIN frm_main = new FRM_MAIN();
                    frm_main.kullanici_adi = comboBoxEdit1.Text;
                    frm_main.yetki = Convert.ToInt32(sayi.ToString());
                    frm_main.Show();



                    this.Hide();
                }

                else
                {
                    XtraMessageBox.Show("KULLANICI VEYA ŞİFRE HATALI", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_sifre.Text = "";
                }
            }
        }
      

        private void FRM_KULLANICI_GIRIS_Load(object sender, EventArgs e)
        {
            kullanici_bilgiler();
        }
        // KULLANICI BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void kullanici_bilgiler()
        {
            OleDbCommand kmt = new OleDbCommand("select kullanici_adi from kullanici_giris", bgl.baglanti());
            OleDbDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit1.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();



        }

        private void comboBoxEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                giris();
            } 
        }

        private void txt_sifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                giris();
            } 
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}