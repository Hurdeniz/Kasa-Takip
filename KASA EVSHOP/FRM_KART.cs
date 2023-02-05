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
    public partial class FRM_KART : DevExpress.XtraEditors.XtraForm
    {
        public FRM_KART()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int kart_kullanici_kod;
        //FORM LOAD
        private void FRM_KART_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        //GARANTİ SEÇİM İŞLEMLERİ
        private void check_garanti_CheckedChanged(object sender, EventArgs e)
        {
            if (check_garanti.Checked == true)
            {
                check_yapikredi.Enabled = false;
                check_finansbank.Enabled = false;
                check_isbankasi.Enabled = false;
                check_halkbank.Enabled = false;
                check_akbank.Enabled = false;
                lbl_yazi.Visible = false;
                txt_tutar.Focus();
            }
            else
            {
                check_yapikredi.Enabled = true;
                check_finansbank.Enabled = true;
                check_isbankasi.Enabled = true;
                check_halkbank.Enabled = true;
                check_akbank.Enabled = true;
                lbl_yazi.Visible = false;
                txt_tutar.Focus();
            }
        }
        //YAPIKREDİ SEÇİM İŞLEMLERİ
        private void check_yapikredi_CheckedChanged(object sender, EventArgs e)
        {
            if (check_yapikredi.Checked == true)
            {
                check_garanti.Enabled = false;
                check_finansbank.Enabled = false;
                check_isbankasi.Enabled = false;
                check_halkbank.Enabled = false;
                check_akbank.Enabled = false;
                lbl_yazi.Visible = false;
                txt_tutar.Focus();
            }
            else
            {
                check_garanti.Enabled = true;
                check_finansbank.Enabled = true;
                check_isbankasi.Enabled = true;
                check_halkbank.Enabled = true;
                check_akbank.Enabled = true;
                lbl_yazi.Visible = false;
            }
        }
        //FİNANSBANK SEÇİM İŞLEMLERİ
        private void check_finansbank_CheckedChanged(object sender, EventArgs e)
        {
            if (check_finansbank.Checked == true)
            {
                check_garanti.Enabled = false;
                check_yapikredi.Enabled = false;
                check_isbankasi.Enabled = false;
                check_halkbank.Enabled = false;
                check_akbank.Enabled = false;
                lbl_yazi.Visible = false;
                txt_tutar.Focus();
            }
            else
            {
                check_garanti.Enabled = true;
                check_yapikredi.Enabled = true;
                check_isbankasi.Enabled = true;
                check_halkbank.Enabled = true;
                check_akbank.Enabled = true;
                lbl_yazi.Visible = false;
            }
        }
        //İŞBANKASI SEÇİM İŞLEMLERİ
        private void check_isbankasi_CheckedChanged(object sender, EventArgs e)
        {
            if (check_isbankasi.Checked == true)
            {
                check_garanti.Enabled = false;
                check_yapikredi.Enabled = false;
                check_finansbank.Enabled = false;
                check_halkbank.Enabled = false;
                check_akbank.Enabled = false;
                lbl_yazi.Visible = false;
                txt_tutar.Focus();
            }
            else
            {
                check_garanti.Enabled = true;
                check_yapikredi.Enabled = true;
                check_finansbank.Enabled = true;
                check_halkbank.Enabled = true;
                check_akbank.Enabled = true;
                lbl_yazi.Visible = false;
            }
        }
        //HALKBANK SEÇİM İŞLEMLERİ
        private void check_halkbank_CheckedChanged(object sender, EventArgs e)
        {
            if (check_halkbank.Checked == true)
            {
                check_garanti.Enabled = false;
                check_yapikredi.Enabled = false;
                check_finansbank.Enabled = false;
                check_isbankasi.Enabled = false;
                check_akbank.Enabled = false;
                lbl_yazi.Visible = false;
                txt_tutar.Focus();
            }
            else
            {
                check_garanti.Enabled = true;
                check_yapikredi.Enabled = true;
                check_finansbank.Enabled = true;
                check_isbankasi.Enabled = true;
                check_akbank.Enabled = true;
                lbl_yazi.Visible = false;
            }
            
        }
        //AKBANK SEÇİM İŞLMELERİ
        private void check_akbank_CheckedChanged(object sender, EventArgs e)
        {
            if (check_akbank.Checked == true)
            {
                check_garanti.Enabled = false;
                check_yapikredi.Enabled = false;
                check_finansbank.Enabled = false;
                check_isbankasi.Enabled = false;
                check_halkbank.Enabled = false;
                lbl_yazi.Visible = false;
                txt_tutar.Focus();
            }
            else
            {
                check_garanti.Enabled = true;
                check_yapikredi.Enabled = true;
                check_finansbank.Enabled = true;
                check_isbankasi.Enabled = true;
                check_halkbank.Enabled = true;
                lbl_yazi.Visible = false;
            }
        }
        //KAYDET BUTONU
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // KAYIT İŞLEMLERİ
        void kaydet()
        {
            if (check_garanti.Checked == true)
            {
                OleDbTransaction islem = null;
                islem = bgl.baglanti().BeginTransaction();


                OleDbCommand kmt = new OleDbCommand("insert into kasa_kredi_kart (garanti,tarih,kullanici_kod) values (@p1,@p2,@p3)", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txt_tutar.Text);
                kmt.Parameters.AddWithValue("@p2", lbl_tarih.Text);
                kmt.Parameters.AddWithValue("@p3", kart_kullanici_kod.ToString());


                try
                {
                    kmt.ExecuteNonQuery();
                    islem.Commit();
                    lbl_yazi.Visible = false;
                    lbl_yazi.Visible = true;
                    txt_tutar.Text = "0";

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
            else if (check_yapikredi.Checked == true)
            {
                OleDbTransaction islem = null;
                islem = bgl.baglanti().BeginTransaction();


                OleDbCommand kmt = new OleDbCommand("insert into kasa_kredi_kart (yapikredi,tarih,kullanici_kod) values (@p1,@p2,@p3)", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txt_tutar.Text);
                kmt.Parameters.AddWithValue("@p2", lbl_tarih.Text);
                kmt.Parameters.AddWithValue("@p3", kart_kullanici_kod.ToString());


                try
                {
                    kmt.ExecuteNonQuery();
                    islem.Commit();
                    lbl_yazi.Visible = false;
                    lbl_yazi.Visible = true;
                    txt_tutar.Text = "0";
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
            else if (check_finansbank.Checked == true)
            {
                OleDbTransaction islem = null;
                islem = bgl.baglanti().BeginTransaction();


                OleDbCommand kmt = new OleDbCommand("insert into kasa_kredi_kart (finansbank,tarih,kullanici_kod) values (@p1,@p2,@p3)", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txt_tutar.Text);
                kmt.Parameters.AddWithValue("@p2", lbl_tarih.Text);
                kmt.Parameters.AddWithValue("@p3", kart_kullanici_kod.ToString());


                try
                {
                    kmt.ExecuteNonQuery();
                    islem.Commit();
                    lbl_yazi.Visible = false;
                    lbl_yazi.Visible = true;
                    txt_tutar.Text = "0";
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
            else if (check_isbankasi.Checked == true)
            {
                OleDbTransaction islem = null;
                islem = bgl.baglanti().BeginTransaction();


                OleDbCommand kmt = new OleDbCommand("insert into kasa_kredi_kart (isbankasi,tarih,kullanici_kod) values (@p1,@p2,@p3)", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txt_tutar.Text);
                kmt.Parameters.AddWithValue("@p2", lbl_tarih.Text);
                kmt.Parameters.AddWithValue("@p3", kart_kullanici_kod.ToString());


                try
                {
                    kmt.ExecuteNonQuery();
                    islem.Commit();
                    lbl_yazi.Visible = false;
                    lbl_yazi.Visible = true;
                    txt_tutar.Text = "0";
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
            else if (check_halkbank.Checked == true)
            {
                OleDbTransaction islem = null;
                islem = bgl.baglanti().BeginTransaction();


                OleDbCommand kmt = new OleDbCommand("insert into kasa_kredi_kart (halkbank,tarih,kullanici_kod) values (@p1,@p2,@p3)", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txt_tutar.Text);
                kmt.Parameters.AddWithValue("@p2", lbl_tarih.Text);
                kmt.Parameters.AddWithValue("@p3", kart_kullanici_kod.ToString());


                try
                {
                    kmt.ExecuteNonQuery();
                    islem.Commit();
                    lbl_yazi.Visible = false;
                    lbl_yazi.Visible = true;
                    txt_tutar.Text = "0";
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
            else if (check_akbank.Checked == true)
            {
                OleDbTransaction islem = null;
                islem = bgl.baglanti().BeginTransaction();


                OleDbCommand kmt = new OleDbCommand("insert into kasa_kredi_kart (akbank,tarih,kullanici_kod) values (@p1,@p2,@p3)", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txt_tutar.Text);
                kmt.Parameters.AddWithValue("@p2", lbl_tarih.Text);
                kmt.Parameters.AddWithValue("@p3", kart_kullanici_kod.ToString());


                try
                {
                    kmt.ExecuteNonQuery();
                    islem.Commit();
                    lbl_yazi.Visible = false;
                    lbl_yazi.Visible = true;
                    txt_tutar.Text = "0";
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
            else
            {
                XtraMessageBox.Show("LÜTFEN BANKA SEÇİNİZ ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }
        //TİMER 
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tarih.Text = DateTime.Now.ToShortDateString();
        }
        //ENTER TUSU
        private void txt_tutar_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
    }
}