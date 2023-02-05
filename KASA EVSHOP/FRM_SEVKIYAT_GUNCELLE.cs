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
    public partial class FRM_SEVKIYAT_GUNCELLE : DevExpress.XtraEditors.XtraForm
    {
        public FRM_SEVKIYAT_GUNCELLE()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kasa.accdb");

        int kullanici_kod_sevkiyat = 1;
        int kullanici_kod_sevkiyat2 = 2;
        private void FRM_SEVKIYAT_GUNCELLE_Load(object sender, EventArgs e)
        {
            date_tarih.Text = DateTime.Now.ToShortDateString();
            

            

            //SEVKİYATCILAR
            sevkiyat1();
            sevkiyat2();

            listele_sevkiyat1();
            listele_sevkiyat2();
            memnuniyet();
            
        }
        // GRİD DOLDUR SEVKİYAT1
        public void listele_sevkiyat1()
        {


            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select id,numara,musteri_kodu,adi_soyadi,adres,durumu from sevkiyat_listesi where tarih=@p1 and kullanici_kod=@p2 Order By tarih,numara ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", date_tarih.Text);
            adt.SelectCommand.Parameters.AddWithValue("@p2", kullanici_kod_sevkiyat.ToString());

            DataTable dt = new DataTable();

            adt.Fill(dt);
            grid_sevkiyat1.DataSource = dt;

            bag.Close();



            isim_sevkiyat1();
          
            // TABLO EN SON VERİ SEÇME
            gridView1.FocusedRowHandle = gridView1.RowCount - 1;


        }
        // GRİD DOLDUR SEVKİYAT2
        public void listele_sevkiyat2()
        {

            bag.Open();
            OleDbDataAdapter adt2 = new OleDbDataAdapter("select id,numara,musteri_kodu,adi_soyadi,durumu from sevkiyat_listesi where tarih=@p1 and kullanici_kod=@p2 Order By tarih,numara ASC ", bag);
            adt2.SelectCommand.Parameters.AddWithValue("@p1", date_tarih.Text);
            adt2.SelectCommand.Parameters.AddWithValue("@p2", kullanici_kod_sevkiyat2.ToString());

            DataTable dt2 = new DataTable();

            adt2.Fill(dt2);
            grid_sevkiyat2.DataSource = dt2;

            bag.Close();


           

            isim_sevkiyat2();

            // TABLO EN SON VERİ SEÇME
            gridView2.FocusedRowHandle = gridView2.RowCount - 1;


        }
        // GRİD DOLDUR MEMNUNİYET
        public void memnuniyet()
        {

            bag.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select id,musteri_kodu,adi_soyadi,senet_no,telefon,sonuc from memnuniyet where tarih=@p1 Order By tarih,id ASC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", date_tarih.Text);


            DataTable dt = new DataTable();

            adt.Fill(dt);
            grid_memnuniyet.DataSource = dt;

            bag.Close();




            isim_memnuniyet();

            // TABLO EN SON VERİ SEÇME
            gridView3.FocusedRowHandle = gridView2.RowCount - 1;


        }
        //GRİD KOLON İSİM SEVKİYAT1
        void isim_sevkiyat1()
        {
            gridView1.Columns[0].Width = 35; // GRİD KOLON BOYUT
            gridView1.Columns[1].Width = 35;

            gridView1.Columns[0].Caption = "ID";
            gridView1.Columns[1].Caption = "NO";
            gridView1.Columns[2].Caption = "MÜŞTERİ KODU";
            gridView1.Columns[3].Caption = "ADI-SOYADI";
            gridView1.Columns[4].Caption = "ADRES";
            gridView1.Columns[5].Caption = "DURUMU";



        }
        //GRİD KOLON İSİM SEVKİYAT2
        void isim_sevkiyat2()
        {
            gridView2.Columns[0].Width = 35; // GRİD KOLON BOYUT
            gridView2.Columns[1].Width = 35; // GRİD KOLON BOYUT


            gridView2.Columns[0].Caption = "ID";
            gridView2.Columns[1].Caption = "NO";
            gridView2.Columns[2].Caption = "MÜŞTERİ KODU";
            gridView2.Columns[3].Caption = "ADI-SOYADI";
            gridView2.Columns[4].Caption = "DURUMU";

        }
        //GRİD KOLON İSİMMEMNUNİYET
        void isim_memnuniyet()
        {
            gridView3.Columns[0].Width = 35; // GRİD KOLON BOYUT

            gridView3.Columns[0].Caption = "ID";
            gridView3.Columns[1].Caption = "MÜŞTERİ KODU";
            gridView3.Columns[2].Caption = "ADI-SOYADI";
            gridView3.Columns[3].Caption = "SENET NO";
            gridView3.Columns[4].Caption = "TELEFON";
            gridView3.Columns[5].Caption = "SONUÇ";

        }

        // SEVKİYAT1 İSMİ VERI TABANINDAN ÇEKME
        public void sevkiyat1()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from sevkiyatci where kullanici_kod=@p1", bag);
            kmt.Parameters.AddWithValue("@p1", 1);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                tabpage_sevkiyat1.Text = oku["adi_soyadi"].ToString();

            }
            bag.Close();

        }
        // SEVKİYAT2 İSMİ VERI TABANINDAN ÇEKME
        public void sevkiyat2()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from sevkiyatci where kullanici_kod=@p1", bag);
            kmt.Parameters.AddWithValue("@p1", 2);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                tabpage_sevkiyat2.Text = oku["adi_soyadi"].ToString();

            }
            bag.Close();

        }
        //DATE ENTER TUŞU
        private void date_tarih_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                listele_sevkiyat1();
                listele_sevkiyat2();
                memnuniyet();
            }
        }
        //GERİ
        private void btn_geri_Click(object sender, EventArgs e)
        {
            DateTime a, b;
            a = Convert.ToDateTime(date_tarih.Text);
            b = a.AddDays(-1);
            date_tarih.Text = b.ToString();
            date_tarih.Text = (string.Format("{0:dd.MM.yyyy}", b));
         
            listele_sevkiyat1();
            listele_sevkiyat2();
            memnuniyet();
        }
        //İLERİ
        private void btn_ileri_Click(object sender, EventArgs e)
        {
            DateTime a, b;
            a = Convert.ToDateTime(date_tarih.Text);
            b = a.AddDays(+1);
            date_tarih.Text = b.ToString();
            date_tarih.Text = (string.Format("{0:dd.MM.yyyy}", b));

            listele_sevkiyat1();
            listele_sevkiyat2();
            memnuniyet();
        }
        //SİL
        private void btn_sil_Click(object sender, EventArgs e)
        {
            int id;

            // GRİD DEN VERİ ÇEKME

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["id"].ToString());

            
            //VERİ TABANINDAN SİLME İŞLEMİ
            DialogResult cevap;
            cevap = MessageBox.Show("KAYIDI SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ ? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                bag.Open();
                OleDbCommand sil = new OleDbCommand("Delete from sevkiyat_listesi where id=" + id + " ", bag);
                sil.ExecuteNonQuery();
                bag.Close();
                
            }
            listele_sevkiyat1();
            
        }
        //GÜNCELLE
        int sayac_guncel = 1;
        private void btn_guncelle_Click(object sender, EventArgs e)
        {


            if (sayac_guncel == 2)
            {
                panel_guncelle.Visible = false;


                sayac_guncel = 1;
            }
            else
            {
                panel_guncelle.Visible = true;
                panel_sonuc.Visible = false;
                sayac_guncel++;

            }
           
        }
        //SONUC GIR
        int sayac_sonuc = 1;
        private void btn_sonuc_Click(object sender, EventArgs e)
        {
            

            if (sayac_sonuc == 2)
            {
               
                panel_sonuc.Visible = false;

                sayac_sonuc = 1;
            }
            else
            {
               
                panel_sonuc.Visible = true;
                panel_guncelle.Visible = false;
                sayac_sonuc++;

            }
             
        }
        //KAYDET GÜNCELLE
        private void btn_kaydet_guncel_Click(object sender, EventArgs e)
        {
            guncelle_kaydet();
        }
        //KAYIT GÜNCELLE SEVKİYAT 1
        void guncelle_kaydet()
        {
            int id;

            // GRİD DEN VERİ ÇEKME

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["id"].ToString());
            bag.Open();


            OleDbCommand kmt = new OleDbCommand("update sevkiyat_listesi set musteri_kodu=@p1,adi_soyadi=@p2,adres=@p3 where id=@p4  ", bag);
            kmt.Parameters.AddWithValue("@p1", txt_musteri_kodu.Text);
            kmt.Parameters.AddWithValue("@p2", txt_adi_soyadi.Text);
            kmt.Parameters.AddWithValue("@p3", txt_adres.Text);
            kmt.Parameters.AddWithValue("@p4", id.ToString());



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
                XtraMessageBox.Show("LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                bag.Close();
            }
            listele_sevkiyat1();



        }
        // DURUM KAYDET SEVKİYAT1
        string durum;
        private void btn_kaydet_durum_Click(object sender, EventArgs e)
        {
            if (check_ok.Checked == true)
            {
                durum = check_ok.Text;
                kaydet_durum();
            }
            else if (check_gunluk.Checked == true)
            {
                durum = check_gunluk.Text;
                kaydet_durum();
            }
            else if (check_iptal.Checked == true)
            {
                durum = check_iptal.Text;
                kaydet_durum();
            }
            else if (check_diger.Checked == true)
            {
                durum = txt_diger.Text;
                kaydet_durum();
            }
            else
            {
                XtraMessageBox.Show("LÜTFEN SONUÇ SEÇİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // DURUM GÜNCELLEME SEVKİYAT 1
        void kaydet_durum()
        {
            int id;

            // GRİD DEN VERİ ÇEKME

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["id"].ToString());
            bag.Open();


            OleDbCommand kmt = new OleDbCommand("update sevkiyat_listesi set durumu=@p1 where id=@p2", bag);
            kmt.Parameters.AddWithValue("@p1", durum.ToString());
            kmt.Parameters.AddWithValue("@p2", id.ToString());



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
                XtraMessageBox.Show("LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                bag.Close();
            }
            listele_sevkiyat1();


        }

        private void check_ok_CheckedChanged(object sender, EventArgs e)
        {

            if (check_ok.Checked == true)// EĞER OK SEÇİLİ İSE
            {
                check_gunluk.Enabled = false; // GÜNLÜK KAPAT
                check_iptal.Enabled = false; // İPTAL İSTİYOR KAPAT
                check_diger.Enabled = false; // DİĞER KAPAT
            }
            else
            {
                check_ok.Checked = false;
                check_gunluk.Enabled = true;
                check_iptal.Enabled = true;
                check_diger.Enabled = true;
            }
        }

        private void check_gunluk_CheckedChanged(object sender, EventArgs e)
        {
            if (check_gunluk.Checked == true)// EĞER GÜNLÜK SEÇİLİ İSE
            {
                check_ok.Enabled = false; // OK KAPAT
                check_iptal.Enabled = false; // İPTAL İSTİYOR KAPAT
                check_diger.Enabled = false; // DİĞER KAPAT
            }
            else
            {
                //  check_gunluk.Checked = false;
                check_ok.Enabled = true;
                check_iptal.Enabled = true;
                check_diger.Enabled = true;
            }
        }

        private void check_iptal_CheckedChanged(object sender, EventArgs e)
        {
            if (check_iptal.Checked == true)// EĞER İPTAL İSTİYOR SEÇİLİ İSE
            {
                check_ok.Enabled = false; // OK KAPAT
                check_gunluk.Enabled = false; // GUNLUK KAPAT
                check_diger.Enabled = false; // DİĞER KAPAT
            }
            else
            {

                check_ok.Enabled = true;
                check_gunluk.Enabled = true;
                check_diger.Enabled = true;
            }
        }

        private void check_diger_CheckedChanged(object sender, EventArgs e)
        {
            if (check_diger.Checked == true)// EĞER DİĞER İSTİYOR SEÇİLİ İSE
            {
                check_ok.Enabled = false; // OK KAPAT
                check_gunluk.Enabled = false; // GUNLUK KAPAT
                check_iptal.Enabled = false; // İPTAL KAPAT
                txt_diger.Enabled = true; // DİĞER TEXT AÇILSIN
            }
            else
            {

                check_ok.Enabled = true;
                check_gunluk.Enabled = true;
                check_iptal.Enabled = true;
                txt_diger.Enabled = false;
            }
        }
        // SEVKİYAT 1 VERİLERİ TEXTE GÖSTERME
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {

                txt_musteri_kodu.Text = dr["musteri_kodu"].ToString();
                txt_adi_soyadi.Text = dr["adi_soyadi"].ToString();
                txt_adres.Text = dr["adres"].ToString();
            }
        }

        private void txt_musteri_kodu_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                guncelle_kaydet();
            }
        }

        private void txt_adi_soyadi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                guncelle_kaydet();
            }
        }

        private void txt_adres_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                guncelle_kaydet();
            }
        }

        private void check_ok_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet_durum();
            }
        }

        private void check_gunluk_Enter(object sender, EventArgs e)
        {
           
        }

        private void check_iptal_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet_durum();
            }
        }

        private void check_gunluk_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet_durum();
            }
        }

        private void check_diger_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet_durum();
            }
        }

        //****************SEVKİYAT 2**********************//
        //SİL
        private void btn_sil2_Click(object sender, EventArgs e)
        {
            int deger;

            // GRİD DEN VERİ ÇEKME

            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            deger = int.Parse(dr["id"].ToString());

            
            //VERİ TABANINDAN SİLME İŞLEMİ
            DialogResult cevap;
            cevap = MessageBox.Show("KAYIDI SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ ? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                bag.Open();
                OleDbCommand sil = new OleDbCommand("Delete from sevkiyat_listesi where id=" + deger + " ", bag);
                sil.ExecuteNonQuery();
                bag.Close();

            }
            listele_sevkiyat2();
        }
        //GÜNCELLE2
        int sayac_guncel2 = 1;
        private void btn_guncelle2_Click(object sender, EventArgs e)
        {


            if (sayac_guncel2 == 2)
            {

                panel_sor_guncel.Visible = false;

                sayac_guncel2 = 1;
            }
            else
            {
                panel_sor_guncel.Visible = true;
                sayac_guncel2++;

            }
        }

        private void btn_sor_kaydet_Click(object sender, EventArgs e)
        {
            sor_kaydet();
        }
        //KAYIT GÜNCELLE SEVKİYAT 2
        void sor_kaydet()
        {
            int id;

            // GRİD DEN VERİ ÇEKME

            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            id = int.Parse(dr["id"].ToString());
            bag.Open();


            OleDbCommand kmt = new OleDbCommand("update sevkiyat_listesi set numara=@p1,musteri_kodu=@p2,adi_soyadi=@p3,durumu=@p4 where id=@p5  ", bag);
            kmt.Parameters.AddWithValue("@p1", txt_sor_numara.Text);
            kmt.Parameters.AddWithValue("@p2", txt_sor_mus_kod.Text);
            kmt.Parameters.AddWithValue("@p3", txt_sor_adi.Text);
            kmt.Parameters.AddWithValue("@p3", txt_sor_durum.Text);
            kmt.Parameters.AddWithValue("@p4", id.ToString());



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
                XtraMessageBox.Show("LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                bag.Close();
            }
            listele_sevkiyat2();



        }
        // SEVKİYAT 2 VERİLERİ TEXTE GÖSTERME
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {

                txt_sor_numara.Text = dr["numara"].ToString();
                txt_sor_mus_kod.Text = dr["musteri_kodu"].ToString();
                txt_sor_adi.Text = dr["adi_soyadi"].ToString();
                txt_sor_durum.Text = dr["durumu"].ToString();
            }
        }

        private void txt_sor_numara_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                sor_kaydet();
            }
        }

        private void txt_sor_mus_kod_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                sor_kaydet();
            }
        }

        private void txt_sor_adi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                sor_kaydet();
            }
        }

        private void txt_sor_durum_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                sor_kaydet();
            }
        }
        //**********MEMNUNİYET**************//
        //GÜNCELLE
        int sayac_memnu_guncel = 1;
        private void btn_memnuniyet_guncelle_Click(object sender, EventArgs e)
        {
            if (sayac_memnu_guncel == 2)
            {

                panel_memnuniyet.Visible = false;

                sayac_memnu_guncel = 1;
            }
            else
            {
                panel_memnuniyet.Visible = true;
                sayac_memnu_guncel++;

            }
        }
        // MEMNUNİYET VERİLERİ TEXTE GÖSTERME
        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr != null)
            {

                txt_memnuniyet_mus_kod.Text = dr["musteri_kodu"].ToString();
                txt_memnuniyet_adi_soyadi.Text = dr["adi_soyadi"].ToString();
                txt_memnuniyet_senet_no.Text = dr["senet_no"].ToString();
                txt_memnuniyet_telefon.Text = dr["telefon"].ToString();
                cmb_memnuniyet_sonuc.Focus();
            }
        }
        // MEMNUNIYET KAYDET
        private void btn_memnuniyet_kaydet_Click(object sender, EventArgs e)
        {
            memnuniyet_guncelle_kaydet();
        }
        //KAYIT GÜNCELLE  MEMNUNİYET
        void memnuniyet_guncelle_kaydet()
        {
            int id;

            // GRİD DEN VERİ ÇEKME

            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            id = int.Parse(dr["id"].ToString());
            bag.Open();


            OleDbCommand kmt = new OleDbCommand("update memnuniyet set musteri_kodu=@p1,adi_soyadi=@p2,senet_no=@p3,telefon=@p4,sonuc=@p5 where id=@p6  ", bag);
            kmt.Parameters.AddWithValue("@p1", txt_memnuniyet_mus_kod.Text);
            kmt.Parameters.AddWithValue("@p2", txt_memnuniyet_adi_soyadi.Text);
            kmt.Parameters.AddWithValue("@p3", txt_memnuniyet_senet_no.Text);
            kmt.Parameters.AddWithValue("@p4", txt_memnuniyet_telefon.Text);
            kmt.Parameters.AddWithValue("@p5", cmb_memnuniyet_sonuc.Text);
            kmt.Parameters.AddWithValue("@p6", id.ToString());



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
                XtraMessageBox.Show("LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                bag.Close();
            }
           memnuniyet();
           txt_memnuniyet_mus_kod.Text = "";
           txt_memnuniyet_adi_soyadi.Text = "";
           txt_memnuniyet_senet_no.Text = "";
           txt_memnuniyet_telefon.Text = "";


        }

        private void txt_memnuniyet_mus_kod_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                memnuniyet_guncelle_kaydet();
            }
        }

        private void txt_memnuniyet_adi_soyadi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                memnuniyet_guncelle_kaydet();
            }
        }

        private void txt_memnuniyet_senet_no_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                memnuniyet_guncelle_kaydet();
            }
        }

        private void txt_memnuniyet_telefon_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                memnuniyet_guncelle_kaydet();
            }
        }

        private void cmb_memnuniyet_sonuc_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                memnuniyet_guncelle_kaydet();
            }
        }


       

    }
}