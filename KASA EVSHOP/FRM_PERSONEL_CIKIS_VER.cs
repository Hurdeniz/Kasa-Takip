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
    public partial class FRM_PERSONEL_CIKIS_VER : DevExpress.XtraEditors.XtraForm
    {
        public FRM_PERSONEL_CIKIS_VER()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int cikis_personel_id;
        private void FRM_PERSONEL_CIKIS_VER_Load(object sender, EventArgs e)
        {
            date_cikis.Text = DateTime.Now.ToShortDateString();
            personel_bilgiler();

        }
        // PERSONEL  BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void personel_bilgiler()
        {

            OleDbCommand kmt = new OleDbCommand("select * from personel where id=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", cikis_personel_id.ToString());
            DateTime a;
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                a = Convert.ToDateTime(oku["giris_tarih"].ToString());
                date_tarih.Text = a.ToShortDateString();              
                txt_adi_soyadi.Text = oku["adi_soyadi"].ToString();

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


            OleDbCommand kmt = new OleDbCommand("update personel set durum=@p1,cikis_tarih=@p2 where id=@p3", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", 2);
            kmt.Parameters.AddWithValue("@p2", date_cikis.Text);
            kmt.Parameters.Add("@p3", cikis_personel_id.ToString());

            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                XtraMessageBox.Show("PERSONEL ÇIKIŞINIZ YAPILMIŞTIR", "BAŞARILI", MessageBoxButtons.OK);

            }
            catch
            {
                islem.Rollback();
                XtraMessageBox.Show("PERSONEL ÇIKIŞINIZ YAPILMAMIŞTIR", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();

            }

            // PERSONEL FORMUNDAKİ GRİD YENİLEME

            FRM_PERSONELLER frm_personel = (FRM_PERSONELLER)Application.OpenForms["FRM_PERSONELLER"];
            frm_personel.listele_personel();


            //FORM KAPAT
            this.Hide();


        }

        private void date_cikis_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
    }
}