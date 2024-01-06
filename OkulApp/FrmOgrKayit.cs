using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OkulApp.BLL;
using System.CodeDom;

namespace OkulApp
{
    public partial class FrmOgrKayit : Form
    {
        public int Ogrenciid { get; set; }
        public FrmOgrKayit()
        {
            InitializeComponent();
        }

        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                bool sonuc = obl.OgrenciEkle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı" : "Ekleme Başarısız!!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numaralı öğrenci daha önce kayıtlı");
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

      /*  private void txtSil_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (int.TryParse(txtid.Text.Trim(), out int OgrenciId))
                {
                    DialogResult result1 = MessageBox.Show("Silme işlemine emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        var obl = new OgrenciBL();
                        bool sonuc = obl.OgrenciSil(new Ogrenci { Ogrenciid = OgrenciId });
                        MessageBox.Show(sonuc ? "Öğrenci silme başarılı" : "Silme başarısız");
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz ID formatı! Lütfen bir tamsayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //var obl = new OgrenciBL();
                //bool sonuc = obl.OgrenciSil(new Ogrenci { Ogrenciid = OgrenciId });
                //MessageBox.Show(sonuc ? "Silme işlemi Başarılı" : "Silme işlemi Başarısız!!");
            }

            
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numaralı öğrenci daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show("Veritabanı Hatası");
                        break;
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }*/

        private void btnBul_Click(object sender, EventArgs e)
        {
            frmOgrBul frm = new frmOgrBul(this);
            frm.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var obl = new OgrenciBL();
            MessageBox.Show( obl.OgrenciGuncelle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim(), Ogrenciid = Ogrenciid }) ? "Güncelleme Başarılı": "Güncelleme Başrısız!!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var obl = new OgrenciBL();
            //obl.OgrenciSil(Ogrenciid);
            MessageBox.Show(obl.OgrenciSil(Ogrenciid) ? "Silme Başarılı" : "Silme Başarısız!!");
        }
    }
    //Güncelleme Başarılı mesajı
    //Güncelleme butonu aktifliği?
    //Silme butonu aktifliği
    //Silme işlemi mesajı
    //Tüm işlemlerde try-catch
    //Helperda bulunan connection ve commandlerin dispose edilmesi (IDisposable Pattern)
    //Singleton Pattern (Sürkeli nesne oluşmadan tek nesne üstünden işlemlerin yapılması)
    //Öğretmen entity'si için kalan CRUD işlemleri

   /* interface ITransfer
    {
        int Eft(string gondericiiban, string aliciiban, double tutar);
        int Havale(string gondericiiban, string aliciiban, double tutar);

    }
    class Transfer : ITransfer
    {
        public int Eft(string gondericiiban, string aliciiban, double tutar)
        {
            throw new NotImplementedException();
        }

        public int Havale(string gondericiiban, string aliciiban, double tutar)
        {
            throw new NotImplementedException();
        }

        
    }*/
}
//garbage collector 
//garbage coolector sqlconnection gibi dışarıdan alınan verilere dokunmaz eğer bir sınıfta Idispose interface i kullanılmışsıa garbage collector dokunmaz ve onu bizim kendimiz dispose etmemiş gerekir
//using bellekte kullanılıan şeyleri dispose yapar ve conneciton ı otomatik kapatır