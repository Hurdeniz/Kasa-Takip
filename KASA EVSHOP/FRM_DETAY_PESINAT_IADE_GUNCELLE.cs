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
    public partial class FRM_DETAY_PESINAT_IADE_GUNCELLE : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DETAY_PESINAT_IADE_GUNCELLE()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int pesinat_iade_guncelle_kod;
        private void FRM_DETAY_PESINAT_IADE_GUNCELLE_Load(object sender, EventArgs e)
        {
            txt_musteri_kodu.Focus();
            pesinat_iade_bilgiler();
        }
        // PEŞİNAT İADE İŞLEM  BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void pesinat_iade_bilgiler()
        {
            DateTime a;
            OleDbCommand kmt = new OleDbCommand("select * from kasa_pesinat_iade where id=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", pesinat_iade_guncelle_kod.ToString());

            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                txt_musteri_kodu.Text = oku["musteri_kodu"].ToString();
                txt_senet_no.Text = oku["senet_no"].ToString();
               txt_islem_tutari.Text = oku["islem_tutari"].ToString();
                txt_iade_tutari.Text = oku["iade_tutari"].ToString();
                a =Convert.ToDateTime( oku["tarih"].ToString());
                date_tarih.Text = a.ToShortDateString();

            }
            bgl.baglanti().Close();

        }
        //KAYDET BUTONU
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // VERİ GÜNCELLEME
        void kaydet()
        {

            OleDbTransaction islem = null;
            islem = bgl.baglanti().BeginTransaction();


            OleDbCommand kmt = new OleDbCommand("update kasa_pesinat_iade set musteri_kodu=@p1,senet_no=@p2,islem_tutari=@p3,iade_tutari=@p4,tarih=@p5 where id=@p6", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txt_musteri_kodu.Text);
            kmt.Parameters.AddWithValue("@p2", txt_senet_no.Text);
            kmt.Parameters.AddWithValue("@p3", txt_islem_tutari.Text);
            kmt.Parameters.AddWithValue("@p4", txt_iade_tutari.Text);
            kmt.Parameters.AddWithValue("@p5", date_tarih.Text);
            kmt.Parameters.Add("@p6", pesinat_iade_guncelle_kod.ToString());

            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                XtraMessageBox.Show("PEŞİNAT İADE İŞLEMİNİZ GÜNCELLENMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);

            }
            catch
            {
                islem.Rollback();
                XtraMessageBox.Show("PEŞİNAT İADE İŞLEMİNİZ GÜNCELLENEMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();

            }

            // DETAY PEŞİNAT FORMUNDAKİ GRİD YENİLEME


            FRM_DETAY_PESINAT_IADE frm_dty_pesinat_iade = (FRM_DETAY_PESINAT_IADE)Application.OpenForms["FRM_DETAY_PESINAT_IADE"];
            frm_dty_pesinat_iade.listele_pesinat_iade();

            //FORM KAPAT
            this.Close();


        }

        private void date_tarih_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_musteri_kodu_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_senet_no_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_islem_tutari_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_iade_tutari_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
    }
}