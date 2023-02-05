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
    public partial class FRM_KASA_ACIKLAR : DevExpress.XtraEditors.XtraForm
    {
        public FRM_KASA_ACIKLAR()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        private void FRM_KASA_ACIKLAR_Load(object sender, EventArgs e)
        {
            date_tarih.Text = DateTime.Now.ToShortDateString();
            txt_tutar.Focus();

            listele_aciklar();
            kullanici_bilgiler();
        }
        // KULLANICI BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void kullanici_bilgiler()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("select kullanici_adi from kullanici_giris",bag);
            OleDbDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {

                cmb_kullanici.Properties.Items.Add(dr[0]);

            }
            bag.Close();



        }
        // GRİD DOLDUR AÇIKLAR
        public void listele_aciklar()
        {
           
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select * from aciklar where tarih Order By tarih,id ASC ", bag);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            grid_aciklar.DataSource = dt;
            bag.Close();

            isim_aciklar();

            // TABLO EN SON VERİ SEÇME
            gridView1.FocusedRowHandle = gridView1.RowCount - 1;


            gridView1.Columns["tutar"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["tutar"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["tutar"].SummaryItem.Tag = 1;

        }
        //GRİD KOLON İSİM
        void isim_aciklar()
        {
            gridView1.Columns[0].Width = 40; // GRİD KOLON BOYUT


            gridView1.Columns[0].Caption = "ID";
            gridView1.Columns[1].Caption = "TARİH";
            gridView1.Columns[2].Caption = "TUTAR";
            gridView1.Columns[3].Caption = "PERSONEL";

        }
        // YENİ BUTONU
        int sayac = 1;
        private void btn_yeni_Click(object sender, EventArgs e)
        {
            if (sayac == 2)
            {
                panel_tarih.Visible = false;

                sayac = 1;
            }
            else
            {
                panel_tarih.Visible = true;
                sayac++;

            }
        }
        //sil
        private void btn_sil_Click(object sender, EventArgs e)
        {
            int id;

            // GRİD DEN VERİ ÇEKME

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["id"].ToString());
            //VERİ TABANINDAN SİLME İŞLEMİ

            DialogResult cevap;
            cevap = XtraMessageBox.Show("KAYIDI SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ ? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                bag.Open();
                OleDbCommand sil = new OleDbCommand("Delete from aciklar where id=" + id + " ", bag);
                sil.ExecuteNonQuery();
                bag.Close();
            }
            listele_aciklar();
        }
        //ARA
        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (sayac == 2)
            {
                gridView1.OptionsView.ShowAutoFilterRow = false;

                sayac = 1;
            }
            else
            {
                gridView1.OptionsView.ShowAutoFilterRow = true;
                sayac++;

            }
        }
        //KAYDET
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // VERİLERİ KAYDETME      
        public void kaydet()
        {

            OleDbTransaction islem = null;
            islem = bgl.baglanti().BeginTransaction();

            OleDbCommand kmt = new OleDbCommand("insert into aciklar (tarih,tutar,kullanici) values (@p1,@p2,@p3)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", txt_tutar.Text);
            kmt.Parameters.AddWithValue("@p3", cmb_kullanici.Text);

            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                XtraMessageBox.Show("KASA AÇIĞINIZ KAYDEDİLDİ..", "BAŞARILI", MessageBoxButtons.OK);
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
            listele_aciklar();
            txt_tutar.Text = "";
            txt_tutar.Focus();

        }
        //GUNCELLE
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (sayac == 2)
            {
                panel_guncelle.Visible = false;

                sayac = 1;
            }
            else
            {
                panel_guncelle.Visible = true;
                sayac++;

            }
        }
        // KAYDET GÜNCELLE
        private void btn_guncel_kaydet_Click(object sender, EventArgs e)
        {
            guncel_kaydet();
        }
        // VERİ GÜNCELLEME
        void guncel_kaydet()
        { 
            int id;

            // GRİD DEN VERİ ÇEKME

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["id"].ToString());

            OleDbTransaction islem = null;
            islem = bgl.baglanti().BeginTransaction();


            OleDbCommand kmt = new OleDbCommand("update aciklar set tutar=@p1 where id=@p2", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txt_tutar.Text);
            kmt.Parameters.Add("@p2", id.ToString());

            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                XtraMessageBox.Show("TUTAR GÜNCELENMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);

            }
            catch
            {
                islem.Rollback();
                XtraMessageBox.Show("TUTAR GÜNCELLENEMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();

            }
            listele_aciklar();

        }

        private void date_tarih_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_tutar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void cmb_kullanici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_guncel_tutar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guncel_kaydet();
            }
        }
    }
}