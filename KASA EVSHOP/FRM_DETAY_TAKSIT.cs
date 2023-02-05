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
    public partial class FRM_DETAY_TAKSIT : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DETAY_TAKSIT()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");

        public int taksit_dty_kod;
        public string taksit_dty_kullanici;
        private void FRM_DETAY_TAKSIT_Load(object sender, EventArgs e)
        {
            btn_filtre.Focus();

            date_baslangic.Text = DateTime.Now.ToShortDateString();
            date_bitis.Text = DateTime.Now.ToShortDateString();

            listele_kasa_goster();
        }
        // GRİD DOLDUR KASA GİRİŞLERİ
        void listele_kasa_goster()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select id,musteri_kodu,odenen_tutar,tahsilat_tutari,tarih,saat from kasa_taksit where kullanici_kodu=@p3 and tarih BETWEEN @tar1 and @tar2 Order By tarih,id ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p3", taksit_dty_kod.ToString());
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);

            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_taksit.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.FocusedRowHandle = gridView1.RowCount - 1;


            gridView1.Columns["tahsilat_tutari"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["tahsilat_tutari"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["tahsilat_tutari"].SummaryItem.Tag = 1;



        }     
        //GRİD KOLON İSİM
        void isim()
        {
            gridView1.Columns[0].Width = 40; // GRİD KOLON BOYUT


            gridView1.Columns[0].Caption = "ID";
            gridView1.Columns[1].Caption = "MÜŞTERİ KODU";
            gridView1.Columns[2].Caption = "ÖDENEN TUTAR";
            gridView1.Columns[3].Caption = "TAHSİLAT TUTAR";
            gridView1.Columns[4].Caption = "TARİH";
            gridView1.Columns[5].Caption = "SAAT";


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
        // TİMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        // SİL BUTONU
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
                OleDbCommand sil = new OleDbCommand("Delete from kasa_taksit where id=" + id + " ", bag);
                sil.ExecuteNonQuery();
                bag.Close();

            }
            listele_kasa_goster();
        }
        //ARA BUTONU
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
        // EXCEL BUTONU
        private void btn_excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(save.FileName + ".xlsx");
            }
        }
        //GÖSTER BUTONU
        private void btn_goster_Click(object sender, EventArgs e)
        {
            listele_kasa_goster();
        }

        private void date_baslangic_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_kasa_goster();
            }
        }

        private void date_bitis_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_kasa_goster();
            }
        }
        
    }
}