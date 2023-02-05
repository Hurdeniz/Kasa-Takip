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
    public partial class FRM_SEVKIYAT_1 : DevExpress.XtraEditors.XtraForm
    {
        public FRM_SEVKIYAT_1()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");

        int kullanici_kod_sevkiyat = 1;

        private void FRM_SEVKIYAT_1_Load(object sender, EventArgs e)
        {
            date_tarih.Text = DateTime.Now.AddDays(+1).ToShortDateString();
            txt_musteri_kodu.Focus();
            ilce_bilgiler();
            listele_sevkiyat();
            sevkiyat1();
        }
        // GRİD DOLDUR SEVKİYAT
        public void listele_sevkiyat()
        {

            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select numara,musteri_kodu,adi_soyadi,adres,durumu,senet_no from sevkiyat_listesi where tarih=@p1 and kullanici_kod=@p2  ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", date_tarih.Text);
            adt.SelectCommand.Parameters.AddWithValue("@p1", kullanici_kod_sevkiyat.ToString());

            DataSet ds = new DataSet();

            adt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            bag.Close();

            isim();

            int i = 0;
            int sayi, b;

            i = ds.Tables[0].Rows.Count - 1; // tablodaki en son veri
            if (i == -1)
            {
                txt_numara.Text = "1";
            }
            else
           {
               txt_numara.Text = ds.Tables[0].Rows[i]["numara"].ToString();

               sayi = Convert.ToInt32(txt_numara.Text);
               b = sayi + 1;
               txt_numara.Text = b.ToString();
                
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            }
        


        }
        //GRİD KOLON İSİM
        void isim()
        {
            dataGridView1.Columns[0].HeaderText = "NO";
            dataGridView1.Columns[1].HeaderText = "MÜŞTERİ KODU";
            dataGridView1.Columns[2].HeaderText = "ADI-SOYADI";
            dataGridView1.Columns[3].HeaderText = "ADRES";
            dataGridView1.Columns[4].HeaderText = "DURUMU";
            dataGridView1.Columns[5].HeaderText = "SENET NO";

            //BOYUT
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 135;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 120;


        }
        // İLÇE BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void ilce_bilgiler()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("select ilce from ilce", bag);
            OleDbDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                cmb_adres.Properties.Items.Add(dr[0]);

            }
            bag.Close();



        }
        // SEVKİYAT İSMİ VERI TABANINDAN ÇEKME
        public void sevkiyat1()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from sevkiyatci where kullanici_kod=@p1", bag);
            kmt.Parameters.AddWithValue("@p1", 1);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                lbl_sevkiyat1.Text = oku["adi_soyadi"].ToString();

            }
            bag.Close();

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        //VERİ KAYDET
        void kaydet()
        {
            if (txt_musteri_kodu.Text == "")
            {

                XtraMessageBox.Show("LÜTFEN MÜŞTERİ KODU GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_adi_soyadi.Text == "")
            {
                XtraMessageBox.Show("LÜTFEN ADI-SOYADI GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_senet_no.Text == "")
            {
                XtraMessageBox.Show("LÜTFEN SENET NUMARASI GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmb_adres.Text == "")
            {
                XtraMessageBox.Show("LÜTFEN ADRES GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bag.Open();

                OleDbCommand kmt = new OleDbCommand("insert into sevkiyat_listesi (numara,tarih,musteri_kodu,adi_soyadi,adres,senet_no,kullanici_kod) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bag);
                kmt.Parameters.AddWithValue("@p1", txt_numara.Text);
                kmt.Parameters.AddWithValue("@p2", date_tarih.Text);
                kmt.Parameters.AddWithValue("@p3", txt_musteri_kodu.Text);
                kmt.Parameters.AddWithValue("@p4", txt_adi_soyadi.Text);
                kmt.Parameters.AddWithValue("@p5", cmb_adres.Text);
                kmt.Parameters.AddWithValue("@p6", txt_senet_no.Text);
                kmt.Parameters.AddWithValue("@p7", kullanici_kod_sevkiyat.ToString());


                OleDbTransaction trans;
                trans = bag.BeginTransaction();
                kmt.Transaction = trans;

                try
                {
                    kmt.ExecuteNonQuery();
                    trans.Commit();

                }
                catch
                {
                    trans.Rollback();
                    XtraMessageBox.Show("SEVKİYAT KAYIT İŞLEMİNİZ GERÇEKLEŞMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bag.Close();

                }

                listele_sevkiyat();
                txt_adi_soyadi.Text = "";
                txt_musteri_kodu.Text = "";
                txt_senet_no.Text = "";
                txt_musteri_kodu.Focus();
            }

        }
        //SİL
        private void btn_sil_Click(object sender, EventArgs e)
        {
            string a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult cevap;

            cevap = XtraMessageBox.Show("Kayıdı Silmek İstediğinizden Emin Misiniz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {

                bag.Open();
                OleDbCommand cmd = new OleDbCommand("delete from sevkiyat_listesi where numara=@p1 and tarih=@p2", bag);
                cmd.Parameters.AddWithValue("@p1", a);
                cmd.Parameters.AddWithValue("@p2", date_tarih.Text);
                cmd.ExecuteNonQuery();
                bag.Close();
                listele_sevkiyat();
            }
        }
        //EXCEL
        private void btn_excel_Click(object sender, EventArgs e)
        {
            int sutun = 1;
            int satır = 1;

            excel.Application excelapp = new excel.Application();
            excelapp.Workbooks.Add("sevkiyatlistesi-1");
            excelapp.Visible = true;
            excelapp.Worksheets[1].activate();

            sutun = 6;
            satır = 1;
            excelapp.Cells[satır, sutun].value = date_tarih.Text;

            sutun = 1;
            satır = 2;
            excelapp.Cells[satır, sutun].value = lbl_sevkiyat1.Text;

            sutun = 1;
            satır = 4;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = dataGridView1[j, i].Value;

                }

            }
        }
        //GÖSTER
        private void btn_goster_Click(object sender, EventArgs e)
        {
            listele_sevkiyat();
        }
        //GERİ
        private void btn_geri_Click(object sender, EventArgs e)
        {
            DateTime a, b;
            a = Convert.ToDateTime(date_tarih.Text);
            b = a.AddDays(-1);
            date_tarih.Text = b.ToString();
            date_tarih.Text = (string.Format("{0:dd.MM.yyyy}", b));

           
            listele_sevkiyat();
        }
        //İLERİ
        private void btn_ileri_Click(object sender, EventArgs e)
        {
            DateTime a, b;
            a = Convert.ToDateTime(date_tarih.Text);
            b = a.AddDays(+1);
            date_tarih.Text = b.ToString();
            date_tarih.Text = (string.Format("{0:dd.MM.yyyy}", b));

            listele_sevkiyat();
        }

        private void txt_numara_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_musteri_kodu_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_adi_soyadi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void cmb_adres_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void date_tarih_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_sevkiyat();
            }
        }


    }
}