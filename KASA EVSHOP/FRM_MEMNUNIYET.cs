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
    public partial class FRM_MEMNUNIYET : DevExpress.XtraEditors.XtraForm
    {
        public FRM_MEMNUNIYET()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");

        private void FRM_MEMNUNIYET_Load(object sender, EventArgs e)
        {
            date_tarih.Text = DateTime.Now.ToShortDateString();

            txt_musteri_kodu.Focus();
            listele_memnuniyet();
            

        }
        // GRİD DOLDUR MEMNUNİYET
        public void listele_memnuniyet()
        {

            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select musteri_kodu,adi_soyadi,senet_no,telefon,sonuc from memnuniyet where tarih=@p1  ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", date_tarih.Text);

            DataSet ds = new DataSet();

            adt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            bag.Close();

            isim();



        }
        //GRİD KOLON İSİM
        void isim()
        {
            dataGridView1.Columns[0].HeaderText = "MÜŞTERİ KODU";
            dataGridView1.Columns[1].HeaderText = "ADI-SOYADI";
            dataGridView1.Columns[2].HeaderText = "SENET NO";
            dataGridView1.Columns[3].HeaderText = "TELEFON";
            dataGridView1.Columns[4].HeaderText = "SONUC";


            //BOYUT
            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[1].Width = 110;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 120;


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
            else if (txt_senet_no.Text == "")
            {
                XtraMessageBox.Show("LÜTFEN SENET NUMARASI GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_telefon.Text == "")
            {
                XtraMessageBox.Show("LÜTFEN TELEFON NUMARASI GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmb_sonuc.Text == "")
            {
                XtraMessageBox.Show("LÜTFEN SONUÇ GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bag.Open();

                OleDbCommand kmt = new OleDbCommand("insert into memnuniyet (musteri_kodu,adi_soyadi,senet_no,telefon,sonuc,tarih) values (@p1,@p2,@p3,@p4,@p5,@p6)", bag);
                kmt.Parameters.AddWithValue("@p1", txt_musteri_kodu.Text);
                kmt.Parameters.AddWithValue("@p2", txt_adi_soyadi.Text);
                kmt.Parameters.AddWithValue("@p3", txt_senet_no.Text);
                kmt.Parameters.AddWithValue("@p4", txt_telefon.Text);
                kmt.Parameters.AddWithValue("@p5", cmb_sonuc.Text);
                kmt.Parameters.AddWithValue("@p6", date_tarih.Text);


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
                    XtraMessageBox.Show("MEMNUNİYET KAYIT İŞLEMİNİZ GERÇEKLEŞMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bag.Close();

                }

                listele_memnuniyet();
                txt_musteri_kodu.Focus();

                txt_musteri_kodu.Text = "";
                txt_adi_soyadi.Text = "";
                txt_senet_no.Text = "";
                txt_telefon.Text = "";

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
                OleDbCommand cmd = new OleDbCommand("delete from memnuniyet where musteri_kodu=@p1 and tarih=@p2", bag);
                cmd.Parameters.AddWithValue("@p1", a);
                cmd.Parameters.AddWithValue("@p2", date_tarih.Text);
                cmd.ExecuteNonQuery();
                bag.Close();
                
            }
            listele_memnuniyet();
        }
        //EXCEL
        private void btn_excel_Click(object sender, EventArgs e)
        {
            int sutun = 1;
            int satır = 1;

            excel.Application excelapp = new excel.Application();
            excelapp.Workbooks.Add("memnuniyet");
            excelapp.Visible = true;
            excelapp.Worksheets[1].activate();

            sutun = 6;
            satır = 1;
            excelapp.Cells[satır, sutun].value = date_tarih.Text;


            sutun = 2;
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
            listele_memnuniyet();
        }
        //GERİ
        private void btn_geri_Click(object sender, EventArgs e)
        {
            DateTime a, b;
            a = Convert.ToDateTime(date_tarih.Text);
            b = a.AddDays(-1);
            date_tarih.Text = b.ToString();
            date_tarih.Text = (string.Format("{0:dd.MM.yyyy}", b));

            listele_memnuniyet();
        }
        //İLERİ
        private void btn_ileri_Click(object sender, EventArgs e)
        {
            DateTime a, b;
            a = Convert.ToDateTime(date_tarih.Text);
            b = a.AddDays(+1);
            date_tarih.Text = b.ToString();
            date_tarih.Text = (string.Format("{0:dd.MM.yyyy}", b));

            listele_memnuniyet();

        }

        private void date_tarih_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_memnuniyet();
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

        private void txt_senet_no_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_telefon_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void cmb_sonuc_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
    }
}