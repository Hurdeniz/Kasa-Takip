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
    public partial class FRM_SEVKIYAT_LISTESI : DevExpress.XtraEditors.XtraForm
    {
        public FRM_SEVKIYAT_LISTESI()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");

        int kullanici_kod_sevkiyat = 1;
        int kullanici_kod_sevkiyat2 = 2;

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        private void FRM_SEVKIYAT_LISTESI_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(btn_filtre, "FİLTRE AÇ");
            Aciklama.SetToolTip(btn_ara, "ARA");

            date_baslangic.Text = DateTime.Now.ToShortDateString();
            date_bitis.Text = DateTime.Now.ToShortDateString();

            listele_sevkiyat1();
            listele_sevkiyat2();

            sevkiyat1();
            sevkiyat2();

        }
        // GRİD DOLDUR SEVKİYAT1
        public void listele_sevkiyat1()
        {


            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select numara,musteri_kodu,adi_soyadi,adres,senet_no,durumu,tarih from sevkiyat_listesi  where kullanici_kod=@p3 and tarih BETWEEN @tar1 and @tar2 Order By tarih,numara ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p3", kullanici_kod_sevkiyat.ToString());
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);
            DataTable dt = new DataTable();

            adt.Fill(dt);
            grid_sevkiyat1.DataSource = dt;

            bag.Close();



            isim_sevkiyat1();

            // TABLO EN SON VERİ SEÇME
            gridView1.FocusedRowHandle = gridView1.RowCount - 1;


        }
        // GRİD DOLDUR SEVKİYAT2
        public void listele_sevkiyat2()
        {

            bag.Open();
            OleDbDataAdapter adt2 = new OleDbDataAdapter("select numara,musteri_kodu,adi_soyadi,durumu,tarih from sevkiyat_listesi  where kullanici_kod=@p3 and tarih BETWEEN @tar1 and @tar2 Order By  tarih,numara  ASC ", bag);
            adt2.SelectCommand.Parameters.AddWithValue("@p3", kullanici_kod_sevkiyat2.ToString());
            adt2.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt2.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);

            DataTable dt2 = new DataTable();

            adt2.Fill(dt2);
            grid_sevkiyat2.DataSource = dt2;

            bag.Close();




            isim_sevkiyat2();

            // TABLO EN SON VERİ SEÇME
            gridView2.FocusedRowHandle = gridView2.RowCount - 1;


        }
        //GRİD KOLON İSİM SEVKİYAT1
        void isim_sevkiyat1()
        {
            gridView1.Columns[0].Width = 35; // GRİD KOLON BOYUT
                  
            gridView1.Columns[0].Caption = "NO";
            gridView1.Columns[1].Caption = "MÜŞTERİ KODU";
            gridView1.Columns[2].Caption = "ADI-SOYADI";
            gridView1.Columns[3].Caption = "ADRES";
            gridView1.Columns[4].Caption = "SENET NO";
            gridView1.Columns[5].Caption = "DURUMU";
            gridView1.Columns[6].Caption = "TARİH";



        }
        //GRİD KOLON İSİM SEVKİYAT2
        void isim_sevkiyat2()
        {
            gridView2.Columns[0].Width = 35; // GRİD KOLON BOYUT
           
            gridView2.Columns[0].Caption = "NO";
            gridView2.Columns[1].Caption = "MÜŞTERİ KODU";
            gridView2.Columns[2].Caption = "ADI-SOYADI";
            gridView2.Columns[3].Caption = "DURUMU";
            gridView2.Columns[4].Caption = "TARİH";

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
                gridView1.ViewCaption = oku["adi_soyadi"].ToString();

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
                gridView2.ViewCaption = oku["adi_soyadi"].ToString();

            }
            bag.Close();

        }
        //FİLTRE
        int sayac_filtre = 1;
        private void btn_filtre_Click(object sender, EventArgs e)
        {


            if (sayac_filtre == 2)
            {
                panel_goster.Visible = false;


                sayac_filtre = 1;
            }
            else
            {
                panel_goster.Visible = true;

                sayac_filtre++;

            }
           
        }
        //ARA
        int sayac_ara = 1;
        private void btn_ara_Click(object sender, EventArgs e)
        {
            

            if (sayac_ara == 2)
            {
                panel_ara.Visible = false;


                sayac_ara = 1;
            }
            else
            {
                panel_ara.Visible = true;

                sayac_ara++;

            }
        }
        // ARAMA
        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dt2.Clear();
            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("Select * from sevkiyat_listesi where adi_soyadi like '%" + txt_ara.Text + "%' and kullanici_kod=" + kullanici_kod_sevkiyat + " and tarih BETWEEN @tar1 and @tar2 Order By tarih,numara ASC  ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);
            adt.Fill(dt);
            grid_sevkiyat1.DataSource = dt;

            OleDbDataAdapter adt2 = new OleDbDataAdapter("Select * from sevkiyat_listesi where adi_soyadi like '%" + txt_ara.Text + "%' and kullanici_kod=" + kullanici_kod_sevkiyat2 + " and tarih BETWEEN @tar1 and @tar2 Order By tarih,numara ASC   ", bag);
            adt2.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt2.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);
            adt2.Fill(dt2);
            grid_sevkiyat2.DataSource = dt2;
            bag.Close();
        }

        private void panel_ara_Paint(object sender, PaintEventArgs e)
        {

        }

        private void date_baslangic_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_sevkiyat1();
                listele_sevkiyat2();
            }
        }

        private void date_bitis_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_sevkiyat1();
                listele_sevkiyat2();
            }
        }
        //GÖSTER
        private void btn_goster_Click(object sender, EventArgs e)
        {
            listele_sevkiyat1();
            listele_sevkiyat2();
        }
    }
}