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
    public partial class FRM_DETAY_E_GELECEK : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DETAY_E_GELECEK()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");

        public int e_gelecek_dty_kod;
        int durum = 1;
        private void FRM_DETAY_E_GELECEK_Load(object sender, EventArgs e)
        {
            listele_e_gelecek();
        }
        // GRİD DOLDUR E GELECEK
        void listele_e_gelecek()
        {
          

            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select id,islem,musteri_kodu,senet_no,adi_soyadi,gelecek_tutar,islem_tarih,aciklama from elden_gelecek_gelen where durum=@p1 and kullanici_kodu=@p2  Order By islem_tarih,id ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", durum.ToString());
            adt.SelectCommand.Parameters.AddWithValue("@p2", e_gelecek_dty_kod.ToString());           
            

            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_taksit.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.FocusedRowHandle = gridView1.RowCount - 1;


            gridView1.Columns["gelecek_tutar"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["gelecek_tutar"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["gelecek_tutar"].SummaryItem.Tag = 1;



        }
        //GRİD KOLON İSİM
        void isim()
        {
            gridView1.Columns[0].Width = 35; // GRİD KOLON BOYUT


            gridView1.Columns[0].Caption = "ID";
            gridView1.Columns[1].Caption = "İŞLEM TİPİ";
            gridView1.Columns[2].Caption = "MÜŞTERİ KODU";
            gridView1.Columns[3].Caption = "SENET NO";
            gridView1.Columns[4].Caption = "ADI SOYADI";
            gridView1.Columns[5].Caption = "TUTAR";
            gridView1.Columns[6].Caption = "TARİH";
            gridView1.Columns[7].Caption = "AÇIKLAMA";


        }
    }
}