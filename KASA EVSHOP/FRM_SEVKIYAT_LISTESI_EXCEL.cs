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
    public partial class FRM_SEVKIYAT_LISTESI_EXCEL : DevExpress.XtraEditors.XtraForm
    {
        public FRM_SEVKIYAT_LISTESI_EXCEL()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");

        int kullanici_kod_sevkiyat = 1;
        int kullanici_kod_sevkiyat2 = 2;
        private void FRM_SEVKIYAT_LISTESI_EXCEL_Load(object sender, EventArgs e)
        {
            date_baslangic.Text = DateTime.Now.ToShortDateString();
            date_bitis.Text = DateTime.Now.ToShortDateString();


            sevkiyat1();
            sevkiyat2();

            listele_sevkiyat1();
            listele_sevkiyat2();
        }
        // SEVKİYAT1 İSMİ VERI TABANINDAN ÇEKME
        public void sevkiyat1()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from sevkiyatci where kullanici_kod=@p1", bag);
            kmt.Parameters.AddWithValue("@p1", 1);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                grp_sevkiyat1.Text = oku["adi_soyadi"].ToString();

            }
            bag.Close();

        }
        // SEVKİYAT2 İSMİ VERI TABANINDAN ÇEKME
        public void sevkiyat2()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from sevkiyatci where kullanici_kod=@p1", bag);
            kmt.Parameters.AddWithValue("@p1", 2);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                grp_sevkiyat2.Text = oku["adi_soyadi"].ToString();

            }
            bag.Close();

        }

        // GRİD DOLDUR SEVKİYAT1
        public void listele_sevkiyat1()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select musteri_kodu,adi_soyadi,adres,durumu from sevkiyat_listesi  where kullanici_kod=@p3 and tarih BETWEEN @tar1 and @tar2 Order By tarih ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p3", kullanici_kod_sevkiyat.ToString());
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            dataGridView1.DataSource = dt;
            bag.Close();

            isim_sevkiyat1();

        }
        //GRİD KOLON İSİM
        void isim_sevkiyat1()
        {
            dataGridView1.Columns[0].HeaderText = "MÜŞTERİ KODU";
            dataGridView1.Columns[1].HeaderText = "ADI-SOYADI";
            dataGridView1.Columns[2].HeaderText = "ADRES";
            dataGridView1.Columns[3].HeaderText = "DURUMU";

            //BOYUT
            dataGridView1.Columns[0].Width = 115;
            dataGridView1.Columns[1].Width = 135;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 110;


        }
        // GRİD DOLDUR SEVKİYAT2
        public void listele_sevkiyat2()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select numara,musteri_kodu,adi_soyadi,durumu from sevkiyat_listesi  where kullanici_kod=@p3 and tarih BETWEEN @tar1 and @tar2 Order By tarih,numara ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p3", kullanici_kod_sevkiyat2.ToString());
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            dataGridView2.DataSource = dt;
            bag.Close();

            isim_sevkiyat2();

        }
        //GRİD KOLON İSİM 2
        void isim_sevkiyat2()
        {
            dataGridView2.Columns[0].HeaderText = "SIRA";
            dataGridView2.Columns[1].HeaderText = "MÜŞTERİ KODU";
            dataGridView2.Columns[2].HeaderText = "ADI-SOYADI";
            dataGridView2.Columns[3].HeaderText = "DURUMU";

            //BOYUT
            dataGridView2.Columns[0].Width = 40;
            dataGridView2.Columns[1].Width = 150;
            dataGridView2.Columns[2].Width = 150;
            dataGridView2.Columns[3].Width = 125;


        }
        //GÖSTER
        private void btn_goster_Click(object sender, EventArgs e)
        {
            listele_sevkiyat1();
            listele_sevkiyat2();
        }
        //EXCEL
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int sutun = 1;
            int satır = 2;

            excel.Application excelapp = new excel.Application();
            excelapp.Workbooks.Add("serviskayitlistesi");
            excelapp.Visible = true;
            excelapp.Worksheets[1].activate();


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = dataGridView1[j, i].Value;

                }

            }

            sutun = 7;
            satır = 2;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = dataGridView2[j, i].Value;

                }

            }
        }
    }
    
}