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
    public partial class FRM_MASRAF : DevExpress.XtraEditors.XtraForm
    {
        public FRM_MASRAF()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int masraf_kullanici_kod;
        //FORM LOAD
        private void FRM_MASRAF_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        //TİMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tarih.Text = DateTime.Now.ToShortDateString();
        }
        //KAYDET BUTONU
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // VERİLERİ KAYDETME      
        public void kaydet()
        {


            OleDbTransaction islem = null;
            islem = bgl.baglanti().BeginTransaction();


            OleDbCommand kmt = new OleDbCommand("insert into kasa_masraf (tutar,aciklama,tarih,kullanici_kodu) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txt_tutar.Text);
            kmt.Parameters.AddWithValue("@p2", memo_aciklama.Text);
            kmt.Parameters.AddWithValue("@p3", lbl_tarih.Text);
            kmt.Parameters.AddWithValue("@p4", masraf_kullanici_kod.ToString());


            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                XtraMessageBox.Show("MASRAF ÇIKIŞINIZ YAPILMIŞTIR.", "BAŞARILI", MessageBoxButtons.OK);
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

            txt_tutar.Text = "0 ₺";
            memo_aciklama.Text = "";

            txt_tutar.Focus();

        }

        private void txt_tutar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void memo_aciklama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
    }
}