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
    public partial class FRM_RAPOR_KASA_DETAY : DevExpress.XtraEditors.XtraForm
    {
        public FRM_RAPOR_KASA_DETAY()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");
        private void FRM_RAPOR_KASA_DETAY_Load(object sender, EventArgs e)
        {
            date_baslangic.Text = DateTime.Now.ToShortDateString();
            date_bitis.Text = DateTime.Now.ToShortDateString();
            listele_gunluk_kasa_detay();
        }
        // GRİD DOLDUR GUNLUK KASA
        public void listele_gunluk_kasa_detay()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select * from gunluk_kasa  where tarih BETWEEN @tar1 and @tar2 Order By tarih ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_taksit.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.FocusedRowHandle = gridView1.RowCount - 1;
            //TOPLAM KASA
            gridView1.Columns["toplam_kasa"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["toplam_kasa"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["toplam_kasa"].SummaryItem.Tag = 1;
            
        }
        //GRİD KOLON İSİM
        void isim()
        {
            gridView1.Columns[0].Width = 40; // GRİD KOLON BOYUT


            gridView1.Columns[0].Caption = "ID";
            gridView1.Columns[1].Caption = "KASA";
            gridView1.Columns[2].Caption = "DEVİR";
            gridView1.Columns[3].Caption = "E-GELEN";
            gridView1.Columns[4].Caption = "E-GELECEK";
            gridView1.Columns[5].Caption = "MERKEZ ÖDEME";
            gridView1.Columns[6].Caption = "FİRMA ÖDEME";
            gridView1.Columns[7].Caption = "PARA YATIRMA";
            gridView1.Columns[8].Caption = "TOPLAM KASA";
            gridView1.Columns[9].Caption = "TARİH";
            gridView1.Columns[10].Caption = "AÇIKLAMA";



        }
        // FİLTRE BUTONU
        int sayac = 1;
        private void btn_filtre_Click(object sender, EventArgs e)
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
                OleDbCommand sil = new OleDbCommand("Delete from gunluk_kasa where id=" + id + " ", bag);
                sil.ExecuteNonQuery();
                bag.Close();

            }
            listele_gunluk_kasa_detay();
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
        //EXCEL
        private void btn_excel_Click(object sender, EventArgs e)
        {

        }
        //GÖSTER
        private void btn_goster_Click(object sender, EventArgs e)
        {
            listele_gunluk_kasa_detay();
        }

        private void date_baslangic_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_gunluk_kasa_detay();
            }
        }

        private void date_bitis_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_gunluk_kasa_detay();
            }
        }
    }
}