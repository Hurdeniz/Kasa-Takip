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
    public partial class FRM_DETAY_MASRAF : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DETAY_MASRAF()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");

        public int masraf_dty_kod;


        private void FRM_DETAY_MASRAF_Load(object sender, EventArgs e)
        {

            date_baslangic.Text = DateTime.Now.ToShortDateString();
            date_bitis.Text = DateTime.Now.ToShortDateString();
            listele_masraf();
        }
        // GRİD DOLDUR MASRAFLAR
        public void listele_masraf()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select id,tarih,tutar,aciklama from kasa_masraf where kullanici_kodu=@p3 and tarih BETWEEN @tar1 and @tar2 Order By tarih,id ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p3", masraf_dty_kod.ToString());
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);

            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_taksit.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.FocusedRowHandle = gridView1.RowCount - 1;


            gridView1.Columns["tutar"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["tutar"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["tutar"].SummaryItem.Tag = 1;
        }
        //GRİD KOLON İSİM
        void isim()
        {
            gridView1.Columns[0].Width = 40; // GRİD KOLON BOYUT
            gridView1.Columns[3].Width = 125;

            gridView1.Columns[0].Caption = "ID";
            gridView1.Columns[1].Caption = "TARİH";
            gridView1.Columns[2].Caption = "TUTAR";
            gridView1.Columns[3].Caption = "AÇIKLAMA";
           


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
                OleDbCommand sil = new OleDbCommand("Delete from kasa_masraf where id=" + id + " ", bag);
                sil.ExecuteNonQuery();
                bag.Close();

            }
            listele_masraf();
        }
        //GÜNCELLE BUTONU
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            // GUNCELLE FORMUNA ID GÖNDERME

            FRM_DETAY_MASRAF_GUNCELLE frm_masraf_guncelle = new FRM_DETAY_MASRAF_GUNCELLE();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frm_masraf_guncelle.masraf_guncelle_kod = int.Parse(dr["id"].ToString());

            }

            frm_masraf_guncelle.Show();
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

        }
        //GÖSTER BUTONU
        private void btn_goster_Click(object sender, EventArgs e)
        {
            listele_masraf();
        }

        private void date_baslangic_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_masraf();
            }
        }

        private void date_bitis_KeyDown(object sender, KeyEventArgs e)
        {  //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_masraf();
            }
        }
    }
}