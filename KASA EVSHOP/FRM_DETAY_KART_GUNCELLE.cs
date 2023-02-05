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
    public partial class FRM_DETAY_KART_GUNCELLE : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DETAY_KART_GUNCELLE()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int kart_guncelle_kod;
        private void FRM_DETAY_KART_GUNCELLE_Load(object sender, EventArgs e)
        {
            kart_bilgiler();
        }
        // KREDİ KART BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void kart_bilgiler()
        {
            DateTime a;
            OleDbCommand kmt = new OleDbCommand("select * from kasa_kredi_kart where id=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", kart_guncelle_kod.ToString());

            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                txt_garanti.Text = oku["garanti"].ToString();
                txt_yapikredi.Text = oku["yapikredi"].ToString();
                txt_finansbank.Text = oku["finansbank"].ToString();
                txt_is_bankasi.Text = oku["isbankasi"].ToString();
                txt_halkbank.Text = oku["halkbank"].ToString();
                txt_akbank.Text = oku["akbank"].ToString();
                a =Convert.ToDateTime( oku["tarih"].ToString());
                date_tarih.Text = a.ToShortDateString();
                

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


            OleDbCommand kmt = new OleDbCommand("update kasa_kredi_kart set garanti=@p1,yapikredi=@p2,finansbank=@p3,isbankasi=@p4,halkbank=@p5,akbank=@p6,tarih=@p7 where id=@p8", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txt_garanti.Text);
            kmt.Parameters.AddWithValue("@p2", txt_yapikredi.Text);
            kmt.Parameters.AddWithValue("@p3", txt_finansbank.Text);
            kmt.Parameters.AddWithValue("@p4", txt_is_bankasi.Text);
            kmt.Parameters.AddWithValue("@p5", txt_halkbank.Text);
            kmt.Parameters.AddWithValue("@p6", txt_akbank.Text);
            kmt.Parameters.AddWithValue("@p7", date_tarih.Text);
            kmt.Parameters.Add("@p8", kart_guncelle_kod.ToString());
            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                XtraMessageBox.Show("KREDİ KART İŞLEMİNİZ GÜNCELLENMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);

            }
            catch
            {
                islem.Rollback();
                XtraMessageBox.Show("KREDİ KART İŞLEM GÜNCELLENEMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();

            }

            // DETAY KART FORMUNDAKİ GRİD YENİLEME
            FRM_DETAY_KART frm_dty_kart = (FRM_DETAY_KART)Application.OpenForms["FRM_DETAY_KART"];
            frm_dty_kart.listele_kart();

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

        private void txt_garanti_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_yapikredi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_finansbank_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_is_bankasi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_halkbank_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_akbank_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
    }
}