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
    public partial class FRM_RAPOR_CIKISLAR : DevExpress.XtraEditors.XtraForm
    {
        public FRM_RAPOR_CIKISLAR()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");
        private void FRM_RAPOR_CIKISLAR_Load(object sender, EventArgs e)
        {
            date_baslangic.Text = DateTime.Now.ToShortDateString();
            date_bitis.Text = DateTime.Now.ToShortDateString();
            listele_cikislar();
        }
        // GRİD DOLDUR KASA ÇIKIŞLARI
        public void listele_cikislar()
        {

            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select id,kullanici_adi,tarih,toplam_kasa,aciklama,tahsilat,pesin,pesinat,pesinat_iade,e_gelecek,masraf,garanti,yapikredi,finansbank,isbankasi,halkbank,akbank from kasa_cikis  where tarih BETWEEN @tar1 and @tar2 Order By tarih ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);

            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_taksit.DataSource = dt;

            bag.Close();

            isim();

            //KASA TOPLAM
            gridView1.Columns["toplam_kasa"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["toplam_kasa"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["toplam_kasa"].SummaryItem.Tag = 1;

            //TAHSİLAT TOPLAM
            gridView1.Columns["tahsilat"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["tahsilat"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["tahsilat"].SummaryItem.Tag = 1;

            //PEŞİN TOPLAM
            gridView1.Columns["pesin"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["pesin"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["pesin"].SummaryItem.Tag = 1;

            //PEŞİNAT TOPLAM
            gridView1.Columns["pesinat"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["pesinat"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["pesinat"].SummaryItem.Tag = 1;

            //PEŞİNAT İADE TOPLAM
            gridView1.Columns["pesinat_iade"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["pesinat_iade"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["pesinat_iade"].SummaryItem.Tag = 1;

            //E-GELECEK TOPLAM
            gridView1.Columns["e_gelecek"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["e_gelecek"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["e_gelecek"].SummaryItem.Tag = 1;

            //MASRAF TOPLAM
            gridView1.Columns["masraf"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["masraf"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["masraf"].SummaryItem.Tag = 1;

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
            gridView1.Columns[0].Width = 35; // GRİD KOLON BOYUT


            gridView1.Columns[0].Caption = "ID";
            gridView1.Columns[1].Caption = "PERSONEL ADI";
            gridView1.Columns[2].Caption = "TARİH";
            gridView1.Columns[3].Caption = "TOPLAM KASA";
            gridView1.Columns[4].Caption = "AÇIKLAMA";
            gridView1.Columns[5].Caption = "TAHSİLAT";
            gridView1.Columns[6].Caption = "PEŞİN İŞLEM";
            gridView1.Columns[7].Caption = "PEŞİNAT";
            gridView1.Columns[8].Caption = "PEŞİNAT İADESİ";
            gridView1.Columns[9].Caption = "E-GELECEK";
            gridView1.Columns[10].Caption = "MASRAF";
            gridView1.Columns[11].Caption = "GARANTİ";
            gridView1.Columns[12].Caption = "YAPIKREDI";
            gridView1.Columns[13].Caption = "FİNANSBANK";
            gridView1.Columns[14].Caption = "İŞBANKASI";
            gridView1.Columns[15].Caption = "HALKBANK";
            gridView1.Columns[16].Caption = "AKBANK";



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
                OleDbCommand sil = new OleDbCommand("Delete from kasa_cikis where id=" + id + " ", bag);
                sil.ExecuteNonQuery();
                bag.Close();
            }
            listele_cikislar();
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
        //EXCEL
        private void btn_excel_Click(object sender, EventArgs e)
        {

        }
        // GÖSTER BUTONU
        private void btn_goster_Click(object sender, EventArgs e)
        {
            listele_cikislar();
        }

        private void date_bitis_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_cikislar();
            }
        }

        private void date_baslangic_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_cikislar();
            }
        }
    }
}