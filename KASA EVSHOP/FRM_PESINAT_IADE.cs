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
    public partial class FRM_PESINAT_IADE : DevExpress.XtraEditors.XtraForm
    {
        public FRM_PESINAT_IADE()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int pesinat_iade_kullanici_kod;
        //FORM LOAD
        private void FRM_PESINAT_IADE_Load(object sender, EventArgs e)
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


            OleDbCommand kmt = new OleDbCommand("insert into kasa_pesinat_iade (musteri_kodu,senet_no,islem_tutari,iade_tutari,tarih,kullanici_kodu) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txt_musteri_kodu.Text);
            kmt.Parameters.AddWithValue("@p2", txt_senet_no.Text);
            kmt.Parameters.AddWithValue("@p3", txt_islem_tutari.Text);
            kmt.Parameters.AddWithValue("@p4", txt_iade_tutari.Text);
            kmt.Parameters.AddWithValue("@p5", lbl_tarih.Text);
            kmt.Parameters.AddWithValue("@p6", pesinat_iade_kullanici_kod.ToString());


            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                XtraMessageBox.Show("PEŞİNAT İADE İŞEMİNİZ YAPILMIŞTIR", "BAŞARILI", MessageBoxButtons.OK);
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

            txt_musteri_kodu.Text = "0";
            txt_senet_no.Text = "0";
            txt_islem_tutari.Text = "0";
            txt_iade_tutari.Text = "0";

            txt_musteri_kodu.Focus();

        }
        //ENTER TUSU
        private void txt_musteri_kodu_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
        //ENTER TUSU
        private void txt_senet_no_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
        //ENTER TUSU
        private void txt_islem_tutari_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
        //ENTER TUSU
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