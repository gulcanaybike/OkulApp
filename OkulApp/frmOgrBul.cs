using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulApp
{
    public partial class frmOgrBul : Form
    {
        FrmOgrKayit frm;

        public frmOgrBul(FrmOgrKayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            var obl = new OgrenciBL();
            Ogrenci ogr = obl.OgrenciBul(txtOgrNo.Text.Trim());
            if (ogr != null)
            {
                frm.txtAd.Text = ogr.Ad;
                frm.txtSoyad.Text = ogr.Soyad;
                frm.txtNumara.Text = ogr.Numara;
                frm.Ogrenciid = ogr.Ogrenciid;
            }
            else
            {
                MessageBox.Show("Öğrenci Bulunamadı!!");
            }
        }
    }
}
