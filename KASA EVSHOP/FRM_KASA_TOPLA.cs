using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KASA_EVSHOP
{
    public partial class FRM_KASA_TOPLA : DevExpress.XtraEditors.XtraForm
    {
        public FRM_KASA_TOPLA()
        {
            InitializeComponent();
        }

        private void FRM_KASA_TOPLA_Load(object sender, EventArgs e)
        {

        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            hesap();
        }
        // PARA HESAPLAMA
        double a, b, c, d, x, f, g, sonuc;
        double bes, on, yir, el, yuz, ikiyuz;

        public void hesap()
        {
            try
            {
                a = Convert.ToDouble(txt_bes.Text);
                b = Convert.ToDouble(txt_on.Text);
                c = Convert.ToDouble(txt_yirmi.Text);
                d = Convert.ToDouble(txt_elli.Text);
                x = Convert.ToDouble(txt_yuz.Text);
                f = Convert.ToDouble(txt_ikiyuz.Text);
                g = Convert.ToDouble(txt_bozuk.Text);

                bes = a * 5;
                on = b * 10;
                yir = c * 20;
                el = d * 50;
                yuz = x * 100;
                ikiyuz = f * 200;

                sonuc = bes + on + yir + el + yuz + ikiyuz + g;

                btn_sonuc.Text = sonuc.ToString() + "  ₺";


            }
            catch (Exception)
            {


            }



        }

        private void txt_ikiyuz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hesap();
            }
        }

        private void txt_yuz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hesap();
            }
        }

        private void txt_elli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hesap();
            }
        }

        private void txt_yirmi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hesap();
            }
        }

        private void txt_on_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hesap();
            }
        }

        private void txt_bes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hesap();
            }
        }

        private void txt_bozuk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hesap();
            }
        }
    }
}