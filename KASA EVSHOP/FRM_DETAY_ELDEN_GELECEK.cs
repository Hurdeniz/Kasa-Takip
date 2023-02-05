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
    public partial class FRM_DETAY_ELDEN_GELECEK : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DETAY_ELDEN_GELECEK()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");
        int durum = 1;
        private void FRM_DETAY_ELDEN_GELECEK_Load(object sender, EventArgs e)
        {
            listele_elden_gelecek();
        }
        // GRİD DOLDUR ELDEN GELECEK ÖDEMELER
        public void listele_elden_gelecek()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select id,islem,senet_no,musteri_kodu,adi_soyadi,islem_tutari,odenen_tutar,gelecek_tutar,islem_tarih,kullanici_adi,aciklama from elden_gelecek_gelen where durum=@p1 Order By islem_tarih,id ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", durum.ToString());
            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_taksit.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.FocusedRowHandle = gridView1.RowCount - 1;

            //GELECEK TUTAR TOPLAM
            gridView1.Columns["gelecek_tutar"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["gelecek_tutar"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["gelecek_tutar"].SummaryItem.Tag = 1;
          


        }
        //GRİD KOLON İSİM
        void isim()
        {
            gridView1.Columns[0].Width = 35; // GRİD KOLON BOYUT
            gridView1.Columns[10].Width = 100;

            gridView1.Columns[0].Caption = "ID";
            gridView1.Columns[1].Caption = "İŞLEM";
            gridView1.Columns[2].Caption = "SENET NO";
            gridView1.Columns[3].Caption = "MÜŞTERİ KODU";
            gridView1.Columns[4].Caption = "ADI SOYADI";
            gridView1.Columns[5].Caption = "İŞLEM TUTARI";
            gridView1.Columns[6].Caption = "ÖDENEN TUTAR";
            gridView1.Columns[7].Caption = "GELECEK TUTAR";
            gridView1.Columns[8].Caption = "TARİH";
            gridView1.Columns[9].Caption = "KASA";
            gridView1.Columns[10].Caption = "AÇIKLAMA";
           

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
            listele_elden_gelecek();
        }
        //GÜNCELLE
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            // GÜNCELLE FORMUNA ID GÖNDERME

            FRM_DETAY_ELDEN_GELECEK_GUNCELLE frm_guncelle_elden_odeme = new FRM_DETAY_ELDEN_GELECEK_GUNCELLE();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frm_guncelle_elden_odeme.elden_gelecek_guncelle_id = int.Parse(dr["id"].ToString());

            }

            frm_guncelle_elden_odeme.Show();
        }
        //EXCEL
        private void btn_excel_Click(object sender, EventArgs e)
        {
            //Yeni bir dialog kayıt penceresi açıyoruz.
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) //Pencerede kayıt düğmesine basıldıysa
            {
                gridView1.ExportToHtml(save.FileName + ".html"); //İstediğimiz formatlarda dışarı aktarıyoruz.
                gridView1.ExportToMht(save.FileName + ".mth");
                gridView1.ExportToPdf(save.FileName + ".pdf");
                gridView1.ExportToRtf(save.FileName + ".rtf");
                gridView1.ExportToText(save.FileName + ".txt");
                gridView1.ExportToXls(save.FileName + ".xls");
                gridView1.ExportToXlsx(save.FileName + ".xlsx");
               
            }

        }
        //ÖDEME AL
        private void btn_odeme_al_Click(object sender, EventArgs e)
        {
            // ELDEN ÖDEME AL FORMUNA ID GÖNDERME

            FRM_DETAY_ELDEN_GELECEK_ODEME_AL frm_odeme = new FRM_DETAY_ELDEN_GELECEK_ODEME_AL();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frm_odeme.odeme_al_id = int.Parse(dr["id"].ToString());

            }

            frm_odeme.Show();
        }
        //KISMI ÖDEME
        private void btn_kismi_odeme_Click(object sender, EventArgs e)
        {
            // KISMI ODEME AL FORMUNA ID GÖNDERME

            FRM_DETAY_ELDEN_GELECEK_KISMI_ODEME frm_kismi_odeme = new FRM_DETAY_ELDEN_GELECEK_KISMI_ODEME();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frm_kismi_odeme.kismi_odeme_al_id = int.Parse(dr["id"].ToString());

            }

            frm_kismi_odeme.Show();

        }
        //GRİD VERİLERİ TEXTBOX AKTARMA
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {

                txt_musteri_kodu.Text = dr["musteri_kodu"].ToString();
                txt_adi_soyadi.Text = dr["adi_soyadi"].ToString();
                txt_tutar.Text = dr["gelecek_tutar"].ToString();

            }
        }
    }
}