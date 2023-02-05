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
    public partial class FRM_YENI_NOT : DevExpress.XtraEditors.XtraForm
    {
        public FRM_YENI_NOT()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int not_kullanici_kod;
        private void FRM_YENI_NOT_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tarih.Text = DateTime.Now.ToShortDateString();
        }
        //KAYDET
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        //VERİ KAYDETME
        void kaydet()
        {
            if (memo_aciklama.Text == "")
            {
                MessageBox.Show("LÜTFEN NOT GİRİNİZ.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                OleDbTransaction islem = null;
                islem = bgl.baglanti().BeginTransaction();


                OleDbCommand kmt = new OleDbCommand("insert into notlar (tarih,aciklama,kullanici_kodu) values (@p1,@p2,@p3)", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", lbl_tarih.Text);
                kmt.Parameters.AddWithValue("@p2", memo_aciklama.Text);
                kmt.Parameters.AddWithValue("@p3", not_kullanici_kod.ToString());


                try
                {
                    kmt.ExecuteNonQuery();
                    islem.Commit();
                    MessageBox.Show("YENİ NOT KAYDINIZ EKLENMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);
                }
                catch
                {
                    islem.Rollback();
                    MessageBox.Show("NOT KAYDINIZ YAPILAMAMIŞTIR LÜTFEN ALANLARI KONTROL EDİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bgl.baglanti().Close();

                }
                // NOTLAR FORMUNDAKİ GRİD YENİLEME

                FRM_ANA_SAYFA frm_not = (FRM_ANA_SAYFA)Application.OpenForms["FRM_ANA_SAYFA"];
                frm_not.listele_notlar();

                this.Hide();


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