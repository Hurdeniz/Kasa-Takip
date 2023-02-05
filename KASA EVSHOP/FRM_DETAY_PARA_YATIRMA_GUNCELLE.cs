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
    public partial class FRM_DETAY_PARA_YATIRMA_GUNCELLE : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DETAY_PARA_YATIRMA_GUNCELLE()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int para_yatirma_guncelle_kod;
        private void FRM_DETAY_PARA_YATIRMA_GUNCELLE_Load(object sender, EventArgs e)
        {
            banka_bilgileri();
        }
        // PARA YATIRMA BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void banka_bilgileri()
        {
            DateTime a;
            OleDbCommand kmt = new OleDbCommand("select * from para_yatirma where id=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", para_yatirma_guncelle_kod.ToString());

            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                a =Convert.ToDateTime( oku["tarih"].ToString());
                date_tarih.Text = a.ToShortDateString();
                txt_tutar.Text = oku["tutar"].ToString();
                txt_banka.Text = oku["banka"].ToString();

            }
            bgl.baglanti().Close();

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


            OleDbCommand kmt = new OleDbCommand("update para_yatirma set tarih=@p1,tutar=@p2,banka=@p3 where id=@p4", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", txt_tutar.Text);
            kmt.Parameters.AddWithValue("@p3", txt_banka.Text);
            kmt.Parameters.Add("@p4", para_yatirma_guncelle_kod.ToString());

            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                XtraMessageBox.Show("PARA YATIRMA BİLGİLERİNİZ GÜNCELLENMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);

            }
            catch
            {
                islem.Rollback();
                XtraMessageBox.Show("PARA YATRIMA BİLGİLERİNİZ GÜNCELLENEMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();

            }

            // PARA YATIRMA DETAY FORMUNDAKİ GRİD YENİLEME


            FRM_DETAY_PARA_YATIRMA frm_dty_para_yatirma = (FRM_DETAY_PARA_YATIRMA)Application.OpenForms["FRM_DETAY_PARA_YATIRMA"];
            frm_dty_para_yatirma.listele_göster();

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

        private void txt_tutar_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_banka_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
    }
}