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
    public partial class FRM_SIFRE_DEGISTIR : DevExpress.XtraEditors.XtraForm
    {
        public FRM_SIFRE_DEGISTIR()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int kullanici_kod_sifre;
        private void FRM_SIFRE_DEGISTIR_Load(object sender, EventArgs e)
        {
            txt_sifre.Focus();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
       //VERİ GÜNCELLEME
        void kaydet()
        {
            if (txt_sifre.Text == "")
            {
                MessageBox.Show("LÜTFEN YENİ ŞİFRE GİRİNİZ.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                OleDbTransaction islem = null;
                islem = bgl.baglanti().BeginTransaction();


                OleDbCommand kmt = new OleDbCommand("update kullanici_giris set sifre=@p1 where kullanici_kodu=@p2", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txt_sifre.Text);
                kmt.Parameters.Add("@p2", kullanici_kod_sifre.ToString());

                try
                {
                    kmt.ExecuteNonQuery();
                    islem.Commit();
                    MessageBox.Show("ŞİFRE GÜNCELLENMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);

                }
                catch
                {
                    islem.Rollback();
                    MessageBox.Show("ŞİFRE GÜNCELLEME YAPILAMAMIŞTIR LÜTFEN TEKRAR DENEYİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bgl.baglanti().Close();

                }
                bgl.baglanti().Close();      
                this.Close();

            }
        
        }

        private void txt_sifre_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            } 
        }
    }
}