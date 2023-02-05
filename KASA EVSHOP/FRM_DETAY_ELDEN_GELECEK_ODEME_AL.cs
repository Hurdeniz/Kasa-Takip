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
    public partial class FRM_DETAY_ELDEN_GELECEK_ODEME_AL : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DETAY_ELDEN_GELECEK_ODEME_AL()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();
        public int odeme_al_id;
        int durum = 2;
        private void FRM_DETAY_ELDEN_GELECEK_ODEME_AL_Load(object sender, EventArgs e)
        {
            btn_kaydet.Focus();

            timer1.Start();
            musteri_bilgileri();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_tarih.Text = DateTime.Now.ToShortDateString();
        }
        // MÜŞTERİ BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void musteri_bilgileri()
        {
            
            OleDbCommand kmt = new OleDbCommand("select * from elden_gelecek_gelen where id=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", odeme_al_id.ToString());

            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                txt_musteri_kodu.Text = oku["musteri_kodu"].ToString();
                txt_adi_soyadi.Text = oku["adi_soyadi"].ToString();
                txt_tutar.Text = oku["gelecek_tutar"].ToString();

            }

        }
        //KAYDET
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // VERİ GÜNCELLEME
        void kaydet()
        {


            OleDbTransaction islem = null;
            islem = bgl.baglanti().BeginTransaction();


            OleDbCommand kmt = new OleDbCommand("update elden_gelecek_gelen set odenen_tarih=@p1,gelen_tutar=@p2,durum=@p3 where id=@p4", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txt_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", txt_tutar.Text);
            kmt.Parameters.AddWithValue("@p3", durum.ToString());
            kmt.Parameters.Add("@p4", odeme_al_id.ToString());

            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                XtraMessageBox.Show("ÖDEME ALINMIŞTIR", "BAŞARILI", MessageBoxButtons.OK);

            }
            catch
            {
                islem.Rollback();
                XtraMessageBox.Show("ÖDEME ALINAMAMIŞTIR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();

            }


            // E-GELECEK FORMUNDAKİ GRİD YENİLEME

            FRM_DETAY_ELDEN_GELECEK frm_gelecek = (FRM_DETAY_ELDEN_GELECEK)Application.OpenForms["FRM_DETAY_ELDEN_GELECEK"];
            frm_gelecek.listele_elden_gelecek();

            //FORM KAPAT
            this.Close();


        }
    }
}