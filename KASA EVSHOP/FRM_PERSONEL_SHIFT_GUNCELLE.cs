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
    public partial class FRM_PERSONEL_SHIFT_GUNCELLE : DevExpress.XtraEditors.XtraForm
    {
        public FRM_PERSONEL_SHIFT_GUNCELLE()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int personel_shift_id;
        private void FRM_PERSONEL_SHIFT_GUNCELLE_Load(object sender, EventArgs e)
        {
            personel_bilgiler();
        }
        // PERSONEL  BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void personel_bilgiler()
        {

            OleDbCommand kmt = new OleDbCommand("select * from personel where id=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", personel_shift_id.ToString());
          
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                
                txt_adi_soyadi.Text = oku["adi_soyadi"].ToString();
                cmb_pazartesi.Text = oku["pazartesi"].ToString();
                cmb_sali.Text = oku["sali"].ToString();
                cmb_carsamba.Text = oku["carsamba"].ToString();
                cmb_persembe.Text = oku["persembe"].ToString();
                cmb_cuma.Text = oku["cuma"].ToString();
                cmb_cumartesi.Text = oku["cumartesi"].ToString();
                cmb_pazar.Text = oku["pazar"].ToString();


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


            OleDbCommand kmt = new OleDbCommand("update personel set pazartesi=@p1,sali=@p2,carsamba=@p3,persembe=@p4,cuma=@p5,cumartesi=@p6,pazar=@p7 where id=@p8", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", cmb_pazartesi.Text);
            kmt.Parameters.AddWithValue("@p2", cmb_sali.Text);
            kmt.Parameters.AddWithValue("@p3", cmb_carsamba.Text);
            kmt.Parameters.AddWithValue("@p4", cmb_persembe.Text);
            kmt.Parameters.AddWithValue("@p5", cmb_cuma.Text);
            kmt.Parameters.AddWithValue("@p6", cmb_cumartesi.Text);
            kmt.Parameters.AddWithValue("@p7", cmb_pazar.Text);
            kmt.Parameters.Add("@p8", personel_shift_id.ToString());

            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                XtraMessageBox.Show("SHİFT GÜNCELLENMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);

            }
            catch
            {
                islem.Rollback();
                XtraMessageBox.Show("SHİFT GÜNCELLENEMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();

            }

            // PERSONEL FORMUNDAKİ GRİD YENİLEME

            FRM_PERSONEL_SHIFT frm_shift = (FRM_PERSONEL_SHIFT)Application.OpenForms["FRM_PERSONEL_SHIFT"];
            frm_shift.listele_personel_shift();


            //FORM KAPAT
            this.Hide();


        }

        private void cmb_pazartesi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void cmb_sali_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void cmb_carsamba_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void cmb_persembe_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void cmb_cuma_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void cmb_cumartesi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void cmb_pazar_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
       
    }
}