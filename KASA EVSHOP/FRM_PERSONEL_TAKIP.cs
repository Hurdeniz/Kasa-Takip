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
    public partial class FRM_PERSONEL_TAKIP : DevExpress.XtraEditors.XtraForm
    {
        public FRM_PERSONEL_TAKIP()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");
        DataSet ds = new DataSet();
        private void FRM_PERSONEL_TAKIP_Load(object sender, EventArgs e)
        {

        }
        // GRİD DOLDUR GÜNLER
        public void listele_pazartesi()
        {
            string a = "İZİNLİ";

            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select adi_soyadi from personel where pazartesi=@p1   ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", a.ToString());          

            adt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            bag.Close();

            isim();

           
         


        }
        public void listele_sali()
        {
            string a = "İZİNLİ";

            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select adi_soyadi from personel where sali=@p1   ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", a.ToString());

            adt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            bag.Close();

            isim();





        }
        public void listele_carsamba()
        {
            string a = "İZİNLİ";

            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select adi_soyadi from personel where carsamba=@p1   ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", a.ToString());

            adt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            bag.Close();

            isim();





        }
        public void listele_persembe()
        {
            string a = "İZİNLİ";

            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select adi_soyadi from personel where persembe=@p1   ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", a.ToString());

            adt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            bag.Close();

            isim();

        }
        public void listele_cuma()
        {
            string a = "İZİNLİ";

            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select adi_soyadi from personel where cuma=@p1   ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", a.ToString());

            adt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            bag.Close();

            isim();

        }
        public void listele_cumartesi()
        {
            string a = "İZİNLİ";

            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select adi_soyadi from personel where cumartesi=@p1   ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", a.ToString());

            adt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            bag.Close();

            isim();

        }
        public void listele_pazar()
        {
            string a = "İZİNLİ";

            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select adi_soyadi from personel where pazar=@p1   ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", a.ToString());

            adt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            bag.Close();

            isim();

        }
        //GRİD KOLON İSİM
        void isim()
        {
            dataGridView1.Columns[0].HeaderText = "ADI SOYADI";
        

            //BOYUT
            dataGridView1.Columns[0].Width = 180;
     


        }
        // EXCEL AKTAR
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            int sutun = 2;
            int satır = 10;

            excel.Application excelapp = new excel.Application();
            excelapp.Workbooks.Add("PERSONEL BILGI  FORMU");
            excelapp.Visible = true;
            excelapp.Worksheets[1].activate();

          
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    excelapp.Cells[satır + i, sutun + j].value = dataGridView1[j, i].Value;

                }

            }
        }
        // PAZARTESİ
        private void check_pazartesi_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pazartesi.Checked == true)// EĞER SEÇİLİ İSE
            {
                check_sali.Enabled = false; 
                check_carsamba.Enabled = false; 
                check_persembe.Enabled = false;
                check_cuma.Enabled = false;
                check_cumartesi.Enabled = false;
                check_pazar.Enabled = false;
                listele_pazartesi();
            }
            else
            {
                check_sali.Enabled = true;
                check_carsamba.Enabled = true;
                check_persembe.Enabled = true;
                check_cuma.Enabled = true;
                check_cumartesi.Enabled = true;
                check_pazar.Enabled = true;
                ds.Clear();
            }
        }
        //SALI
        private void check_sali_CheckedChanged(object sender, EventArgs e)
        {
            if (check_sali.Checked == true)// EĞER SEÇİLİ İSE
            {
                check_pazartesi.Enabled = false;
                check_carsamba.Enabled = false;
                check_persembe.Enabled = false;
                check_cuma.Enabled = false;
                check_cumartesi.Enabled = false;
                check_pazar.Enabled = false;
                listele_sali();
            }
            else
            {
                check_pazartesi.Enabled = true;
                check_carsamba.Enabled = true;
                check_persembe.Enabled = true;
                check_cuma.Enabled = true;
                check_cumartesi.Enabled = true;
                check_pazar.Enabled = true;
                ds.Clear();
            }
        }
        //ÇARŞAMBA
        private void check_carsamba_CheckedChanged(object sender, EventArgs e)
        {
            if (check_carsamba.Checked == true)// EĞER SEÇİLİ İSE
            {
                check_pazartesi.Enabled = false;
                check_sali.Enabled = false;
                check_persembe.Enabled = false;
                check_cuma.Enabled = false;
                check_cumartesi.Enabled = false;
                check_pazar.Enabled = false;
                listele_carsamba();
            }
            else
            {
                check_pazartesi.Enabled = true;
                check_sali.Enabled = true;
                check_persembe.Enabled = true;
                check_cuma.Enabled = true;
                check_cumartesi.Enabled = true;
                check_pazar.Enabled = true;
                ds.Clear();
            }
        }
        //PERŞEMBE
        private void check_persembe_CheckedChanged(object sender, EventArgs e)
        {
            if (check_persembe.Checked == true)// EĞER SEÇİLİ İSE
            {
                check_pazartesi.Enabled = false;
                check_sali.Enabled = false;
                check_carsamba.Enabled = false;
                check_cuma.Enabled = false;
                check_cumartesi.Enabled = false;
                check_pazar.Enabled = false;
                listele_persembe();
            }
            else
            {
                check_pazartesi.Enabled = true;
                check_sali.Enabled = true;
                check_carsamba.Enabled = true;
                check_cuma.Enabled = true;
                check_cumartesi.Enabled = true;
                check_pazar.Enabled = true;
                ds.Clear();
            }
        }
        //CUMA
        private void check_cuma_CheckedChanged(object sender, EventArgs e)
        {
            if (check_cuma.Checked == true)// EĞER SEÇİLİ İSE
            {
                check_pazartesi.Enabled = false;
                check_sali.Enabled = false;
                check_carsamba.Enabled = false;
                check_persembe.Enabled = false;
                check_cumartesi.Enabled = false;
                check_pazar.Enabled = false;
                listele_cuma();
            }
            else
            {
                check_pazartesi.Enabled = true;
                check_sali.Enabled = true;
                check_carsamba.Enabled = true;
                check_persembe.Enabled = true;
                check_cumartesi.Enabled = true;
                check_pazar.Enabled = true;
                ds.Clear();
            }
        }
        //CUMARTESİ
        private void check_cumartesi_CheckedChanged(object sender, EventArgs e)
        {
            if (check_cumartesi.Checked == true)// EĞER SEÇİLİ İSE
            {
                check_pazartesi.Enabled = false;
                check_sali.Enabled = false;
                check_carsamba.Enabled = false;
                check_persembe.Enabled = false;
                check_cuma.Enabled = false;
                check_pazar.Enabled = false;
                listele_cumartesi();
            }
            else
            {
                check_pazartesi.Enabled = true;
                check_sali.Enabled = true;
                check_carsamba.Enabled = true;
                check_persembe.Enabled = true;
                check_cuma.Enabled = true;
                check_pazar.Enabled = true;
                ds.Clear();
            }
        }
        //PAZAR
        private void check_pazar_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pazar.Checked == true)// EĞER SEÇİLİ İSE
            {
                check_pazartesi.Enabled = false;
                check_sali.Enabled = false;
                check_carsamba.Enabled = false;
                check_persembe.Enabled = false;
                check_cuma.Enabled = false;
                check_cumartesi.Enabled = false;
                listele_pazar();
            }
            else
            {
                check_pazartesi.Enabled = true;
                check_sali.Enabled = true;
                check_carsamba.Enabled = true;
                check_persembe.Enabled = true;
                check_cuma.Enabled = true;
                check_cumartesi.Enabled = true;
                ds.Clear();
            }
        }
    }
}