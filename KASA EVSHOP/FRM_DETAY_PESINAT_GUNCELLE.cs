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
    public partial class FRM_DETAY_PESINAT_GUNCELLE : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DETAY_PESINAT_GUNCELLE()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int pesinat_guncelle_kod;
        private void FRM_DETAY_PESINAT_GUNCELLE_Load(object sender, EventArgs e)
        {
            txt_musteri_kodu.Focus();
            pesinat_bilgiler();
        }
        // PEŞİNAT İŞLEM  BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void pesinat_bilgiler()
        {
            DateTime a;
            OleDbCommand kmt = new OleDbCommand("select * from kasa_pesinat_al where id=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", pesinat_guncelle_kod.ToString());

            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                txt_musteri_kodu.Text = oku["musteri_kodu"].ToString();
                txt_senet_no.Text = oku["senet_no"].ToString();
                txt_tutar.Text = oku["tutar"].ToString();
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


            OleDbCommand kmt = new OleDbCommand("update kasa_pesinat_al set musteri_kodu=@p1,senet_no=@p2,tutar=@p3,tarih=@p4 where id=@p5", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txt_musteri_kodu.Text);
            kmt.Parameters.AddWithValue("@p2", txt_senet_no.Text);
            kmt.Parameters.AddWithValue("@p3", txt_tutar.Text);
            kmt.Parameters.AddWithValue("@p4", date_tarih.Text);
            kmt.Parameters.Add("@p5", pesinat_guncelle_kod.ToString());

            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                XtraMessageBox.Show("PEŞİNAT İŞLEMİNİZ GÜNCELLENMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);

            }
            catch
            {
                islem.Rollback();
                XtraMessageBox.Show("PEŞİNAT İŞLEM GÜNCELLENEMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();

            }

            // DETAY PEŞİNAT FORMUNDAKİ GRİD YENİLEME

            FRM_DETAY_PESINAT frm_dty_pesinat = (FRM_DETAY_PESINAT)Application.OpenForms["FRM_DETAY_PESINAT"];
            frm_dty_pesinat.listele_pesinat();

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

        private void txt_tutar_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
    }
}