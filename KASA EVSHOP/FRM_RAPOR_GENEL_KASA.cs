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
    public partial class FRM_RAPOR_GENEL_KASA : DevExpress.XtraEditors.XtraForm
    {
        public FRM_RAPOR_GENEL_KASA()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");

        private void FRM_RAPOR_GENEL_KASA_Load(object sender, EventArgs e)
        {
            DateTime aybasi = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime aysonu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            date_baslangic.Text = aybasi.ToShortDateString();
            date_bitis.Text = aysonu.ToShortDateString();

            listele_garanti();
            listele_is_bankasi();
            listele_yapikredi();
            listele_teb();
            listele_akbank();
            listele_merkez_odeme();
            listele_firma_odeme();
            listele_elden_gelecek();
        }
            
        // GRİD DOLDUR GARANTİ
        public void listele_garanti()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select tarih,tutar from para_yatirma  where banka=@p3 and tarih BETWEEN @tar1 and @tar2 Order By tarih ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p3", grup_garanti.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            grid_garanti.DataSource = dt;
            bag.Close();

            //GRİD İSİM
            grid_garanti.Columns[0].HeaderText = "TARİH";
            grid_garanti.Columns[1].HeaderText = "TUTAR";
            //BOYUT
            grid_garanti.Columns[0].Width = 75;
            grid_garanti.Columns[1].Width = 100;

            // DATA GRİD TOPLAMA
           double toplam = 0;
           for (int i = 0; i < grid_garanti.Rows.Count; ++i)
           {

               toplam += Convert.ToDouble(grid_garanti.Rows[i].Cells[1].Value);
               lbl_garanti.Text = toplam.ToString() + " ₺";

           }

        }
        // GRİD DOLDUR İŞ BAKASI
        public void listele_is_bankasi()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select tarih,tutar from para_yatirma  where banka=@p3 and tarih BETWEEN @tar1 and @tar2 Order By tarih ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p3", grup_is_bankasi.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            grid_isbankasi.DataSource = dt;

            bag.Close();

            //GRİD İSİM
            grid_isbankasi.Columns[0].HeaderText = "TARİH";
            grid_isbankasi.Columns[1].HeaderText = "TUTAR";

            //BOYUT
            grid_isbankasi.Columns[0].Width = 75;
            grid_isbankasi.Columns[1].Width = 100;

            // DATA GRİD TOPLAMA
            double toplam = 0;
            for (int i = 0; i < grid_isbankasi.Rows.Count; ++i)
            {

                toplam += Convert.ToDouble(grid_isbankasi.Rows[i].Cells[1].Value);
                lbl_isbankasi.Text = toplam.ToString() + " ₺";

            }

        }
        // GRİD DOLDUR YAPI KREDİ
        public void listele_yapikredi()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select tarih,tutar from para_yatirma  where banka=@p3 and tarih BETWEEN @tar1 and @tar2 Order By tarih ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p3", grup_yapikredi.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            grid_yapikredi.DataSource = dt;
            bag.Close();

            //GRİD İSİM
            grid_yapikredi.Columns[0].HeaderText = "TARİH";
            grid_yapikredi.Columns[1].HeaderText = "TUTAR";

            //BOYUT
            grid_yapikredi.Columns[0].Width = 75;
            grid_yapikredi.Columns[1].Width = 100;

            // DATA GRİD TOPLAMA
            double toplam = 0;
            for (int i = 0; i < grid_yapikredi.Rows.Count; ++i)
            {

                toplam += Convert.ToDouble(grid_yapikredi.Rows[i].Cells[1].Value);
                lbl_yapikredi.Text = toplam.ToString() + " ₺";

            }

        }
        // GRİD DOLDUR TEB
        public void listele_teb()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select tarih,tutar from para_yatirma  where banka=@p3 and tarih BETWEEN @tar1 and @tar2 Order By tarih ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p3", grup_teb.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            grid_teb.DataSource = dt;
            bag.Close();

            //GRİD İSİM
            grid_teb.Columns[0].HeaderText = "TARİH";
            grid_teb.Columns[1].HeaderText = "TUTAR";

            //BOYUT
            grid_teb.Columns[0].Width = 75;
            grid_teb.Columns[1].Width = 100;

            // DATA GRİD TOPLAMA
            double toplam = 0;
            for (int i = 0; i < grid_teb.Rows.Count; ++i)
            {

                toplam += Convert.ToDouble(grid_teb.Rows[i].Cells[1].Value);
                lbl_teb.Text = toplam.ToString() + " ₺";

            }

        }
        // GRİD DOLDUR AKBANK
        public void listele_akbank()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select tarih,tutar from para_yatirma  where banka=@p3 and tarih BETWEEN @tar1 and @tar2 Order By tarih ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p3", grup_akbank.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            grid_akbank.DataSource = dt;
            bag.Close();

            //GRİD İSİM
            grid_akbank.Columns[0].HeaderText = "TARİH";
            grid_akbank.Columns[1].HeaderText = "TUTAR";

            //BOYUT
            grid_akbank.Columns[0].Width = 75;
            grid_akbank.Columns[1].Width = 100;

            // DATA GRİD TOPLAMA
            double toplam = 0;
            for (int i = 0; i < grid_akbank.Rows.Count; ++i)
            {

                toplam += Convert.ToDouble(grid_akbank.Rows[i].Cells[1].Value);
                lbl_akbank.Text = toplam.ToString() + " ₺";

            }

        }
        // GRİD DOLDUR MERKEZ ODEME
        public void listele_merkez_odeme()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select tarih,tutar from merkez_odeme  where tarih BETWEEN @tar1 and @tar2 Order By tarih ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            grid_merkez_odeme.DataSource = dt;
            bag.Close();

            //GRİD İSİM
            grid_merkez_odeme.Columns[0].HeaderText = "TARİH";
            grid_merkez_odeme.Columns[1].HeaderText = "TUTAR";

            //BOYUT
            grid_merkez_odeme.Columns[0].Width = 75;
            grid_merkez_odeme.Columns[1].Width = 100;

            // DATA GRİD TOPLAMA
            double toplam = 0;
            for (int i = 0; i < grid_merkez_odeme.Rows.Count; ++i)
            {

                toplam += Convert.ToDouble(grid_merkez_odeme.Rows[i].Cells[1].Value);
                lbl_merkez_odeme.Text = toplam.ToString() + " ₺";

            }

        }
        // GRİD DOLDUR FİRMA ODEME
        public void listele_firma_odeme()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select firma_adi,tutar,tarih from firma_odemesi  where tarih BETWEEN @tar1 and @tar2 Order By tarih ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            grid_firma_odeme.DataSource = dt;
            bag.Close();

            //GRİD İSİM
            grid_firma_odeme.Columns[0].HeaderText = "FİRMA ADI";
            grid_firma_odeme.Columns[1].HeaderText = "TUTAR";
            grid_firma_odeme.Columns[2].HeaderText = "TARİH";

            //BOYUT
            grid_firma_odeme.Columns[0].Width = 110;
            grid_firma_odeme.Columns[1].Width = 80;
            grid_firma_odeme.Columns[2].Width = 75;

            // DATA GRİD TOPLAMA
            double toplam = 0;
            for (int i = 0; i < grid_firma_odeme.Rows.Count; ++i)
            {

                toplam += Convert.ToDouble(grid_firma_odeme.Rows[i].Cells[1].Value);
                lbl_firma_odeme.Text = toplam.ToString() + " ₺";

            }

        }
        // GRİD DOLDUR ELDEN GELECEK
        public void listele_elden_gelecek()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select musteri_kodu,gelecek_tutar from elden_gelecek_gelen  where durum=@p1 and islem_tarih BETWEEN @tar1 and @tar2 Order By islem_tarih ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", 1);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", date_baslangic.Text);
            adt.SelectCommand.Parameters.AddWithValue("@tar2", date_bitis.Text);
            DataTable dt = new DataTable();
            adt.Fill(dt);


            grid_elden_gelecek.DataSource = dt;
           

            //GRİD İSİM
            grid_elden_gelecek.Columns[0].HeaderText = "TARİH";
            grid_elden_gelecek.Columns[1].HeaderText = "TUTAR";

            //BOYUT
            grid_elden_gelecek.Columns[0].Width = 75;
            grid_elden_gelecek.Columns[1].Width = 100;

            // DATA GRİD TOPLAMA
            double toplam = 0;
            for (int i = 0; i < grid_elden_gelecek.Rows.Count; ++i)
            {

                toplam += Convert.ToDouble(grid_elden_gelecek.Rows[i].Cells[1].Value);
                lbl_elden.Text = toplam.ToString() + " ₺";

            }
            bag.Close();
        }
      
        //GÖSTER
        private void btn_goster_Click(object sender, EventArgs e)
        {
            listele_garanti();
            listele_is_bankasi();
            listele_yapikredi();
            listele_teb();
            listele_akbank();
            listele_merkez_odeme();
            listele_firma_odeme();
            listele_elden_gelecek();
        }
        //EXCEL
        private void btn_excel_Click(object sender, EventArgs e)
        {
            int sutun = 7;
            int satır = 1;

            excel.Application excelapp = new excel.Application();
            excelapp.Workbooks.Add("GENEL KASA");
            excelapp.Visible = true;
            excelapp.Worksheets[1].activate();

            excelapp.Cells[satır, sutun].value = date_baslangic.Text;

            sutun = 9;
            excelapp.Cells[satır, sutun].value = date_bitis.Text;
          
            sutun = 1;
            satır = 5;
            
            for (int i = 0; i < grid_garanti.Rows.Count; i++)
            {
                for (int j = 0; j < grid_garanti.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = grid_garanti[j, i].Value;

                }

            }

            satır = 22;

            for (int i = 0; i < grid_firma_odeme.Rows.Count; i++)
            {
                for (int j = 0; j < grid_firma_odeme.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = grid_firma_odeme[j, i].Value;

                }

            }

            satır = 32;

            for (int i = 0; i < grid_merkez_odeme.Rows.Count; i++)
            {
                for (int j = 0; j < grid_merkez_odeme.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = grid_merkez_odeme[j, i].Value;

                }

            }
            sutun = 3;
            satır = 5;

            for (int i = 0; i < grid_isbankasi.Rows.Count; i++)
            {
                for (int j = 0; j < grid_isbankasi.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = grid_isbankasi[j, i].Value;

                }

            }

            sutun = 5;
            satır = 5;

            for (int i = 0; i < grid_akbank.Rows.Count; i++)
            {
                for (int j = 0; j < grid_akbank.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = grid_akbank[j, i].Value;

                }

            }

            sutun = 7;
            satır = 5;

            for (int i = 0; i < grid_yapikredi.Rows.Count; i++)
            {
                for (int j = 0; j < grid_yapikredi.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = grid_yapikredi[j, i].Value;

                }

            }

            sutun = 9;
            satır = 5;

            for (int i = 0; i < grid_teb.Rows.Count; i++)
            {
                for (int j = 0; j < grid_teb.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = grid_teb[j, i].Value;

                }

            }

            sutun = 6;
            satır = 26;

            for (int i = 0; i < grid_elden_gelecek.Rows.Count; i++)
            {
                for (int j = 0; j < grid_elden_gelecek.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = grid_elden_gelecek[j, i].Value;

                }

            }
        }

        private void date_baslangic_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_garanti();
                listele_is_bankasi();
                listele_yapikredi();
                listele_teb();
                listele_akbank();
                listele_merkez_odeme();
                listele_firma_odeme();
                listele_elden_gelecek();
            }
        }

        private void date_bitis_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_garanti();
                listele_is_bankasi();
                listele_yapikredi();
                listele_teb();
                listele_akbank();
                listele_merkez_odeme();
                listele_firma_odeme();
                listele_elden_gelecek();
            }
        }
    }
}