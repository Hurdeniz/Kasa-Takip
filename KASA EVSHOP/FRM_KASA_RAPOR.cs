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
    public partial class FRM_KASA_RAPOR : DevExpress.XtraEditors.XtraForm
    {
        public FRM_KASA_RAPOR()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");

        private void FRM_KASA_RAPOR_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(btn_yenile, "YENİLE");
            Aciklama.SetToolTip(btn_yeni, "YENİ KASA ÇIKIŞ");
            Aciklama.SetToolTip(btn_aktar, "EXCEL AKTAR");


            txt_para_yatirma.Text = "0";
            txt_devir.Text = "0";
            date_tarih.Text = DateTime.Now.ToShortDateString();

            listele_kasa();
            devreden();
            e_gelen();
            e_gelecek();
            merkez_odeme();
            firma_odeme();
            para_yatirma();
            hesapla();
        }
        // GRİD DOLDUR KREDİ KARTI İŞLEMLERİ
        public void listele_kasa()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select kullanici_adi,toplam_kasa,aciklama,e_gelecek,masraf,garanti,yapikredi,finansbank,isbankasi,halkbank,akbank from kasa_cikis where tarih=@p1 ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", date_tarih.Text);

            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_rapor.DataSource = dt;
            bag.Close();

            isim();


            // TABLO EN SON VERİ SEÇME
            gridView1.FocusedRowHandle = gridView1.RowCount - 1;

            decimal toplam = 0;
            // GRID SUTUN TOPLAMA
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                toplam += Convert.ToDecimal(gridView1.GetRowCellValue(i, "toplam_kasa").ToString());

            }
            txt_kasa.Text = toplam.ToString();

            //TOPLAM KASA
            gridView1.Columns["toplam_kasa"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["toplam_kasa"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["toplam_kasa"].SummaryItem.Tag = 1;

            //E-GELECEK
            gridView1.Columns["e_gelecek"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["e_gelecek"].SummaryItem.DisplayFormat = "{0:N2} ₺";
            gridView1.Columns["e_gelecek"].SummaryItem.Tag = 1;

            //MASRAF
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
            gridView1.Columns[0].Width=120;
            gridView1.Columns[2].Width = 100;
            
            gridView1.Columns[0].Caption = "PERSONEL ADI";
            gridView1.Columns[1].Caption = "KASA ₺";
            gridView1.Columns[2].Caption = "AÇIKLAMA";
            gridView1.Columns[3].Caption = "E-GELECEK";
            gridView1.Columns[4].Caption = "MASRAF";
            gridView1.Columns[5].Caption = "GARANTİ";
            gridView1.Columns[6].Caption = "YAPIKREDİ";
            gridView1.Columns[7].Caption = "FİNANSBANK";
            gridView1.Columns[8].Caption = "İŞ BANKASI";
            gridView1.Columns[9].Caption = "HALKBANK";
            gridView1.Columns[10].Caption = "AKBANK";
            


        }
        //  GERİ
        private void btn_geri_Click(object sender, EventArgs e)
        {
            
            DateTime a, b;
            a = Convert.ToDateTime(date_tarih.Text);
            b = a.AddDays(-1);
            date_tarih.Text = b.ToString();
            date_tarih.Text = (string.Format("{0:dd.MM.yyyy}", b));

            txt_para_yatirma.Text = "0";
            txt_devir.Text = "0";

            listele_kasa();
            devreden();
            e_gelen();
            e_gelecek();
            merkez_odeme();
            firma_odeme();
            para_yatirma();
            hesapla();
        }
        //İLERİ
        private void btn_ileri_Click(object sender, EventArgs e)
        {
            DateTime a, b;
            a = Convert.ToDateTime(date_tarih.Text);
            b = a.AddDays(+1);
            date_tarih.Text = b.ToString();
            date_tarih.Text = (string.Format("{0:dd.MM.yyyy}", b));

            txt_para_yatirma.Text = "0";
            txt_devir.Text = "0";

            listele_kasa();
            devreden();
            e_gelen();
            e_gelecek();
            merkez_odeme();
            firma_odeme();
            para_yatirma();
            hesapla();
        }
        //DEVİR//
        void devreden()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from gunluk_kasa where tarih=@p1", bag);
            kmt.Parameters.AddWithValue("@p1", date_tarih.DateTime.AddDays(-1));
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                txt_devir.Text = oku["toplam_kasa"].ToString();

            }
            bag.Close();

        }
        //E-GELEN//
        void e_gelen()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("select sum(gelen_tutar) as toplam from elden_gelecek_gelen where odenen_tarih=@p1 and durum=@p2", bag);
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", 2);
            txt_e_gelen.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();
            bag.Close();
            if (txt_e_gelen.Text == "")
            {
                txt_e_gelen.Text = "0";
            }
        }
        //E-GELECEK//
        void e_gelecek()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("select sum(gelecek_tutar) as toplam from elden_gelecek_gelen where islem_tarih=@p1 and durum=@p2", bag);
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            kmt.Parameters.AddWithValue("@p2", 1);
            txt_e_gelecek.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();
            bag.Close();
            if (txt_e_gelecek.Text == "")
            {
                txt_e_gelecek.Text = "0";
            }
        }
        //MERKEZ ÖDEMESİ//
        void merkez_odeme()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("select sum(tutar) as toplam from merkez_odeme where tarih=@p1 ", bag);
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            txt_merkez_odeme.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();
            bag.Close();
            if (txt_merkez_odeme.Text == "")
            {
                txt_merkez_odeme.Text = "0";
            }

        }
        //FİRMA ÖDEMESİ//
        void firma_odeme()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("select sum(tutar) as toplam from firma_odemesi where tarih=@p1 ", bag);
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            txt_firma_odeme.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();
            bag.Close();
            if (txt_firma_odeme.Text == "")
            {
                txt_firma_odeme.Text = "0";
            }

        }
        //PARA YATIRMA//
        void para_yatirma()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from para_yatirma where tarih=@p1", bag);
            kmt.Parameters.AddWithValue("@p1", date_tarih.DateTime.AddDays(+1));
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                txt_para_yatirma.Text = oku["tutar"].ToString();

            }
            bag.Close();
          

        }
        // HESAPLA KASA //
        decimal kasa, devir, egelen, merkezodeme, firmaodeme, parayatirma, sonuc;
        public void hesapla()
        {
            kasa = Convert.ToDecimal(txt_kasa.Text);
            devir = Convert.ToDecimal(txt_devir.Text);
            egelen = Convert.ToDecimal(txt_e_gelen.Text);         
            merkezodeme = Convert.ToDecimal(txt_merkez_odeme.Text);
            firmaodeme = Convert.ToDecimal(txt_firma_odeme.Text);
            parayatirma = Convert.ToDecimal(txt_para_yatirma.Text);

            sonuc = kasa + devir + egelen - merkezodeme - firmaodeme - parayatirma;

            txt_toplam_kasa.Text = sonuc.ToString();      
        
        }
        // SAĞ TUŞ GÜNCELLE
        private void toolstrip_guncelle_Click(object sender, EventArgs e)
        {
            // GUNCELLE FORMUNA ID GÖNDERME

            FRM_KASA_RAPOR_GUNCELLE frm_rapor_guncelle = new FRM_KASA_RAPOR_GUNCELLE();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frm_rapor_guncelle.kullanici_adi = dr["kullanici_adi"].ToString();

            }

            frm_rapor_guncelle.Show();
        }
        // AYNI VERİ ENGELLEME
        bool durum;
        public void control()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("select * from gunluk_kasa where tarih=@p1", bag);
            kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
            OleDbDataReader oku = kmt.ExecuteReader();
            if (oku.Read())
            {
                durum = true;
            }
            else
            {
                durum = false;
            }
            bag.Close();


        }
        // KAYDET
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // KASA KAYDETME
        void kaydet()
        {
            control();
            if (durum == false)
            {
  
                bag.Open();
                OleDbCommand kmt = new OleDbCommand("insert into gunluk_kasa (kasa,devir,e_gelen,e_gelecek,merkez_odeme,firma_odeme,para_yatirma,toplam_kasa,tarih,aciklama) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bag);
                kmt.Parameters.AddWithValue("@p1", txt_kasa.Text);
                kmt.Parameters.AddWithValue("@p2", txt_devir.Text);
                kmt.Parameters.AddWithValue("@p3", txt_e_gelen.Text);
                kmt.Parameters.AddWithValue("@p4", txt_e_gelecek.Text);
                kmt.Parameters.AddWithValue("@p5", txt_merkez_odeme.Text);
                kmt.Parameters.AddWithValue("@p6", txt_firma_odeme.Text);
                kmt.Parameters.AddWithValue("@p7", txt_para_yatirma.Text);
                kmt.Parameters.AddWithValue("@p8", txt_toplam_kasa.Text);
                kmt.Parameters.AddWithValue("@p9", date_tarih.Text);
                kmt.Parameters.AddWithValue("@p10", memo_aciklama.Text);

                OleDbTransaction trans;
                trans = bag.BeginTransaction();
                kmt.Transaction = trans;

                try
                {
                    kmt.ExecuteNonQuery();
                    trans.Commit();
                    XtraMessageBox.Show("KASA KAYIT İŞLEMİNİZ YAPILMIŞTIR.", "BAŞARILI", MessageBoxButtons.OK);
                }
                catch
                {
                    trans.Rollback();
                    XtraMessageBox.Show("KASA KAYIT İŞLEMİNİZ GERÇEKLEŞMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bag.Close();

                }
            }
            else
            {
                XtraMessageBox.Show("KASA DAHA ÖNCE KAYDEDİLMİŞTİR LÜTFEN BAŞKA TARİH GİRİNİZ ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        //EXCEL AKTARMA
        decimal gelen, gelecek;
        private void btn_aktar_Click(object sender, EventArgs e)
        {
            gelen = Convert.ToDecimal(txt_e_gelen.Text);
            gelecek = Convert.ToDecimal(txt_e_gelecek.Text);
            int sutun = 1;
            int satır = 1;


            if (gelen!=0 && gelecek!=0)
            {
                excel.Application excelapp = new excel.Application();
                excelapp.Workbooks.Add("kasa günlük");
                excelapp.Visible = true;
                excelapp.Worksheets[1].activate();

                sutun = 5;
                satır = 9;
                excelapp.Cells[satır, sutun].value = date_tarih.Text;

                sutun = 5;
                satır = 10;
                excelapp.Cells[satır, sutun].value = txt_kasa.Text;

                sutun = 5;
                satır = 11;
                excelapp.Cells[satır, sutun].value = txt_devir.Text;

                sutun = 5;
                satır = 12;
                excelapp.Cells[satır, sutun].value = txt_e_gelen.Text;

                sutun = 5;
                satır = 13;
                excelapp.Cells[satır, sutun].value = txt_toplam_kasa.Text;

                sutun = 5;
                satır = 14;
                excelapp.Cells[satır, sutun].value = txt_e_gelecek.Text;
            }
            else if (gelen != 0)
            {


                excel.Application excelapp = new excel.Application();
                excelapp.Workbooks.Add("kasa günlük");
                excelapp.Visible = true;
                excelapp.Worksheets[1].activate();

                sutun = 5;
                satır = 1;
                excelapp.Cells[satır, sutun].value = date_tarih.Text;

                sutun = 5;
                satır = 2;
                excelapp.Cells[satır, sutun].value = txt_kasa.Text;

                sutun = 5;
                satır = 3;
                excelapp.Cells[satır, sutun].value = txt_devir.Text;

                sutun = 5;
                satır = 4;
                excelapp.Cells[satır, sutun].value = txt_e_gelen.Text;

                sutun = 5;
                satır = 5;
                excelapp.Cells[satır, sutun].value = txt_toplam_kasa.Text;
            }
            else if (gelecek !=0)
            {
                excel.Application excelapp = new excel.Application();
                excelapp.Workbooks.Add("kasa günlük");
                excelapp.Visible = true;
                excelapp.Worksheets[1].activate();

                sutun = 8;
                satır = 1;
                excelapp.Cells[satır, sutun].value = date_tarih.Text;

                sutun = 8;
                satır = 2;
                excelapp.Cells[satır, sutun].value = txt_kasa.Text;

                sutun = 8;
                satır = 3;
                excelapp.Cells[satır, sutun].value = txt_devir.Text;      

                sutun = 8;
                satır = 4;
                excelapp.Cells[satır, sutun].value = txt_toplam_kasa.Text;

                sutun = 8;
                satır = 5;
                excelapp.Cells[satır, sutun].value = txt_e_gelecek.Text;
            }
           
            else
            {

                excel.Application excelapp = new excel.Application();
                excelapp.Workbooks.Add("kasa günlük");
                excelapp.Visible = true;
                excelapp.Worksheets[1].activate();

                sutun = 2;
                satır = 1;
                excelapp.Cells[satır, sutun].value = date_tarih.Text;

                sutun = 2;
                satır = 2;
                excelapp.Cells[satır, sutun].value = txt_kasa.Text;

                sutun = 2;
                satır = 3;
                excelapp.Cells[satır, sutun].value = txt_devir.Text;

                sutun = 2;
                satır = 4;
                excelapp.Cells[satır, sutun].value = txt_toplam_kasa.Text;
            }
        }

        private void txt_toplam_kasa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void memo_aciklama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
        // YENİ ÇIKIŞ
        private void btn_yeni_Click(object sender, EventArgs e)
        {
            FRM_RAPOR_YENI_CIKIS_KULLANICI frm_kullanici = new FRM_RAPOR_YENI_CIKIS_KULLANICI();
            frm_kullanici.Show();
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            listele_kasa();
            devreden();
            e_gelen();
            e_gelecek();
            merkez_odeme();
            firma_odeme();
            para_yatirma();
            hesapla();
        }
    }
}