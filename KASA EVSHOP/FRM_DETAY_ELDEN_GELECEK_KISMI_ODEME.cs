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
    public partial class FRM_DETAY_ELDEN_GELECEK_KISMI_ODEME : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DETAY_ELDEN_GELECEK_KISMI_ODEME()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();
        public int kismi_odeme_al_id;
        int durum = 2;
        
        private void FRM_DETAY_ELDEN_GELECEK_KISMI_ODEME_Load(object sender, EventArgs e)
        {
            txt_gelen_tutar.Focus();

            timer1.Start();
            musteri_bilgileri();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_tarih.Text = DateTime.Now.ToShortDateString();
        }
        // MÜŞTERİ BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void musteri_bilgileri()
        {
            DateTime a;
            OleDbCommand kmt = new OleDbCommand("select * from elden_gelecek_gelen where id=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", kismi_odeme_al_id.ToString());

            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                txt_islem_tipi.Text = oku["islem"].ToString();
                txt_musteri_kodu.Text = oku["musteri_kodu"].ToString();
                txt_senet_no.Text = oku["senet_no"].ToString();
                txt_adi_soyadi.Text = oku["adi_soyadi"].ToString();
                a =Convert.ToDateTime( oku["islem_tarih"].ToString());
                txt_islem_tarihi.Text = a.ToShortDateString();            
                txt_islem_tutari.Text= oku["islem_tutari"].ToString();
                txt_odenen_tutar.Text = oku["odenen_tutar"].ToString();
                txt_gelecek_tutar.Text = oku["gelecek_tutar"].ToString();
                txt_kullanici.Text = oku["kullanici_adi"].ToString();
               

            }

        }
        //KAYDET
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // PEŞİN İŞLEM VERİLERİ KAYDETME 
        Decimal gelecek_tutar, gelen_tutar, odenen_tutar, sonuc, sonuc2;
        public void kaydet()
        {
           
                gelecek_tutar = Convert.ToDecimal(txt_gelecek_tutar.Text);
                gelen_tutar = Convert.ToDecimal(txt_gelen_tutar.Text);
                odenen_tutar = Convert.ToDecimal(txt_odenen_tutar.Text);

                if (gelen_tutar > gelecek_tutar)
                {
                    XtraMessageBox.Show("GELEN TUTAR GELECEK TUTARDAN BÜYÜK OLAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (gelen_tutar == gelecek_tutar)
                {
                    XtraMessageBox.Show("GELEN TUTAR İLE GELECEK TUTAR EŞİT LÜTFEN NORMAL ÖDEME ALIN ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    sonuc = gelecek_tutar - gelen_tutar;
                    txt_kalan_tutar.Text = sonuc.ToString();

                    sonuc2 = gelen_tutar + odenen_tutar;
                    txt_odenen_tutar.Text = sonuc2.ToString();
                  



                    OleDbTransaction islem = null;
                    islem = bgl.baglanti().BeginTransaction();


                    OleDbCommand kmt = new OleDbCommand("insert into elden_gelecek_gelen (islem,musteri_kodu,senet_no,adi_soyadi,islem_tarih,islem_tutari,gelecek_tutar,gelen_tutar,odenen_tarih,kullanici_adi,durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                    kmt.Parameters.AddWithValue("@p1", txt_islem_tipi.Text);
                    kmt.Parameters.AddWithValue("@p2", txt_musteri_kodu.Text);
                    kmt.Parameters.AddWithValue("@p3", txt_senet_no.Text);
                    kmt.Parameters.AddWithValue("@p4", txt_adi_soyadi.Text);
                    kmt.Parameters.AddWithValue("@p5", txt_islem_tarihi.Text);
                    kmt.Parameters.AddWithValue("@p6", txt_islem_tutari.Text);
                    kmt.Parameters.AddWithValue("@p7", txt_gelecek_tutar.Text);
                    kmt.Parameters.AddWithValue("@p8", txt_gelen_tutar.Text);
                    kmt.Parameters.AddWithValue("@p9", txt_tarih.Text);
                    kmt.Parameters.AddWithValue("@p10", txt_kullanici.Text);
                    kmt.Parameters.AddWithValue("@p11", durum.ToString());

                    OleDbCommand kmt2 = new OleDbCommand("update elden_gelecek_gelen set odenen_tutar=@p1,gelecek_tutar=@p2 where id=@p3", bgl.baglanti());
                    kmt2.Parameters.AddWithValue("@p1", txt_odenen_tutar.Text);
                    kmt2.Parameters.AddWithValue("@p2", txt_kalan_tutar.Text);
                    kmt2.Parameters.Add("@p3", kismi_odeme_al_id.ToString());



                    try
                    {
                        kmt.ExecuteNonQuery();
                        kmt2.ExecuteNonQuery();
                        islem.Commit();
                        XtraMessageBox.Show("KISMİ ÖDEME ALINMIŞTIR", "BAŞARILI", MessageBoxButtons.OK);
                       
                    }
                    catch
                    {
                        islem.Rollback();

                        XtraMessageBox.Show("KISMİ ÖDEME ALINMAMIŞTIR LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        bgl.baglanti().Close();

                    }
                    // E-GELECEK FORMUNDAKİ GRİD YENİLEME

                    FRM_DETAY_ELDEN_GELECEK frm_gelecek = (FRM_DETAY_ELDEN_GELECEK)Application.OpenForms["FRM_DETAY_ELDEN_GELECEK"];
                    frm_gelecek.listele_elden_gelecek();

                    //FORM KAPAT
                    this.Close();

                
            }
        }
    }
}