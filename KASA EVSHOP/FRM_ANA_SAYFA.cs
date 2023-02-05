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
    public partial class FRM_ANA_SAYFA : DevExpress.XtraEditors.XtraForm
    {
        public FRM_ANA_SAYFA()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");

        public int not_kod;
        private void FRM_ANA_SAYFA_Load(object sender, EventArgs e)
        {
                     

            listele_notlar();
        }
        // GRİD DOLDUR
        public void listele_notlar()
        {
            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select id,tarih,aciklama from notlar where kullanici_kodu=@p1 Order By tarih,id ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", not_kod.ToString());

            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_not.DataSource = dt;
            bag.Close();
            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.FocusedRowHandle = gridView1.RowCount - 1;


        }
        //GRİD KOLON İSİM
        void isim()
        {
            gridView1.Columns[0].Width = 35;
            gridView1.Columns[1].Width = 55;// GRİD KOLON BOYUT
            gridView1.Columns[2].Width = 200;


            gridView1.Columns[0].Caption = "ID";
            gridView1.Columns[1].Caption = "TARİH";
            gridView1.Columns[2].Caption = "NOT";



        }
        // HESAPLA
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            yuzde_hesap();
        }
        //YÜZDE HESAP
        double tutar, yuzde, hesap, sonuc;
        void yuzde_hesap()
        {
            tutar = Convert.ToDouble(txt_tutar.Text);
            yuzde = Convert.ToDouble(txt_yuzde.Text);


            hesap = (tutar * yuzde) / 100;
            txt_iskonto.Text = hesap.ToString();

            sonuc = tutar - hesap;
            txt_toplam_tutar.Text = sonuc.ToString() + " ₺";

            txt_tutar.Focus();


        }

        private void txt_tutar_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                yuzde_hesap();
            }
        }

        private void txt_yuzde_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                yuzde_hesap();
            }
        }
        //NOT MEMO TEXTE GÖSTERME
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                memo_aciklama.Text = dr["aciklama"].ToString();
            }
        }
        //YENİ
        private void btn_yeni_Click(object sender, EventArgs e)
        {
            FRM_YENI_NOT yeni = new FRM_YENI_NOT();
            yeni.not_kullanici_kod= Convert.ToInt32(not_kod.ToString());
            yeni.Show();
        }
        //SİL
        private void btn_sil_Click(object sender, EventArgs e)
        {
            int id;
            // GRİD DEN VERİ ÇEKME
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["id"].ToString());

            // VERİ TABANINDAN SİLME İŞLEMİ
            DialogResult cevap;
            cevap = XtraMessageBox.Show("Kayıdı Silmek İstediğinizden Emin Misiniz ? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                bag.Open();
                OleDbCommand sil = new OleDbCommand("Delete from notlar where id=@p1", bag);
                sil.Parameters.AddWithValue("@p1", id.ToString());
                sil.ExecuteNonQuery();
                bag.Close();
              
            }
            listele_notlar();
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
            listele_notlar();
            memo_aciklama.Text = "";
            txt_tutar.Text = "";
            txt_yuzde.Text = "";
            txt_iskonto.Text = "";
            txt_toplam_tutar.Text = "";
        }

    }
}