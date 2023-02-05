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
    public partial class FRM_DETAY_KART : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DETAY_KART()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");

        public int kart_dty_kod;

        private void FRM_DETAY_KART_Load(object sender, EventArgs e)
        {
            btn_filtre.Focus();

            date_baslangic.Text = DateTime.Now.ToShortDateString();
            date_bitis.Text = DateTime.Now.ToShortDateString();

            listele_kart();
        }
        // GRİD DOLDUR KREDİ KARTI İŞLEMLERİ
        public void listele_kart()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select id,garanti,yapikredi,finansbank,isbankasi,halkbank,akbank,tarih from kasa_kredi_kart where kullanici_kod=@p3 and tarih BETWEEN @tar1 and @tar2 Order By tarih,id ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p3", kart_dty_kod.ToString());
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);

            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_taksit.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.FocusedRowHandle = gridView1.RowCount - 1;

            //GARANTİ TOPLAM
            gridView1.Columns["garanti"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["garanti"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["garanti"].SummaryItem.Tag = 1;
            //YAPIKREDİ TOPLAM
            gridView1.Columns["yapikredi"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["yapikredi"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["yapikredi"].SummaryItem.Tag = 1;
            //FİNANSBAK TOPLAM
            gridView1.Columns["finansbank"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["finansbank"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["finansbank"].SummaryItem.Tag = 1;
            //İŞBANKASI TOPLAM
            gridView1.Columns["isbankasi"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["isbankasi"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["isbankasi"].SummaryItem.Tag = 1;
            //HALKBANK TOPLAM
            gridView1.Columns["halkbank"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["halkbank"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["halkbank"].SummaryItem.Tag = 1;
            //AKBANK TOPLAM
            gridView1.Columns["akbank"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["akbank"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["akbank"].SummaryItem.Tag = 1;


        }
        //GRİD KOLON İSİM
        void isim()
        {
            gridView1.Columns[0].Width = 40; // GRİD KOLON BOYUT


            gridView1.Columns[0].Caption = "ID";
            gridView1.Columns[1].Caption = "GARANTİ";
            gridView1.Columns[2].Caption = "YAPIKREDİ";
            gridView1.Columns[3].Caption = "FİNANSBANK";
            gridView1.Columns[4].Caption = "İŞ BANKASI";
            gridView1.Columns[5].Caption = "HALKBANK";
            gridView1.Columns[6].Caption = "AKBANK";
            gridView1.Columns[7].Caption = "TARİH";


        }
        //GÖSTER BUTONU
        private void btn_goster_Click(object sender, EventArgs e)
        {
            listele_kart();
        }
        //SİL BUTONU
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
                OleDbCommand sil = new OleDbCommand("Delete from kasa_kredi_kart where id=" + id + " ", bag);
                sil.ExecuteNonQuery();
                bag.Close();
            }
            listele_kart();
        }
        // FİLTRE BUTONU
        int sayac_filtre = 1;
        private void btn_filtre_Click(object sender, EventArgs e)
        {
            if (sayac_filtre == 2)
            {
                panel_tarih.Visible = false;

                sayac_filtre = 1;
            }
            else
            {
                panel_tarih.Visible = true;
                sayac_filtre++;

            }
        }
        // GÜNCELLE BUTONU
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            // GUNCELLE FORMUNA ID GÖNDERME

            FRM_DETAY_KART_GUNCELLE frm_kart_guncelle = new FRM_DETAY_KART_GUNCELLE();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frm_kart_guncelle.kart_guncelle_kod = int.Parse(dr["id"].ToString());

            }

            frm_kart_guncelle.Show();
        }
        // ARA BUTONU
        int sayac_ara = 1;
        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (sayac_ara == 2)
            {
                gridView1.OptionsView.ShowAutoFilterRow = false;

                sayac_ara = 1;
            }
            else
            {
                gridView1.OptionsView.ShowAutoFilterRow = true;
                sayac_ara++;

            }
        }

        private void date_baslangic_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_kart();
            }
        }

        private void date_bitis_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_kart();
            }
        }
    }
}