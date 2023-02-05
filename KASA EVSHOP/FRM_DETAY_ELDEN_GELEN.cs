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
    public partial class FRM_DETAY_ELDEN_GELEN : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DETAY_ELDEN_GELEN()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");
        int durum = 2;
        private void FRM_DETAY_ELDEN_GELEN_Load(object sender, EventArgs e)
        {
            listele_elden_gelen();
        }
        // GRİD DOLDUR ELDEN GELEN ÖDEMELER
        public void listele_elden_gelen()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select id,islem,senet_no,musteri_kodu,adi_soyadi,islem_tarih,islem_tutari,odenen_tarih,gelen_tutar,kullanici_adi from elden_gelecek_gelen where durum=@p1 Order By odenen_tarih,id ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", durum.ToString());
            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_taksit.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.FocusedRowHandle = gridView1.RowCount - 1;

            //GELECEK TUTAR TOPLAM
            gridView1.Columns["gelen_tutar"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["gelen_tutar"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["gelen_tutar"].SummaryItem.Tag = 1;



        }
        //GRİD KOLON İSİM
        void isim()
        {
            gridView1.Columns[0].Width = 35; // GRİD KOLON BOYUT
           

            gridView1.Columns[0].Caption = "ID";
            gridView1.Columns[1].Caption = "İŞLEM TİPİ";
            gridView1.Columns[2].Caption = "SENET NO";
            gridView1.Columns[3].Caption = "MÜŞTERİ KODU";
            gridView1.Columns[4].Caption = "ADI SOYADI";
            gridView1.Columns[5].Caption = "İŞLEM TARİHİ";
            gridView1.Columns[6].Caption = "İŞLEM TUTARI";
            gridView1.Columns[7].Caption = "ÖDENEN TARİH";
            gridView1.Columns[8].Caption = "GELEN TUTAR";
            gridView1.Columns[9].Caption = "KASA";
           


        }
        //GRİD VERİLERİ TEXTBOX AKTARMA
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {

                txt_musteri_kodu.Text =  dr["musteri_kodu"].ToString();
                txt_adi_soyadi.Text = dr["adi_soyadi"].ToString();
                txt_tutar.Text = dr["gelen_tutar"].ToString();
               
            }
            

        }
        //SİL
        private void btn_sil_Click(object sender, EventArgs e)
        {
            int id;
            // GRİD DEN VERİ ÇEKME
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["id"].ToString());

            // VERİ TABANINDAN SİLME İŞLEMİ
            DialogResult cevap;
            cevap = XtraMessageBox.Show("Kayıdı Silmek İstediğinizden Emin Misiniz ? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                bag.Open();
                OleDbCommand sil = new OleDbCommand("Delete from elden_gelecek_gelen where id=@p1", bag);
                sil.Parameters.AddWithValue("@p1", id.ToString());
                sil.ExecuteNonQuery();
                bag.Close();
            }
            listele_elden_gelen();
        }
    }
}