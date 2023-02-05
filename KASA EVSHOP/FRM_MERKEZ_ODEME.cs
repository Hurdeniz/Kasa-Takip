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
    public partial class FRM_MERKEZ_ODEME : DevExpress.XtraEditors.XtraForm
    {
        public FRM_MERKEZ_ODEME()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        private void FRM_MERKEZ_ODEME_Load(object sender, EventArgs e)
        {
            txt_tutar.Focus();
            timer1.Start();
        }
        //TİMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tarih.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // MERKEZ ÖDEMESİ KAYDET
        void kaydet()
        {
            if (txt_tutar.Text == "")
            {
                XtraMessageBox.Show("LÜTFEN TUTAR GİRİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                OleDbTransaction islem = null;
                islem = bgl.baglanti().BeginTransaction();


                OleDbCommand kmt = new OleDbCommand("insert into merkez_odeme (tutar,aciklama,tarih) values (@p1,@p2,@p3)", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txt_tutar.Text);
                kmt.Parameters.AddWithValue("@p2", memo_aciklama.Text);
                kmt.Parameters.AddWithValue("@p3", lbl_tarih.Text);


                try
                {
                    kmt.ExecuteNonQuery();
                    islem.Commit();

                    XtraMessageBox.Show("MERKEZ ÖDEMENİZ YAPILMIŞTIR", "BAŞARILI", MessageBoxButtons.OK);
                }
                catch
                {
                    islem.Rollback();
                    XtraMessageBox.Show("MERKEZ ÖDEMENİZ YAPILAMAMIŞTIR LÜTFEN ALANLARI KONTROL EDİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bgl.baglanti().Close();

                }
                txt_tutar.Text = "";
                memo_aciklama.Text = "";
                txt_tutar.Focus();

            }

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