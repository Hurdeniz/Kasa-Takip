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
    public partial class FRM_DETAY_FIRMA_ODEME_GUNCELLE : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DETAY_FIRMA_ODEME_GUNCELLE()
        {
            InitializeComponent();
        } 
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int firma_odeme_guncelle_kod;

        private void FRM_DETAY_FIRMA_ODEME_GUNCELLE_Load(object sender, EventArgs e)
        {
            txt_firma_adi.Focus();
            firma_odeme_bilgiler();
        }
        // FİRMA ÖDEME  BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void firma_odeme_bilgiler()
        {

            OleDbCommand kmt = new OleDbCommand("select * from firma_odemesi where id=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", firma_odeme_guncelle_kod.ToString());
            DateTime a;
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                a = Convert.ToDateTime(oku["tarih"].ToString());
                date_tarih.Text = a.ToShortDateString();
                txt_tutar.Text = oku["tutar"].ToString();
                memo_aciklama.Text = oku["aciklama"].ToString();
                txt_firma_adi.Text = oku["firma_adi"].ToString();

            }
            bgl.baglanti().Close();

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // VERİ GÜNCELLEME
        void kaydet()
        {

            OleDbTransaction islem = null;
            islem = bgl.baglanti().BeginTransaction();


            OleDbCommand kmt = new OleDbCommand("update firma_odemesi set tarih=@p1,tutar=@p2,aciklama=@p3,firma_adi=@p4 where id=@p5", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", txt_tutar.Text);
            kmt.Parameters.AddWithValue("@p3", memo_aciklama.Text);
            kmt.Parameters.AddWithValue("@p4", txt_firma_adi.Text);
            kmt.Parameters.Add("@p5", firma_odeme_guncelle_kod.ToString());

            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                XtraMessageBox.Show("FİRMA ÖDEME BİLGİLERİNİZ GÜNCELLENMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);

            }
            catch
            {
                islem.Rollback();
                XtraMessageBox.Show("FİRMA ÖDEME BİLGİLERİNİZ GÜNCELLENEMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();

            }

            // MASRAF DETAY FORMUNDAKİ GRİD YENİLEME

            FRM_DETAY_FIRMA_ODEME frm_dty_firma_odeme = (FRM_DETAY_FIRMA_ODEME)Application.OpenForms["FRM_DETAY_FIRMA_ODEME"];
            frm_dty_firma_odeme.listele_firma_odeme();

            //FORM KAPAT
            this.Close();


        }

        private void date_tarih_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void date_tarih_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_firma_adi_KeyDown(object sender, KeyEventArgs e)
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

        private void memo_aciklama_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
    }
}