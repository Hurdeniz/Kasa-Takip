using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using excel = Microsoft.Office.Interop.Excel;

namespace KASA_EVSHOP
{
    public partial class FRM_RAPOR_ARAMALAR_EXCEL : DevExpress.XtraEditors.XtraForm
    {
        public FRM_RAPOR_ARAMALAR_EXCEL()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");

        private void FRM_RAPOR_ARAMALAR_EXCEL_Load(object sender, EventArgs e)
        {
            DateTime aybasi = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime aysonu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            date_baslangic.Text = aybasi.ToShortDateString();
            date_bitis.Text = aysonu.ToShortDateString();

            listele_arama();
            listele_dogum_gunu();
            listele_borc_kapama();
        }
        // GRİD DOLDUR ARAMA
        public void listele_arama()
        {
           
            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select musteri_kodu,adi_soyadi,magaza_adi,tutar,telefon,arama_tarih,alisveris_tarih from aramalar where durum=@p1 and alisveris_tarih BETWEEN @tar1 and @tar2 Order By alisveris_tarih ASC  ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", 1);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);
            DataSet ds = new DataSet();
            adt.Fill(ds);
            data_arama.DataSource = ds.Tables[0];
            bag.Close();

            isim_arama();
        }
        //GRİD KOLON ARAMA
        void isim_arama()
        {
            data_arama.Columns[0].HeaderText = "MÜŞTERİ KODU";
            data_arama.Columns[1].HeaderText = "ADI SOYADI";
            data_arama.Columns[2].HeaderText = "MAĞAZA ADI";
            data_arama.Columns[3].HeaderText = "TUTAR";
            data_arama.Columns[4].HeaderText = "TELEFON";
            data_arama.Columns[5].HeaderText = "ARAMA TARİHİ";
            data_arama.Columns[6].HeaderText = "ALIŞVERİŞ TARİHİ";

            //BOYUT
            data_arama.Columns[0].Width = 120;
            data_arama.Columns[1].Width = 125;
            data_arama.Columns[2].Width = 125;
            data_arama.Columns[3].Width = 100;
            data_arama.Columns[4].Width = 100;
            data_arama.Columns[5].Width = 125;
            data_arama.Columns[6].Width = 125;


        }

        // GRİD DOLDUR DOĞUM GÜNÜ
        public void listele_dogum_gunu()
        {

            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select musteri_kodu,adi_soyadi,magaza_adi,tutar,telefon,arama_tarih,alisveris_tarih from aramalar where durum=@p1 and alisveris_tarih BETWEEN @tar1 and @tar2 Order By alisveris_tarih ASC  ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", 2);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);
            DataSet ds = new DataSet();
            adt.Fill(ds);

            data_dogum_gunu.DataSource = ds.Tables[0];
            bag.Close();

            isim_dogum_gunu();
        }
        //GRİD KOLON DOĞUM GÜNÜ
        void isim_dogum_gunu()
        {
            data_dogum_gunu.Columns[0].HeaderText = "MÜŞTERİ KODU";
            data_dogum_gunu.Columns[1].HeaderText = "ADI SOYADI";
            data_dogum_gunu.Columns[2].HeaderText = "MAĞAZA ADI";
            data_dogum_gunu.Columns[3].HeaderText = "TUTAR";
            data_dogum_gunu.Columns[4].HeaderText = "TELEFON";
            data_dogum_gunu.Columns[5].HeaderText = "ARAMA TARİHİ";
            data_dogum_gunu.Columns[6].HeaderText = "ALIŞVERİŞ TARİHİ";

            //BOYUT
            data_dogum_gunu.Columns[0].Width = 120;
            data_dogum_gunu.Columns[1].Width = 125;
            data_dogum_gunu.Columns[2].Width = 125;
            data_dogum_gunu.Columns[3].Width = 100;
            data_dogum_gunu.Columns[4].Width = 100;
            data_dogum_gunu.Columns[5].Width = 125;
            data_dogum_gunu.Columns[6].Width = 125;


        }

        // GRİD DOLDUR BORÇ KAPAMA
        public void listele_borc_kapama()
        {

            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select musteri_kodu,adi_soyadi,magaza_adi,tutar from aramalar where durum=@p1 and alisveris_tarih BETWEEN @tar1 and @tar2 Order By alisveris_tarih ASC  ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", 3);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);
            DataSet ds = new DataSet();
            adt.Fill(ds);

            data_borc_kapama.DataSource = ds.Tables[0];
            bag.Close();

            isim_borc_kapama();
        }
        //GRİD KOLON BORÇ KAPAMA
        void isim_borc_kapama()
        {
            data_borc_kapama.Columns[0].HeaderText = "MÜŞTERİ KODU";
            data_borc_kapama.Columns[1].HeaderText = "ADI SOYADI";
            data_borc_kapama.Columns[2].HeaderText = "MAĞAZA ADI";
            data_borc_kapama.Columns[3].HeaderText = "TUTAR";

            //BOYUT
            data_borc_kapama.Columns[0].Width = 200;
            data_borc_kapama.Columns[1].Width = 200;
            data_borc_kapama.Columns[2].Width = 200;
            data_borc_kapama.Columns[3].Width = 200;

        }

        private void btn_goster_Click(object sender, EventArgs e)
        {

            listele_arama();
            listele_dogum_gunu();
            listele_borc_kapama();
        }
        //EXCEL
        private void btn_excel_Click(object sender, EventArgs e)
        {
            int sutun = 1;
            int satır = 2;

            excel.Application excelapp = new excel.Application();
            excelapp.Workbooks.Add("aramalar");
            excelapp.Visible = true;
            excelapp.Worksheets[1].activate();


            for (int i = 0; i < data_arama.Rows.Count; i++)
            {
                for (int j = 0; j < data_arama.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = data_arama[j, i].Value;

                }

            }


            excelapp.Worksheets[2].activate();

            for (int i = 0; i < data_dogum_gunu.Rows.Count; i++)
            {
                for (int j = 0; j < data_dogum_gunu.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = data_dogum_gunu[j, i].Value;

                }

            }
            excelapp.Worksheets[3].activate();

            for (int i = 0; i < data_borc_kapama.Rows.Count; i++)
            {
                for (int j = 0; j < data_borc_kapama.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = data_borc_kapama[j, i].Value;

                }

            }

        }

        private void date_baslangic_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_arama();
                listele_dogum_gunu();
                listele_borc_kapama();
            }
        }

        private void date_bitis_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_arama();
                listele_dogum_gunu();
                listele_borc_kapama();
            }
        }
    }
}