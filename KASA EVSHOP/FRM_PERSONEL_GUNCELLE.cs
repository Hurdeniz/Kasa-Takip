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
    public partial class FRM_PERSONEL_GUNCELLE : DevExpress.XtraEditors.XtraForm
    {
        public FRM_PERSONEL_GUNCELLE()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int personel_id;

        private void FRM_PERSONEL_GUNCELLE_Load(object sender, EventArgs e)
        {
            
            gorev_bilgileri();
            bolum_bilgileri();
            personel_bilgiler();
        }
        // PERSONEL  BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void personel_bilgiler()
        {

            OleDbCommand kmt = new OleDbCommand("select * from personel where id=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", personel_id.ToString());
            DateTime a;
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                a = Convert.ToDateTime(oku["giris_tarih"].ToString());
                date_tarih.Text = a.ToShortDateString();
                txt_tc.Text = oku["tc"].ToString();
                txt_adi_soyadi.Text = oku["adi_soyadi"].ToString();
                txt_maas.Text = oku["maas"].ToString();
                txt_telefon.Text = oku["telefon"].ToString();
                txt_telefon2.Text = oku["telefon2"].ToString();
                txt_e_mail.Text = oku["e_mail"].ToString();
                txt_il.Text = oku["il"].ToString();
                cmb_ilce.Text = oku["ilce"].ToString();
                memo_adres.Text = oku["adres"].ToString();
                cmb_gorev.Text = oku["gorevi"].ToString();
                cmb_bolum.Text = oku["bolumu"].ToString();


            }
            bgl.baglanti().Close();

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
        // KAYDET
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // VERİ GÜNCELLEME
        void kaydet()
        {

            OleDbTransaction islem = null;
            islem = bgl.baglanti().BeginTransaction();


            OleDbCommand kmt = new OleDbCommand("update personel set tc=@p1,adi_soyadi=@p2,maas=@p3,telefon=@p4,telefon2=@p5,e_mail=@p6,il=@p7,ilce=@p8,adres=@p9,gorevi=@p10,bolumu=@p11,giris_tarih=@p12 where id=@p13", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txt_tc.Text);
            kmt.Parameters.AddWithValue("@p2", txt_adi_soyadi.Text);
            kmt.Parameters.AddWithValue("@p3", txt_maas.Text);
            kmt.Parameters.AddWithValue("@p4", txt_telefon.Text);
            kmt.Parameters.AddWithValue("@p5", txt_telefon2.Text);
            kmt.Parameters.AddWithValue("@p6", txt_e_mail.Text);
            kmt.Parameters.AddWithValue("@p7", txt_il.Text);
            kmt.Parameters.AddWithValue("@p8", cmb_ilce.Text);
            kmt.Parameters.AddWithValue("@p9", memo_adres.Text);
            kmt.Parameters.AddWithValue("@p10", cmb_gorev.Text);
            kmt.Parameters.AddWithValue("@p11", cmb_bolum.Text);
            kmt.Parameters.AddWithValue("@p12", date_tarih.Text);
            kmt.Parameters.Add("@p13", personel_id.ToString());

            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                XtraMessageBox.Show("PERSONEL GÜNCELLENMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);

            }
            catch
            {
                islem.Rollback();
                XtraMessageBox.Show("PERSONEL GÜNCELLENEMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}