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
    public partial class FRM_PERSONEL_CIKISLAR : DevExpress.XtraEditors.XtraForm
    {
        public FRM_PERSONEL_CIKISLAR()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");
        private void FRM_PERSONEL_CIKISLAR_Load(object sender, EventArgs e)
        {
            listele_personel();
        }
        // GRİD DOLDUR PERSONEL
        public void listele_personel()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select id,tc,adi_soyadi,telefon,gorevi,bolumu,giris_tarih,cikis_tarih from personel where durum=@p1 Order By cikis_tarih,id ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", 2);

            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_taksit.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.FocusedRowHandle = gridView1.RowCount - 1;


            gridView1.Columns["id"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            gridView1.Columns["id"].SummaryItem.Tag = 1;
        }
        //GRİD KOLON İSİM
        void isim()
        {
            gridView1.Columns[0].Width = 40; // GRİD KOLON BOYUT

            gridView1.Columns[0].Caption = "ID";
            gridView1.Columns[1].Caption = "T.C. KİMLİK NO";
            gridView1.Columns[2].Caption = "ADI SOYADI";
            gridView1.Columns[3].Caption = "TELEFON";
            gridView1.Columns[4].Caption = "GÖREVİ";
            gridView1.Columns[5].Caption = "BÖLÜMÜ";
            gridView1.Columns[6].Caption = "GİRİŞ TARİHİ";
            gridView1.Columns[7].Caption = "ÇIKIŞ TARİHİ";




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
    }
}