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
    public partial class frmKiralama : Form
    {
        Arac_Kiralama kira = new Arac_Kiralama();
        public frmKiralama()
        {
            InitializeComponent();
        }

        private void frmKiralama_Load(object sender, EventArgs e)
        {
            bos_araclar();
            yenile();
        }

        private void bos_araclar()
        {
            string sorgu = "select * from arac where durum='BOŞ'";
            kira.bos_araclar(cmbAraclar, sorgu);
        }

        private void yenile()
        {
            string sorgu2 = "select * from kiralama";
            SqlDataAdapter goster = new SqlDataAdapter();
            dgvListele.DataSource = kira.listele(goster, sorgu2);
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from arac where plaka like '" + cmbAraclar.SelectedItem + "'";
            kira.arac_getir(cmbAraclar, txtMarka, txtSeri, txtYil, txtRenk, sorgu);
        }

        private void cmbKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from arac where plaka like '" + cmbAraclar.SelectedItem + "'";
            kira.ucret_hesapla(cmbKiraSekli, txtUcret, sorgu);

            /* Elim çarptı
            private void groupBox2_Enter(object sender, EventArgs e)
            {

            }
            */
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gunFarki = DateTime.Parse(dtpDonus.Text) - DateTime.Parse(dtpCikis.Text);
            int gunFarkiHesapla = gunFarki.Days;
            txtGun.Text = gunFarkiHesapla.ToString();
            txtTutar.Text = (gunFarkiHesapla * int.Parse(txtUcret.Text)).ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void temizle()
        {
            dtpCikis.Text = DateTime.Now.ToShortDateString();
            dtpDonus.Text = DateTime.Now.ToShortDateString();
            cmbKiraSekli.Text = "";
            txtUcret.Text = "";
            txtGun.Text = "";
            txtTutar.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string cumle = "insert into kiralama(tc,adsoyad,telefon,ehliyetno,plaka,marka,seri,yil,renk,kirasekli,kiraucreti,gun,tutar,cikistarihi,donustarihi) values(@tc,@adsoyad,@telefon,@ehliyetno,@plaka,@marka,@seri,@yil,@renk,@kirasekli,@kiraucreti,@gun,@tutar,@cikistarihi,@donustarihi)";
            SqlCommand komutGir = new SqlCommand();
            komutGir.Parameters.AddWithValue("@tc", txtTc.Text);
            komutGir.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komutGir.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komutGir.Parameters.AddWithValue("@ehliyetno", txtEno.Text);
            komutGir.Parameters.AddWithValue("@plaka", cmbAraclar.Text);
            komutGir.Parameters.AddWithValue("@marka", txtMarka.Text);
            komutGir.Parameters.AddWithValue("@seri", txtSeri.Text);
            komutGir.Parameters.AddWithValue("@yil", txtYil.Text);
            komutGir.Parameters.AddWithValue("@renk", txtRenk.Text);
            komutGir.Parameters.AddWithValue("@kirasekli", cmbKiraSekli.Text);
            komutGir.Parameters.AddWithValue("@kiraucreti", int.Parse(txtUcret.Text));
            komutGir.Parameters.AddWithValue("@gun", int.Parse(txtGun.Text));
            komutGir.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komutGir.Parameters.AddWithValue("@cikistarihi", dtpCikis.Text);
            komutGir.Parameters.AddWithValue("@donustarihi", dtpDonus.Text);


            kira.ekle_sil_guncelle(komutGir, cumle);

            string cumle2 = "update arac set durum = 'DOLU' where plaka = '" + cmbAraclar.Text + "' ";
            SqlCommand komutGir2 = new SqlCommand();
            kira.ekle_sil_guncelle(komutGir2, cumle2);
            cmbAraclar.Items.Clear();
            bos_araclar();
            yenile();


            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            cmbAraclar.Text = "";
            temizle();
            MessageBox.Show("Sözleşme Eklendi");
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            if (txtTcAra.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu = "select * from musteri where tc like '" + txtTcAra.Text + "'";
            kira.tc_ara(txtTcAra, txtTc, txtAdSoyad, txtTelefon, sorgu);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cumle = "update kiralama set tc=@tc, adsoyad=@adsoyad, telefon=@telefon, ehliyetno=@ehliyetno, plaka=@plaka, marka=@marka, seri=@seri, yil=@yil, renk=@renk, kirasekli=@kirasekli, kiraucreti=@kiraucreti, gun=@gun, tutar=@tutar, cikistarihi=@cikistarihi, donustarihi=@donustarihi where plaka=@plaka";
            SqlCommand komutGir = new SqlCommand();
            komutGir.Parameters.AddWithValue("@tc", txtTc.Text);
            komutGir.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komutGir.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komutGir.Parameters.AddWithValue("@ehliyetno", txtEno.Text);
            komutGir.Parameters.AddWithValue("@plaka", cmbAraclar.Text);
            komutGir.Parameters.AddWithValue("@marka", txtMarka.Text);
            komutGir.Parameters.AddWithValue("@seri", txtSeri.Text);
            komutGir.Parameters.AddWithValue("@yil", txtYil.Text);
            komutGir.Parameters.AddWithValue("@renk", txtRenk.Text);
            komutGir.Parameters.AddWithValue("@kirasekli", cmbKiraSekli.Text);
            komutGir.Parameters.AddWithValue("@kiraucreti", int.Parse(txtUcret.Text));
            komutGir.Parameters.AddWithValue("@gun", int.Parse(txtGun.Text));
            komutGir.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komutGir.Parameters.AddWithValue("@cikistarihi", dtpCikis.Text);
            komutGir.Parameters.AddWithValue("@donustarihi", dtpDonus.Text);
            kira.ekle_sil_guncelle(komutGir, cumle);
            
            cmbAraclar.Items.Clear();
            bos_araclar();
            yenile();

            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            cmbAraclar.Text = "";
            temizle();
            MessageBox.Show("Sözleşme Güncellendi");
        }

        private void dgvListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dgvListele.CurrentRow;
            txtTc.Text = satir.Cells[1].Value.ToString();
            txtAdSoyad.Text = satir.Cells[2].Value.ToString();
            txtTelefon.Text = satir.Cells[3].Value.ToString();
            txtEno.Text = satir.Cells[4].Value.ToString();
            cmbAraclar.Text = satir.Cells[5].Value.ToString();
            txtMarka.Text = satir.Cells[6].Value.ToString();
            txtSeri.Text = satir.Cells[7].Value.ToString();
            txtYil.Text = satir.Cells[8].Value.ToString();
            txtRenk.Text = satir.Cells[9].Value.ToString();
            cmbKiraSekli.Text = satir.Cells[10].Value.ToString();
            txtUcret.Text = satir.Cells[11].Value.ToString();
            txtGun.Text = satir.Cells[12].Value.ToString();
            txtTutar.Text = satir.Cells[13].Value.ToString();
            dtpCikis.Text = satir.Cells[14].Value.ToString();
            dtpDonus.Text = satir.Cells[15].Value.ToString();
        }
    }
}
