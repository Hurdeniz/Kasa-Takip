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
    public partial class FRM_DETAY_PESIN_GUNCELLE : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DETAY_PESIN_GUNCELLE()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int pesin_guncelle_kod;
        private void FRM_DETAY_PESIN_GUNCELLE_Load(object sender, EventArgs e)
        {
            txt_musteri_kodu.Focus();

            pesin_bilgiler();
        }
        // PEŞİN İŞLEM  BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void pesin_bilgiler()
        {
            DateTime a;
            OleDbCommand kmt = new OleDbCommand("select * from kasa_pesin where id=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", pesin_guncelle_kod.ToString());

            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                txt_musteri_kodu.Text = oku["musteri_kodu"].ToString();
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


            OleDbCommand kmt = new OleDbCommand("update kasa_pesin set musteri_kodu=@p1,tutar=@p2,tarih=@p3 where id=@p4", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txt_musteri_kodu.Text);
            kmt.Parameters.AddWithValue("@p2", txt_tutar.Text);
            kmt.Parameters.AddWithValue("@p3", date_tarih.Text);
            kmt.Parameters.Add("@p4", pesin_guncelle_kod.ToString());

            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                XtraMessageBox.Show("PEŞİN İŞLEMİNİZ GÜNCELLENMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);

            }
            catch
            {
                islem.Rollback();
                XtraMessageBox.Show("PEŞİN İŞLEM GÜNCELLENEMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();

            }
                
                // DETAY PEŞİN FORMUNDAKİ GRİD YENİLEME
            FRM_DETAY_PESIN frm_dty_pesin = (FRM_DETAY_PESIN)Application.OpenForms["FRM_DETAY_PESIN"];
            frm_dty_pesin.listele_pesin();

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