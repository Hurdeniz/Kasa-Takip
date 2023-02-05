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
    public partial class FRM_PARA_YATIRMA : DevExpress.XtraEditors.XtraForm
    {
        public FRM_PARA_YATIRMA()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        private void FRM_PARA_YATIRMA_Load(object sender, EventArgs e)
        {
            date_tarih.Text = DateTime.Now.ToShortDateString();
            banka_bilgileri();
        }
        // BANKA BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void banka_bilgileri()
        {
            OleDbCommand kmt = new OleDbCommand("select banka_adi from bankalar", bgl.baglanti());
            OleDbDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                cmb_banka.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();



        }
        //KAYDET
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        //PARA YATRIMA KAYDETME
        void kaydet()
        {
            OleDbTransaction islem = null;
            islem = bgl.baglanti().BeginTransaction();


            OleDbCommand kmt = new OleDbCommand("insert into para_yatirma (tutar,tarih,banka) values (@p1,@p2,@p3)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txt_tutar.Text);
            kmt.Parameters.AddWithValue("@p2", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p3", cmb_banka.Text);

            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();

                XtraMessageBox.Show("PARA YATRIMA İŞLEMİNİZ YAPILMIŞTIR", "BAŞARILI", MessageBoxButtons.OK);
            }
            catch
            {
                islem.Rollback();
                XtraMessageBox.Show("PARA YATIRMA İŞLEMİNİZ GERÇEKLEŞMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();

            }
            txt_tutar.Focus();
            txt_tutar.Text = "";
            cmb_banka.Text = "";
        }

        private void txt_tutar_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void cmb_banka_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void date_tarih_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
    }
}