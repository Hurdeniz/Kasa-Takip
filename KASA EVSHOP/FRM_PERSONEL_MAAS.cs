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
    public partial class FRM_PERSONEL_MAAS : DevExpress.XtraEditors.XtraForm
    {
        public FRM_PERSONEL_MAAS()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        
        private void FRM_PERSONEL_MAAS_Load(object sender, EventArgs e)
        {
            listele_bolum();
        }
        // GRİD DOLDUR BÖLÜMLER
        public void listele_bolum()
        {
           

            OleDbDataAdapter adt = new OleDbDataAdapter("select * from bolum Order By id ASC ", bgl.baglanti());

            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_taksit.DataSource = dt;
            bgl.baglanti().Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.FocusedRowHandle = gridView1.RowCount - 1;

            //BOLUM SAYI
            gridView1.Columns["id"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            gridView1.Columns["id"].SummaryItem.Tag = 1;
        
        }
        //GRİD KOLON İSİM
        void isim()
        {
            gridView1.Columns[0].Width = 40; // GRİD KOLON BOYUT

            gridView1.Columns[0].Caption = "ID";
            gridView1.Columns[1].Caption = "BÖLÜMLER";
            gridView1.Columns[2].Caption = "MAAŞ";

        }
        //GÜNCELLE
        int sayac = 1;
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (sayac == 2)
            {

                panel_ucret.Visible = false;

                sayac = 1;
            }
            else
            {
                panel_ucret.Visible = true;
                sayac++;
            }
        }
        //GÜNCELLE KAYDET
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // VERİ GÜNCELLEME
        void kaydet()
        {
            int id;

            // GRİD DEN VERİ ÇEKME

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["id"].ToString());

            OleDbTransaction islem = null;
            islem = bgl.baglanti().BeginTransaction();


            OleDbCommand kmt = new OleDbCommand("update bolum set maas=@p1 where id=@p2", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txt_maas.Text);
            kmt.Parameters.Add("@p2",id.ToString());

            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                XtraMessageBox.Show("ÜCRET GÜNCELLENMİŞTİR", "BAŞARILI", MessageBoxButtons.OK);

            }
            catch
            {
                islem.Rollback();
                XtraMessageBox.Show("ÜCRET GÜNCELLENEMEMİŞTİR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();

            }

            listele_bolum();      


        }

        private void txt_maas_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
    }
}