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
    public partial class FRM_SEVKIYAT_2 : DevExpress.XtraEditors.XtraForm
    {
        public FRM_SEVKIYAT_2()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");

        int kullanici_kod_sevkiyat2 = 2;
        private void FRM_SEVKIYAT_2_Load(object sender, EventArgs e)
        {
            date_tarih.Text = DateTime.Now.ToShortDateString();
            txt_musteri_kodu.Focus();

            listele_sevkiyat2();
            sevkiyat2();
        }
        // GRİD DOLDUR SEVKİYAT
        public void listele_sevkiyat2()
        {

            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select numara,musteri_kodu,adi_soyadi,durumu from sevkiyat_listesi where tarih=@p1 and kullanici_kod=@p2 Order By numara ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", date_tarih.Text);
            adt.SelectCommand.Parameters.AddWithValue("@p2", kullanici_kod_sevkiyat2.ToString());

            DataSet ds = new DataSet();

            adt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            bag.Close();

           
            isim();

            int i = 0;
            int a, b;

            i = ds.Tables[0].Rows.Count - 1; // tablodaki en son veri
            if (i == -1)
            {
                txt_numara.Text = "1";
            }
            else
            {
                txt_numara.Text = ds.Tables[0].Rows[i]["numara"].ToString();

                a = Convert.ToInt32(txt_numara.Text);
                b = a + 1;
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
            dataGridView1.Columns[3].HeaderText = "DURUMU";

            //BOYUT
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 155;
            dataGridView1.Columns[3].Width = 130;


        }
        // SEVKİYAT İSMİ VERI TABANINDAN ÇEKME
        public void sevkiyat2()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from sevkiyatci where kullanici_kod=@p1", bag);
            kmt.Parameters.AddWithValue("@p1", 2);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                lbl_sevkiyat2.Text = oku["adi_soyadi"].ToString();

            }
            bag.Close();

        }
        //KAYDET
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
            else if (txt_numara.Text == "")
            {
                XtraMessageBox.Show("LÜTFEN NUMARA GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                bag.Open();

                OleDbCommand kmt = new OleDbCommand("insert into sevkiyat_listesi (numara,tarih,musteri_kodu,adi_soyadi,durumu,kullanici_kod) values (@p1,@p2,@p3,@p4,@p5,@p6)", bag);
                kmt.Parameters.AddWithValue("@p1", txt_numara.Text);
                kmt.Parameters.AddWithValue("@p1", date_tarih.Text);
                kmt.Parameters.AddWithValue("@p2", txt_musteri_kodu.Text);
                kmt.Parameters.AddWithValue("@p3", txt_adi_soyadi.Text);
                kmt.Parameters.AddWithValue("@p4", txt_durumu.Text);
                kmt.Parameters.AddWithValue("@p5", kullanici_kod_sevkiyat2.ToString());


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

                listele_sevkiyat2();
                txt_adi_soyadi.Text = "";
                txt_musteri_kodu.Text = "";
                txt_durumu.Text = "";
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
                listele_sevkiyat2();
            }
        }
        //EXCEL
        private void btn_excel_Click(object sender, EventArgs e)
        {
            int sutun = 1;
            int satır = 1;

            excel.Application excelapp = new excel.Application();
            excelapp.Workbooks.Add("sevkiyatlistesi-2");
            excelapp.Visible = true;
            excelapp.Worksheets[1].activate();

            sutun = 4;
            satır = 1;
            excelapp.Cells[satır, sutun].value = date_tarih.Text;

            sutun = 1;
            satır = 2;
            excelapp.Cells[satır, sutun].value = lbl_sevkiyat2.Text;


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
            listele_sevkiyat2();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            DateTime a, b;
            a = Convert.ToDateTime(date_tarih.Text);
            b = a.AddDays(-1);
            date_tarih.Text = b.ToString();
            date_tarih.Text = (string.Format("{0:dd.MM.yyyy}", b));


            listele_sevkiyat2();
        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            DateTime a, b;
            a = Convert.ToDateTime(date_tarih.Text);
            b = a.AddDays(+1);
            date_tarih.Text = b.ToString();
            date_tarih.Text = (string.Format("{0:dd.MM.yyyy}", b));

            listele_sevkiyat2();
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

        private void txt_durumu_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void date_tarih_KeyDown(object sender, KeyEventArgs e)
        {
            listele_sevkiyat2();
        }
       
    }
}