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
    public partial class FRM_PERSONEL_SHIFT : DevExpress.XtraEditors.XtraForm
    {
        public FRM_PERSONEL_SHIFT()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");
        private void FRM_PERSONEL_SHIFT_Load(object sender, EventArgs e)
        {
            listele_personel_shift();
        }
        // GRİD DOLDUR PERSONEL
        public void listele_personel_shift()
        {
            bag.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("select id,bolumu,gorevi,adi_soyadi,pazartesi,sali,carsamba,persembe,cuma,cumartesi,pazar from personel Order By bolumu,gorevi,id ASC ", bag);


            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_taksit.DataSource = dt;
            bag.Close();

            isim();       

           
        }
        //GRİD KOLON İSİM
        void isim()
        {
            gridView1.Columns[0].Width = 35; // GRİD KOLON BOYUT
           

            gridView1.Columns[0].Caption = "ID";
            gridView1.Columns[1].Caption = "BÖLÜMÜ";
            gridView1.Columns[2].Caption = "GÖREVİ";
            gridView1.Columns[3].Caption = "ADI SOYADI";
            gridView1.Columns[4].Caption = "PAZARTESİ";
            gridView1.Columns[5].Caption = "SALI";
            gridView1.Columns[6].Caption = "ÇARŞAMBA";
            gridView1.Columns[7].Caption = "PERŞEMBE";
            gridView1.Columns[8].Caption = "CUMA";
            gridView1.Columns[9].Caption = "CUMARTESİ";
            gridView1.Columns[10].Caption = "PAZAR";



        }
        //GÜNCELLE
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            // GUNCELLE FORMUNA ID GÖNDERME


            FRM_PERSONEL_SHIFT_GUNCELLE frm_personel_shift_guncelle = new FRM_PERSONEL_SHIFT_GUNCELLE();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frm_personel_shift_guncelle.personel_shift_id = int.Parse(dr["id"].ToString());

            }

            frm_personel_shift_guncelle.Show();
        }
        //EXCEL
        private void btn_excel_Click(object sender, EventArgs e)
        {
            FRM_SHIFT_EXCEL frm_excel = new FRM_SHIFT_EXCEL();
            frm_excel.Show();
        }
        //ARA BUTONU
        int sayac = 1;
        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (sayac == 2)
            {
                gridView1.OptionsView.ShowAutoFilterRow = false;

                sayac = 1;
            }
            else
            {
                gridView1.OptionsView.ShowAutoFilterRow = true;
                sayac++;

            }
        }
        //YENİLE
        private void btn_yenile_Click(object sender, EventArgs e)
        {
            listele_personel_shift();
        }
    }
}