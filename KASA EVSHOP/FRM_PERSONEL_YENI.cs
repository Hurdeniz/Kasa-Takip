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
    public partial class FRM_PERSONEL_YENI : DevExpress.XtraEditors.XtraForm
    {
        public FRM_PERSONEL_YENI()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        private void FRM_PERSONEL_YENI_Load(object sender, EventArgs e)
        {
            date_tarih.Text = DateTime.Now.ToShortDateString();
            gorev_bilgileri();
            bolum_bilgileri();
        }
        // GÖREVLERİ VERİ TABANINDAN ÇEKME
        public void gorev_bilgileri()
        {
            OleDbCommand kmt = new OleDbCommand("select gorev from gorev", bgl.baglanti());
            OleDbDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                cmb_gorev.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();



        }
        // BÖLÜMLERİ VERİ TABANINDAN ÇEKME
        public void bolum_bilgileri()
        {
            OleDbCommand kmt = new OleDbCommand("select bolum from bolum", bgl.baglanti());
            OleDbDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                cmb_bolum.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();



        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // AYNI VERİ ENGELLEME
        bool durum;
        public void control()
        {
            OleDbCommand kmt = new OleDbCommand("select * from personel where tc=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txt_tc.Text);
            OleDbDataReader oku = kmt.ExecuteReader();
            if (oku.Read())
            {
                durum = true;
            }
            else
            {
                durum = false;
            }



        }
        // VERİLERİ KAYDETME      
        public void kaydet()
        {
               control();
               if (durum == false)
               {

                   OleDbTransaction islem = null;
                   islem = bgl.baglanti().BeginTransaction();


                   OleDbCommand kmt = new OleDbCommand("insert into personel (tc,adi_soyadi,maas,telefon,telefon2,e_mail,il,ilce,adres,gorevi,bolumu,giris_tarih,durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)", bgl.baglanti());
                   kmt.Parameters.AddWithValue("@p1", txt_tc.Text);
                   kmt.Parameters.AddWithValue("@p2", txt_adi_soyadi.Text);
                   kmt.Parameters.AddWithValue("@p2", txt_maas.Text);
                   kmt.Parameters.AddWithValue("@p4", txt_telefon.Text);
                   kmt.Parameters.AddWithValue("@p5", txt_telefon2.Text);
                   kmt.Parameters.AddWithValue("@p6", txt_e_mail.Text);
                   kmt.Parameters.AddWithValue("@p7", txt_il.Text);
                   kmt.Parameters.AddWithValue("@p8", cmb_ilce.Text);
                   kmt.Parameters.AddWithValue("@p9", memo_adres.Text);
                   kmt.Parameters.AddWithValue("@p10", cmb_gorev.Text);
                   kmt.Parameters.AddWithValue("@p11", cmb_bolum.Text);
                   kmt.Parameters.AddWithValue("@p12", date_tarih.Text);
                   kmt.Parameters.AddWithValue("@p13", 1);


                   try
                   {
                       kmt.ExecuteNonQuery();
                       islem.Commit();
                       XtraMessageBox.Show("YENİ PERSONEL KAYIT EDİLMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);
                   }
                   catch
                   {
                       islem.Rollback();
                       XtraMessageBox.Show("LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
                   finally
                   {
                       bgl.baglanti().Close();

                   }

                   // PERSONEL FORMUNDAKİ GRİD YENİLEME


                   FRM_PERSONELLER frm_personel = (FRM_PERSONELLER)Application.OpenForms["FRM_PERSONELLER"];
                   frm_personel.listele_personel();


                   //FORM KAPAT
                   this.Hide();

               }
               else
               {
                   MessageBox.Show("KAYITLI PERSONEL LÜTFEN KONTROL EDİNİZ ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }

        }

        private void date_tarih_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_tc_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_adi_soyadi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void cmb_gorev_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void cmb_bolum_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_telefon_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_telefon2_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_e_mail_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void memo_adres_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_maas_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txt_il_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txt_il_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_maas_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void cmb_ilce_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
       
    }
}