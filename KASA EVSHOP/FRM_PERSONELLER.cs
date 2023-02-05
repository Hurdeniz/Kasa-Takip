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
    public partial class FRM_PERSONELLER : DevExpress.XtraEditors.XtraForm
    {
        public FRM_PERSONELLER()
        {
            InitializeComponent();
        }

        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");

        private void FRM_PERSONELLER_Load(object sender, EventArgs e)
        {
            listele_personel();
        }
        // GRİD DOLDUR PERSONEL
        public void listele_personel()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select id,tc,adi_soyadi,maas,telefon,telefon2,e_mail,gorevi,bolumu,giris_tarih,il,ilce,adres from personel where durum=@p1 Order By giris_tarih,id ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1",1);

            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_taksit.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.FocusedRowHandle = gridView1.RowCount - 1;

            //PERSONEL SAYI
            gridView1.Columns["id"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            gridView1.Columns["id"].SummaryItem.Tag = 1;
            //MAAS
            gridView1.Columns["maas"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["maas"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["maas"].SummaryItem.Tag = 1;
        }
        //GRİD KOLON İSİM
        void isim()
        {
            gridView1.Columns[0].Width = 40; // GRİD KOLON BOYUT
            gridView1.Columns[12].Width = 130;

            gridView1.Columns[0].Caption = "ID";
            gridView1.Columns[1].Caption = "T.C. KİMLİK NO";
            gridView1.Columns[2].Caption = "ADI SOYADI";
            gridView1.Columns[3].Caption = "MAAŞ";
            gridView1.Columns[4].Caption = "TELEFON";
            gridView1.Columns[5].Caption = "TELEFON 2";
            gridView1.Columns[6].Caption = "E-POSTA";           
            gridView1.Columns[7].Caption = "GÖREVİ";
            gridView1.Columns[8].Caption = "BÖLÜMÜ";
            gridView1.Columns[9].Caption = "GİRİŞ TARİHİ";
            gridView1.Columns[10].Caption = "İL";
            gridView1.Columns[11].Caption = "İLÇE";
            gridView1.Columns[12].Caption = "ADRES";
        


        }
        //YENİ
        private void btn_yeni_Click(object sender, EventArgs e)
        {
            FRM_PERSONEL_YENI frm_yeni = new FRM_PERSONEL_YENI();
            frm_yeni.Show();
        }
        //SİL
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
                OleDbCommand sil = new OleDbCommand("Delete from personel where id=" + id + " ", bag);
                sil.ExecuteNonQuery();
                bag.Close();
            }
            listele_personel();
        }
        // GÜNCELLE
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            // GUNCELLE FORMUNA ID GÖNDERME

            FRM_PERSONEL_GUNCELLE frm_personel_guncelle = new FRM_PERSONEL_GUNCELLE();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frm_personel_guncelle.personel_id = int.Parse(dr["id"].ToString());

            }

            frm_personel_guncelle.Show();
        }
        //ARA BUTONU
        int sayac = 1;
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
        //YENİLE
        private void btn_yenile_Click(object sender, EventArgs e)
        {
            listele_personel();
        }
        //ÇIKIŞ VER
        private void btn_cikis_ver_Click(object sender, EventArgs e)
        {
            // ÇIKIŞ VER FORMUNA ID GÖNDERME


            FRM_PERSONEL_CIKIS_VER frm_personel_cikis = new FRM_PERSONEL_CIKIS_VER();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frm_personel_cikis.cikis_personel_id = int.Parse(dr["id"].ToString());

            }

            frm_personel_cikis.Show();
        }
        //ÇIKIŞLAR
        private void btn_cikislar_Click(object sender, EventArgs e)
        {
            FRM_PERSONEL_CIKISLAR frm_cikislar = new FRM_PERSONEL_CIKISLAR();
            frm_cikislar.Show();
        }
        //ÜCRETLER
        private void btn_maaslar_Click(object sender, EventArgs e)
        {
            FRM_PERSONEL_MAAS frm_ucretler = new FRM_PERSONEL_MAAS();
            frm_ucretler.Show();
        }
    }
}