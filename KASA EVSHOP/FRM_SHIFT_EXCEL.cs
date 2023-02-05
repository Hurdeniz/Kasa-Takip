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
    public partial class FRM_SHIFT_EXCEL : DevExpress.XtraEditors.XtraForm
    {
        public FRM_SHIFT_EXCEL()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");
        private void FRM_SHIFT_EXCEL_Load(object sender, EventArgs e)
        {
            listele_tekstil();
            listele_zuccaciye();
            listele_elektronik();
            listele_ev_aletleri();
            listele_mobilya();
            listele_bilgi_islem();
        }
        
        // GRİD DOLDUR TEKSTİL
        public void listele_tekstil()
        {
            string bolum = "TEKSTİL";
            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select gorevi,adi_soyadi,pazartesi,sali,carsamba,persembe,cuma,cumartesi,pazar from personel where bolumu=@p1 Order By gorevi,adi_soyadi ASC  ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", bolum.ToString());           

            DataSet ds = new DataSet();

            adt.Fill(ds);            

            data_tekstil.DataSource = ds.Tables[0];

            bag.Close();

            isim_tekstil();

        }
        //GRİD KOLON İSİM
        void isim_tekstil()
        {
            data_tekstil.Columns[0].HeaderText = "GÖREVİ";
            data_tekstil.Columns[1].HeaderText = "ADI SOYADI";
            data_tekstil.Columns[2].HeaderText = "PAZARTESİ";
            data_tekstil.Columns[3].HeaderText = "SALI";
            data_tekstil.Columns[4].HeaderText = "ÇARŞAMBA";
            data_tekstil.Columns[5].HeaderText = "PERŞEMBE";
            data_tekstil.Columns[6].HeaderText = "CUMA";
            data_tekstil.Columns[7].HeaderText = "CUMARTESİ";
            data_tekstil.Columns[8].HeaderText = "PAZAR";

            //BOYUT
            data_tekstil.Columns[0].Width = 120;
            data_tekstil.Columns[1].Width = 120;
            data_tekstil.Columns[2].Width = 100;
            data_tekstil.Columns[3].Width = 100;
            data_tekstil.Columns[4].Width = 100;
            data_tekstil.Columns[5].Width = 100;
            data_tekstil.Columns[6].Width = 100;
            data_tekstil.Columns[7].Width = 100;
            data_tekstil.Columns[8].Width = 100;


        }

        // GRİD DOLDUR ZÜCCACİYE
        public void listele_zuccaciye()
        {
            string bolum2 = "ZÜCCACİYE";
            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select gorevi,adi_soyadi,pazartesi,sali,carsamba,persembe,cuma,cumartesi,pazar from personel where bolumu=@p1 Order By gorevi,adi_soyadi ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", bolum2.ToString());


            DataSet ds2 = new DataSet();

            adt.Fill(ds2);
            data_zuccaciye.DataSource = ds2.Tables[0];

            bag.Close();

            isim_zuccaciye();

        }
        //GRİD KOLON İSİM
        void isim_zuccaciye()
        {

            data_zuccaciye.Columns[0].HeaderText = "GÖREVİ";
            data_zuccaciye.Columns[1].HeaderText = "ADI SOYADI";
            data_zuccaciye.Columns[2].HeaderText = "PAZARTESİ";
            data_zuccaciye.Columns[3].HeaderText = "SALI";
            data_zuccaciye.Columns[4].HeaderText = "ÇARŞAMBA";
            data_zuccaciye.Columns[5].HeaderText = "PERŞEMBE";
            data_zuccaciye.Columns[6].HeaderText = "CUMA";
            data_zuccaciye.Columns[7].HeaderText = "CUMARTESİ";
            data_zuccaciye.Columns[8].HeaderText = "PAZAR";

            //BOYUT
            data_zuccaciye.Columns[0].Width = 120;
            data_zuccaciye.Columns[1].Width = 120;
            data_zuccaciye.Columns[2].Width = 100;
            data_zuccaciye.Columns[3].Width = 100;
            data_zuccaciye.Columns[4].Width = 100;
            data_zuccaciye.Columns[5].Width = 100;
            data_zuccaciye.Columns[6].Width = 100;
            data_zuccaciye.Columns[7].Width = 100;
            data_zuccaciye.Columns[8].Width = 100;


        }

        // GRİD DOLDUR ELEKTRONİK
        public void listele_elektronik()
        {
            string bolum3 = "ELEKTRONİK";
            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select gorevi,adi_soyadi,pazartesi,sali,carsamba,persembe,cuma,cumartesi,pazar from personel where bolumu=@p1 Order By gorevi,adi_soyadi ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", bolum3.ToString());


            DataSet ds3 = new DataSet();

            adt.Fill(ds3);
            data_elektronik.DataSource = ds3.Tables[0];

            bag.Close();

            isim_elektronik();

        }
        //GRİD KOLON İSİM
        void isim_elektronik()
        {

            data_elektronik.Columns[0].HeaderText = "GÖREVİ";
            data_elektronik.Columns[1].HeaderText = "ADI SOYADI";
            data_elektronik.Columns[2].HeaderText = "PAZARTESİ";
            data_elektronik.Columns[3].HeaderText = "SALI";
            data_elektronik.Columns[4].HeaderText = "ÇARŞAMBA";
            data_elektronik.Columns[5].HeaderText = "PERŞEMBE";
            data_elektronik.Columns[6].HeaderText = "CUMA";
            data_elektronik.Columns[7].HeaderText = "CUMARTESİ";
            data_elektronik.Columns[8].HeaderText = "PAZAR";

            //BOYUT
            data_elektronik.Columns[0].Width = 120;
            data_elektronik.Columns[1].Width = 120;
            data_elektronik.Columns[2].Width = 100;
            data_elektronik.Columns[3].Width = 100;
            data_elektronik.Columns[4].Width = 100;
            data_elektronik.Columns[5].Width = 100;
            data_elektronik.Columns[6].Width = 100;
            data_elektronik.Columns[7].Width = 100;
            data_elektronik.Columns[8].Width = 100;


        }

        // GRİD DOLDUR KÜÇÜK EV ALETLERİ
        public void listele_ev_aletleri()
        {
            string bolum = "KÜÇÜK EV ALETLERİ";
            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select gorevi,adi_soyadi,pazartesi,sali,carsamba,persembe,cuma,cumartesi,pazar from personel where bolumu=@p1 Order By gorevi,adi_soyadi ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", bolum.ToString());


            DataSet ds = new DataSet();

            adt.Fill(ds);
            data_kucuk_ev.DataSource = ds.Tables[0];

            bag.Close();

            isim_ev_aletleri();

        }
        //GRİD KOLON İSİM
        void isim_ev_aletleri()
        {

            data_kucuk_ev.Columns[0].HeaderText = "GÖREVİ";
            data_kucuk_ev.Columns[1].HeaderText = "ADI SOYADI";
            data_kucuk_ev.Columns[2].HeaderText = "PAZARTESİ";
            data_kucuk_ev.Columns[3].HeaderText = "SALI";
            data_kucuk_ev.Columns[4].HeaderText = "ÇARŞAMBA";
            data_kucuk_ev.Columns[5].HeaderText = "PERŞEMBE";
            data_kucuk_ev.Columns[6].HeaderText = "CUMA";
            data_kucuk_ev.Columns[7].HeaderText = "CUMARTESİ";
            data_kucuk_ev.Columns[8].HeaderText = "PAZAR";

            //BOYUT
            data_kucuk_ev.Columns[0].Width = 120;
            data_kucuk_ev.Columns[1].Width = 120;
            data_kucuk_ev.Columns[2].Width = 100;
            data_kucuk_ev.Columns[3].Width = 100;
            data_kucuk_ev.Columns[4].Width = 100;
            data_kucuk_ev.Columns[5].Width = 100;
            data_kucuk_ev.Columns[6].Width = 100;
            data_kucuk_ev.Columns[7].Width = 100;
            data_kucuk_ev.Columns[8].Width = 100;


        }

        // GRİD DOLDUR MOBİLYA
        public void listele_mobilya()
        {
            string bolum = "MOBİLYA";
            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select gorevi,adi_soyadi,pazartesi,sali,carsamba,persembe,cuma,cumartesi,pazar from personel where bolumu=@p1 Order By gorevi,adi_soyadi ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", bolum.ToString());


            DataSet ds = new DataSet();

            adt.Fill(ds);
            data_mobilya.DataSource = ds.Tables[0];

            bag.Close();

            isim_mobilya();

        }
        //GRİD KOLON İSİM
        void isim_mobilya()
        {

            data_mobilya.Columns[0].HeaderText = "GÖREVİ";
            data_mobilya.Columns[1].HeaderText = "ADI SOYADI";
            data_mobilya.Columns[2].HeaderText = "PAZARTESİ";
            data_mobilya.Columns[3].HeaderText = "SALI";
            data_mobilya.Columns[4].HeaderText = "ÇARŞAMBA";
            data_mobilya.Columns[5].HeaderText = "PERŞEMBE";
            data_mobilya.Columns[6].HeaderText = "CUMA";
            data_mobilya.Columns[7].HeaderText = "CUMARTESİ";
            data_mobilya.Columns[8].HeaderText = "PAZAR";

            //BOYUT
            data_mobilya.Columns[0].Width = 120;
            data_mobilya.Columns[1].Width = 120;
            data_mobilya.Columns[2].Width = 100;
            data_mobilya.Columns[3].Width = 100;
            data_mobilya.Columns[4].Width = 100;
            data_mobilya.Columns[5].Width = 100;
            data_mobilya.Columns[6].Width = 100;
            data_mobilya.Columns[7].Width = 100;
            data_mobilya.Columns[8].Width = 100;


        }

        // GRİD DOLDUR BİLGİ İŞLEM
        public void listele_bilgi_islem()
        {
            string bolum = "BİLGİ İŞLEM";
            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select gorevi,adi_soyadi,pazartesi,sali,carsamba,persembe,cuma,cumartesi,pazar from personel where bolumu=@p1 Order By gorevi DESC,adi_soyadi ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", bolum.ToString());


            DataSet ds = new DataSet();

            adt.Fill(ds);
            data_bilgi_islem.DataSource = ds.Tables[0];

            bag.Close();

            isim_bilgi_islem();

        }
        //GRİD KOLON İSİM
        void isim_bilgi_islem()
        {

            data_bilgi_islem.Columns[0].HeaderText = "GÖREVİ";
            data_bilgi_islem.Columns[1].HeaderText = "ADI SOYADI";
            data_bilgi_islem.Columns[2].HeaderText = "PAZARTESİ";
            data_bilgi_islem.Columns[3].HeaderText = "SALI";
            data_bilgi_islem.Columns[4].HeaderText = "ÇARŞAMBA";
            data_bilgi_islem.Columns[5].HeaderText = "PERŞEMBE";
            data_bilgi_islem.Columns[6].HeaderText = "CUMA";
            data_bilgi_islem.Columns[7].HeaderText = "CUMARTESİ";
            data_bilgi_islem.Columns[8].HeaderText = "PAZAR";

            //BOYUT
            data_bilgi_islem.Columns[0].Width = 120;
            data_bilgi_islem.Columns[1].Width = 120;
            data_bilgi_islem.Columns[2].Width = 100;
            data_bilgi_islem.Columns[3].Width = 100;
            data_bilgi_islem.Columns[4].Width = 100;
            data_bilgi_islem.Columns[5].Width = 100;
            data_bilgi_islem.Columns[6].Width = 100;
            data_bilgi_islem.Columns[7].Width = 100;
            data_bilgi_islem.Columns[8].Width = 100;


        }
        // EXCEL 
        private void btn_excel_Click(object sender, EventArgs e)
        {
            int sutun = 1;
            int satır = 1;

            excel.Application excelapp = new excel.Application();
            excelapp.Workbooks.Add("shift");
            excelapp.Visible = true;
            excelapp.Worksheets[1].activate();
            
             excelapp.Cells[satır, sutun].value = page_tekstil.Text;

            
            satır=3;
            for (int i = 0; i < data_tekstil.Rows.Count; i++)
            {
                for (int j = 0; j < data_tekstil.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = data_tekstil[j, i].Value;

                }          
           
            }
            
            sutun=1;
            satır=1;

            excelapp.Worksheets[2].activate();
           
             excelapp.Cells[satır, sutun].value = page_zuccaciye.Text;

             satır = 3;
            for (int i = 0; i < data_zuccaciye.Rows.Count; i++)
            {
                for (int j = 0; j < data_zuccaciye.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = data_zuccaciye[j, i].Value;

                }

            }

            sutun = 1;
            satır = 1;

            excelapp.Worksheets[3].activate();

            excelapp.Cells[satır, sutun].value = page_elektronik.Text;

            satır = 3;

            for (int i = 0; i < data_elektronik.Rows.Count; i++)
            {
                for (int j = 0; j < data_elektronik.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = data_elektronik[j, i].Value;

                }

            }

            sutun = 1;
            satır = 1;

            excelapp.Worksheets[4].activate();

            excelapp.Cells[satır, sutun].value = page_kucuk_ev.Text;

            satır = 3;

            for (int i = 0; i < data_kucuk_ev.Rows.Count; i++)
            {
                for (int j = 0; j < data_kucuk_ev.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = data_kucuk_ev[j, i].Value;

                }

            }

            sutun = 1;
            satır = 1;

            excelapp.Worksheets[5].activate();

            excelapp.Cells[satır, sutun].value = page_mobilya.Text;

            satır = 3;

            for (int i = 0; i < data_mobilya.Rows.Count; i++)
            {
                for (int j = 0; j < data_mobilya.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = data_mobilya[j, i].Value;

                }

            }

            sutun = 1;
            satır = 1;

            excelapp.Worksheets[6].activate();

            excelapp.Cells[satır, sutun].value = page_bilgi_islem.Text;

            satır = 3;

            for (int i = 0; i < data_bilgi_islem.Rows.Count; i++)
            {
                for (int j = 0; j < data_bilgi_islem.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = data_bilgi_islem[j, i].Value;

                }

            }
        
        }
    }
}