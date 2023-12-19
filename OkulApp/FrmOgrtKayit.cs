using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OkulApp.MODEL;
using System.Data.SqlClient;
using OkulApp.BLL;

namespace OkulApp
{
    public partial class FrmOgrtKayit : Form
    {
        public FrmOgrtKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var ogrtbl = new OgretmenBL();
                bool sonuc = ogrtbl.OgretmenEkle(new Ogretmen {TC= txtTC.Text.Trim(), Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim()});
                MessageBox.Show(sonuc ? "Ekleme Başarılı" : "Ekleme Başarısız!!");

            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numaralı öğretmen daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show("Veritabanı Hatası");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu!");
            }
        }
    }
}
