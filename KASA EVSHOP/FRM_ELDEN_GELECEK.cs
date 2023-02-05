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
    public partial class FRM_ELDEN_GELECEK : DevExpress.XtraEditors.XtraForm
    {
        public FRM_ELDEN_GELECEK()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int e_gelecek_kullanici_kod;
        public string e_gelecek_kullanici_adi;
        int durum = 1;
        //FORM LOAD
        private void FRM_ELDEN_GELECEK_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        //TİMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tarih.Text = DateTime.Now.ToShortDateString();
        }
        //KAYDET BUTONU
        
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (check_pesin_islem.Checked==true)
            {
              
                kaydet_pesin_islem();
            }
            else if (check_pesinat.Checked==true)
            {
                
                kaydet_pesinat();
                
            }
            else
            {
                XtraMessageBox.Show("LÜTFEN İŞLEM ŞEKLİ SEÇİNİZ ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
        // PEŞİN İŞLEM VERİLERİ KAYDETME 
        Decimal islem_tutar, odenen_tutar, sonuc;
        public void kaydet_pesin_islem()
        {
            if (txt_musteri_kodu.Text == "")
            {
                XtraMessageBox.Show("LÜTFEN MÜŞTERİ KODUNUZ GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_adi_soyadi.Text == "")
            {
                XtraMessageBox.Show("LÜTFEN ADI-SOYADI GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_islem_tutari.Text == "")
            {
                XtraMessageBox.Show("LÜTFEN İŞLEM TUTARINI GİRİNİZ ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                islem_tutar = Convert.ToDecimal(txt_islem_tutari.Text);
                odenen_tutar = Convert.ToDecimal(txt_odenen_tutar.Text);
                if (odenen_tutar > islem_tutar)
                {
                    XtraMessageBox.Show("İŞLEM TUTARI ÖDENEN TUTARDAN KÜÇÜK OLAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (islem_tutar==odenen_tutar)
                {
                     XtraMessageBox.Show("İŞLEM TUTARI İLE ÖDENEN TUTAR EŞİT ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    sonuc = islem_tutar - odenen_tutar;
                    txt_gelecek_tutar.Text = sonuc.ToString();



                    OleDbTransaction islem = null;
                    islem = bgl.baglanti().BeginTransaction();

                    string pesin_islem = check_pesin_islem.Text;
                    OleDbCommand kmt = new OleDbCommand("insert into elden_gelecek_gelen (islem,musteri_kodu,senet_no,adi_soyadi,islem_tutari,odenen_tutar,gelecek_tutar,islem_tarih,aciklama,kullanici_kodu,kullanici_adi,durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", bgl.baglanti());
                    kmt.Parameters.AddWithValue("@p1", pesin_islem.ToString());
                    kmt.Parameters.AddWithValue("@p2", txt_musteri_kodu.Text);
                    kmt.Parameters.AddWithValue("@p3", txt_senet_no.Text);
                    kmt.Parameters.AddWithValue("@p4", txt_adi_soyadi.Text);
                    kmt.Parameters.AddWithValue("@p5", txt_islem_tutari.Text);
                    kmt.Parameters.AddWithValue("@p6", txt_odenen_tutar.Text);
                    kmt.Parameters.AddWithValue("@p7", txt_gelecek_tutar.Text);
                    kmt.Parameters.AddWithValue("@p8", lbl_tarih.Text);
                    kmt.Parameters.AddWithValue("@p9", memo_aciklama.Text);
                    kmt.Parameters.AddWithValue("@p10", e_gelecek_kullanici_kod.ToString());
                    kmt.Parameters.AddWithValue("@p11", e_gelecek_kullanici_adi.ToString());
                    kmt.Parameters.AddWithValue("@p12", durum.ToString());

                    //PEŞİN İŞLEM KASASINA KAYDETME
                    OleDbCommand kmt2 = new OleDbCommand("insert into kasa_pesin (musteri_kodu,tutar,tarih,kullanici_kodu) values  (@p1,@p2,@p3,@p4) ", bgl.baglanti());
                    kmt2.Parameters.AddWithValue("@p1", txt_musteri_kodu.Text);
                    kmt2.Parameters.AddWithValue("@p2", txt_islem_tutari.Text);
                    kmt2.Parameters.AddWithValue("@p3", lbl_tarih.Text);
                    kmt2.Parameters.AddWithValue("@p4", e_gelecek_kullanici_kod.ToString());


                    try
                    {
                        kmt.ExecuteNonQuery();
                        kmt2.ExecuteNonQuery();
                        islem.Commit();
                        XtraMessageBox.Show("ELDEN GELECEK ÖDEMENİZ KAYIT EDİLMİŞTİR.", "BAŞARILI", MessageBoxButtons.OK);
                        txt_musteri_kodu.Text = "0";
                        txt_senet_no.Text = "0";
                        txt_adi_soyadi.Text = "";
                        txt_islem_tutari.Text = "0";
                        txt_odenen_tutar.Text = "0";
                        txt_gelecek_tutar.Text = "0";
                        memo_aciklama.Text = "";

                        txt_musteri_kodu.Focus();
                    
                    }
                    catch
                    {
                        islem.Rollback();

                        XtraMessageBox.Show("LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        bgl.baglanti().Close();

                    }

                   

                }
            }
        }
        // PEŞİNAT VERİLERİ KAYDETME      
        public void kaydet_pesinat()
        {
            if (txt_musteri_kodu.Text == "")
            {
                XtraMessageBox.Show("LÜTFEN MÜŞTERİ KODUNUZ GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_adi_soyadi.Text == "")
            {
                XtraMessageBox.Show("LÜTFEN ADI-SOYADI GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              else if (txt_islem_tutari.Text == "")
            {
                XtraMessageBox.Show("LÜTFEN PEŞİNAT TUTARINI GİRİNİZ ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                islem_tutar = Convert.ToDecimal(txt_islem_tutari.Text);
                odenen_tutar = Convert.ToDecimal(txt_odenen_tutar.Text);
                if (odenen_tutar > islem_tutar)
                {
                    XtraMessageBox.Show("PEŞİNAT TUTARI ÖDENEN TUTARDAN KÜÇÜK OLAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (islem_tutar == odenen_tutar)
                {
                    XtraMessageBox.Show("PEŞİNAT TUTARI İLE ÖDENEN TUTAR EŞİT ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    sonuc = islem_tutar - odenen_tutar;
                    txt_gelecek_tutar.Text = sonuc.ToString();
                    string pesinat = check_pesinat.Text;

                    OleDbTransaction islem = null;
                    islem = bgl.baglanti().BeginTransaction();


                    OleDbCommand kmt = new OleDbCommand("insert into elden_gelecek_gelen (islem,musteri_kodu,senet_no,adi_soyadi,islem_tutari,odenen_tutar,gelecek_tutar,islem_tarih,aciklama,kullanici_kodu,kullanici_adi,durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", bgl.baglanti());
                    kmt.Parameters.AddWithValue("@p1", pesinat.ToString());
                    kmt.Parameters.AddWithValue("@p2", txt_musteri_kodu.Text);
                    kmt.Parameters.AddWithValue("@p3", txt_senet_no.Text);
                    kmt.Parameters.AddWithValue("@p4", txt_adi_soyadi.Text);
                    kmt.Parameters.AddWithValue("@p5", txt_islem_tutari.Text);
                    kmt.Parameters.AddWithValue("@p6", txt_odenen_tutar.Text);
                    kmt.Parameters.AddWithValue("@p7", txt_gelecek_tutar.Text);
                    kmt.Parameters.AddWithValue("@p8", lbl_tarih.Text);
                    kmt.Parameters.AddWithValue("@p9", memo_aciklama.Text);
                    kmt.Parameters.AddWithValue("@p10", e_gelecek_kullanici_kod.ToString());
                    kmt.Parameters.AddWithValue("@p11", e_gelecek_kullanici_adi.ToString());
                    kmt.Parameters.AddWithValue("@p12", durum.ToString());

                    //PEŞİNAT KASASINA KAYDETME
                    OleDbCommand kmt2 = new OleDbCommand("insert into kasa_pesinat_al (musteri_kodu,senet_no,tutar,tarih,kullanici_kodu) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                    kmt2.Parameters.AddWithValue("@p1", txt_musteri_kodu.Text);
                    kmt2.Parameters.AddWithValue("@p2", txt_senet_no.Text);
                    kmt2.Parameters.AddWithValue("@p3", txt_islem_tutari.Text);
                    kmt2.Parameters.AddWithValue("@p4", lbl_tarih.Text);
                    kmt2.Parameters.AddWithValue("@p5", e_gelecek_kullanici_kod.ToString());


                    try
                    {
                        kmt.ExecuteNonQuery();
                        kmt2.ExecuteNonQuery();
                        islem.Commit();
                        XtraMessageBox.Show("ELDEN GELECEK ÖDEMENİZ KAYIT EDİLMİŞTİR.", "BAŞARILI", MessageBoxButtons.OK);
                        txt_musteri_kodu.Text = "0";
                        txt_senet_no.Text = "0";
                        txt_adi_soyadi.Text = "";
                        txt_islem_tutari.Text = "0";
                        txt_odenen_tutar.Text = "0";
                        txt_gelecek_tutar.Text = "0";
                        memo_aciklama.Text = "";

                        txt_musteri_kodu.Focus();
                    }
                    catch
                    {
                        islem.Rollback();

                        XtraMessageBox.Show("LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        bgl.baglanti().Close();

                    }



                }
            }
        }

        private void txt_musteri_kodu_KeyDown(object sender, KeyEventArgs e)
        {

            if (check_pesin_islem.Checked==true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesin_islem();
                }
            }
            else if (check_pesinat.Checked==true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesinat();
                }
            }
            else
            {
                XtraMessageBox.Show("LÜTFEN İŞLEM ŞEKLİ SEÇİNİZ ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
            
        }

        private void txt_adi_soyadi_KeyDown(object sender, KeyEventArgs e)
        {
            if (check_pesin_islem.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesin_islem();
                }
            }
            else if (check_pesinat.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesinat();
                }
            }
            else
            {
                XtraMessageBox.Show("LÜTFEN İŞLEM ŞEKLİ SEÇİNİZ ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_islem_tutari_KeyDown(object sender, KeyEventArgs e)
        {
            if (check_pesin_islem.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesin_islem();
                }
            }
            else if (check_pesinat.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesinat();
                }
            }
            else
            {
                XtraMessageBox.Show("LÜTFEN İŞLEM ŞEKLİ SEÇİNİZ ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_gelecek_tutar_KeyDown(object sender, KeyEventArgs e)
        {
            if (check_pesin_islem.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesin_islem();
                }
            }
            else if (check_pesinat.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesinat();
                }
            }
            else
            {
                XtraMessageBox.Show("LÜTFEN İŞLEM ŞEKLİ SEÇİNİZ ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void memo_aciklama_KeyDown(object sender, KeyEventArgs e)
        {
            if (check_pesin_islem.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesin_islem();
                }
            }
            else if (check_pesinat.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesinat();
                }
            }
            else
            {
                XtraMessageBox.Show("LÜTFEN İŞLEM ŞEKLİ SEÇİNİZ ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //PEŞİN İŞLEM SEŞİM 
        private void check_pesin_islem_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pesin_islem.Checked==true)
            {

                check_pesinat.Enabled = false;
                txt_musteri_kodu.Enabled = true;
                txt_senet_no.Enabled = true;
                txt_adi_soyadi.Enabled = true;
                txt_islem_tutari.Enabled = true;
                txt_odenen_tutar.Enabled = true;
                memo_aciklama.Enabled = true;
            }
            else
            {
                check_pesinat.Enabled = true;
                txt_musteri_kodu.Enabled = false;
                txt_senet_no.Enabled = false;
                txt_adi_soyadi.Enabled = false;
                txt_islem_tutari.Enabled = false;
                txt_odenen_tutar.Enabled = false;
                memo_aciklama.Enabled = false;
            }
        }
        // PEŞİNAT SEÇİM
        private void check_pesinat_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pesinat.Checked==true)
            {
                check_pesin_islem.Enabled = false;
                labelControl4.Text = "PEŞİNAT TUTARI :";
                txt_musteri_kodu.Enabled = true;
                txt_senet_no.Enabled = true;
                txt_adi_soyadi.Enabled = true;
                txt_islem_tutari.Enabled = true;
                txt_odenen_tutar.Enabled = true;
                memo_aciklama.Enabled = true;
            }
            else
            {
                check_pesin_islem.Enabled = true;
                labelControl4.Text = "İŞLEM     TUTARI :";
                txt_musteri_kodu.Enabled = false;
                txt_senet_no.Enabled = false;
                txt_adi_soyadi.Enabled = false;
                txt_islem_tutari.Enabled = false;
                txt_odenen_tutar.Enabled = false;
                memo_aciklama.Enabled = false;

            }
        }

        private void txt_odenen_tutar_KeyDown(object sender, KeyEventArgs e)
        {
            if (check_pesin_islem.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesin_islem();
                }
            }
            else if (check_pesinat.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesinat();
                }
            }
            else
            {
                XtraMessageBox.Show("LÜTFEN İŞLEM ŞEKLİ SEÇİNİZ ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void check_pesin_islem_KeyDown(object sender, KeyEventArgs e)
        {
            if (check_pesin_islem.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesin_islem();
                }
            }
            else if (check_pesinat.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesinat();
                }
            }
            else
            {
                XtraMessageBox.Show("LÜTFEN İŞLEM ŞEKLİ SEÇİNİZ ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void check_pesinat_KeyDown(object sender, KeyEventArgs e)
        {
            if (check_pesin_islem.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesin_islem();
                }
            }
            else if (check_pesinat.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesinat();
                }
            }
            else
            {
                XtraMessageBox.Show("LÜTFEN İŞLEM ŞEKLİ SEÇİNİZ ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_senet_no_KeyDown(object sender, KeyEventArgs e)
        {
            if (check_pesin_islem.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesin_islem();
                }
            }
            else if (check_pesinat.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    kaydet_pesinat();
                }
            }
            else
            {
                XtraMessageBox.Show("LÜTFEN İŞLEM ŞEKLİ SEÇİNİZ ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}