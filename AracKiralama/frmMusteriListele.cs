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
    public partial class frmMusteriListele : Form
    {
        Arac_Kiralama kiralama = new Arac_Kiralama();
        public frmMusteriListele()
        {
            InitializeComponent();
        }

        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            yenileListele();

        }

        private void yenileListele()
        {
            String cumle = "select * from musteri";
            SqlDataAdapter goster = new SqlDataAdapter();
            dgvListeleme.DataSource = kiralama.listele(goster, cumle);
            dgvListeleme.Columns[1].HeaderText = "TC";
            dgvListeleme.Columns[2].HeaderText = "Ad Soyad";
            dgvListeleme.Columns[3].HeaderText = "Telefon";
            dgvListeleme.Columns[4].HeaderText = "Adres";
            dgvListeleme.Columns[5].HeaderText = "Email";
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            String cumle = "select * from musteri where tc like '%"+txtAra.Text+"%'";
            SqlDataAdapter goster = new SqlDataAdapter();
            dgvListeleme.DataSource = kiralama.listele(goster, cumle);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListeleme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dgvListeleme.CurrentRow;
            txtTc.Text = satir.Cells[1].Value.ToString();
            txtAdSoyad.Text = satir.Cells[2].Value.ToString();
            txtTelefon.Text = satir.Cells[3].Value.ToString();
            txtAdres.Text = satir.Cells[4].Value.ToString();
            txtEmail.Text = satir.Cells[5].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cumle = "update musteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc";
            SqlCommand guncelle = new SqlCommand();
            guncelle.Parameters.AddWithValue("@tc", txtTc.Text);
            guncelle.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            guncelle.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            guncelle.Parameters.AddWithValue("@adres", txtAdres.Text);
            guncelle.Parameters.AddWithValue("@email", txtEmail.Text);
            kiralama.ekle_sil_guncelle(guncelle, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            yenileListele();
            MessageBox.Show("Müşeteri Güncellendi");

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dgvListeleme.CurrentRow;
            string cumle = "delete from musteri where tc='" + satir.Cells["tc"].Value.ToString() +"'";
            SqlCommand sil = new SqlCommand();
            kiralama.ekle_sil_guncelle(sil, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            yenileListele();
            MessageBox.Show("Müşteri Silindi");
        }
    }
}
