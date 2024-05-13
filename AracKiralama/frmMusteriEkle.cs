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

namespace AracKiralama
{
    public partial class frmMusteriEkle : Form
    {
        Arac_Kiralama arac_kira = new Arac_Kiralama();

        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string cumle = "insert into musteri(tc,adsoyad,telefon,adres,email) values(@tc,@adsoyad,@telefon,@adres,@email)";
            SqlCommand komutGir = new SqlCommand();
            komutGir.Parameters.AddWithValue("@tc", txtTc.Text);
            komutGir.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komutGir.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komutGir.Parameters.AddWithValue("@adres", txtAdres.Text);
            komutGir.Parameters.AddWithValue("@email", txtEmail.Text);
            arac_kira.ekle_sil_guncelle(komutGir,cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is MaskedTextBox) item.Text = "";
            MessageBox.Show("Müşteri Eklendi");
        }
    }
}
