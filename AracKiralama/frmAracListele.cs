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
    public partial class frmAracListele : Form
    {
        Arac_Kiralama kiralama = new Arac_Kiralama();
        public frmAracListele()
        {
            InitializeComponent();
        }

        private void dgvListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dgvListele.CurrentRow;
            txtPlaka.Text = satır.Cells["plaka"].Value.ToString();
            cmbMarka.Text = satır.Cells["marka"].Value.ToString();
            cmbSeri.Text = satır.Cells["seri"].Value.ToString();
            txtYil.Text = satır.Cells["yil"].Value.ToString();
            txtRenk.Text = satır.Cells["renk"].Value.ToString();
            txtKm.Text = satır.Cells["km"].Value.ToString();
            cmbYakit.Text = satır.Cells["yakit"].Value.ToString();
            txtUcret.Text = satır.Cells["ucret"].Value.ToString();
        }

        private void frmAracListele_Load(object sender, EventArgs e)
        {
            yenileListele();
            cmbAraclar.SelectedIndex = 0;

        }

        private void yenileListele()
        {
            string cumle = "select * from arac";
            SqlDataAdapter goster = new SqlDataAdapter();
            dgvListele.DataSource = kiralama.listele(goster, cumle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cumle = "update arac set marka=@marka, seri=@seri, yil=@yil, renk=@renk, km=@km, yakit=@yakit, ucret=@ucret, tarih=@tarih where plaka=@plaka";
            SqlCommand guncelle = new SqlCommand();
            guncelle.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            guncelle.Parameters.AddWithValue("@marka", cmbMarka.Text);
            guncelle.Parameters.AddWithValue("@seri", cmbSeri.Text);
            guncelle.Parameters.AddWithValue("@yil", txtYil.Text);
            guncelle.Parameters.AddWithValue("@renk", txtRenk.Text);
            guncelle.Parameters.AddWithValue("@km", txtKm.Text);
            guncelle.Parameters.AddWithValue("@yakit", cmbYakit.Text);
            guncelle.Parameters.AddWithValue("@ucret", txtUcret.Text);
            guncelle.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            kiralama.ekle_sil_guncelle(guncelle, cumle);
            foreach (Control Item in Controls) if (Item is TextBox) Item.Text = "";
            foreach (Control Item in Controls) if (Item is ComboBox) Item.Text = "";
            yenileListele();
            MessageBox.Show("Araç Güncellendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dgvListele.CurrentRow;
            string cumle = "delete from arac where plaka='" + satir.Cells["plaka"].Value.ToString()+"'";
            SqlCommand sil = new SqlCommand();
            kiralama.ekle_sil_guncelle(sil, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control Item in Controls) if (Item is ComboBox) Item.Text = "";
            yenileListele();
            MessageBox.Show("Araç Silindi");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control Item in Controls) if (Item is TextBox) Item.Text = "";
            foreach (Control Item in Controls) if (Item is ComboBox) Item.Text = "";
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbSeri.Items.Clear();
                //Audi
                if (cmbMarka.SelectedIndex == 0)
                {
                    cmbSeri.Items.Add("A3");
                    cmbSeri.Items.Add("A4");
                    cmbSeri.Items.Add("A5");
                    cmbSeri.Items.Add("A6");
                    cmbSeri.Items.Add("A7");
                    cmbSeri.Items.Add("A8");
                }
                //Mercedes
                if (cmbMarka.SelectedIndex == 1)
                {
                    cmbSeri.Items.Add("GLA");
                    cmbSeri.Items.Add("EQS");
                    cmbSeri.Items.Add("GLS");
                    cmbSeri.Items.Add("GLC");
                    cmbSeri.Items.Add("EQE");
                    cmbSeri.Items.Add("CLS");
                }
                //BMW
                if (cmbMarka.SelectedIndex == 2)
                {
                    cmbSeri.Items.Add("iX");
                    cmbSeri.Items.Add("i4");
                    cmbSeri.Items.Add("i5");
                    cmbSeri.Items.Add("M8");
                    cmbSeri.Items.Add("i7");
                    cmbSeri.Items.Add("X1");
                }
                //Volvo
                if (cmbMarka.SelectedIndex == 3)
                {
                    cmbSeri.Items.Add("S69");
                    cmbSeri.Items.Add("S90");
                    cmbSeri.Items.Add("XC60");
                    cmbSeri.Items.Add("XC90");
                    cmbSeri.Items.Add("C40");
                }
                //Peugeot
                if (cmbMarka.SelectedIndex == 4)
                {
                    cmbSeri.Items.Add("208");
                    cmbSeri.Items.Add("308");
                    cmbSeri.Items.Add("407");
                    cmbSeri.Items.Add("508");
                    cmbSeri.Items.Add("3008");
                    cmbSeri.Items.Add("5008");
                }
                //Renault
                if (cmbMarka.SelectedIndex == 5)
                {
                    cmbSeri.Items.Add("Captur");
                    cmbSeri.Items.Add("Koleas");
                    cmbSeri.Items.Add("Clio");
                    cmbSeri.Items.Add("Kangoo");
                    cmbSeri.Items.Add("Megane");
                    cmbSeri.Items.Add("Triber");
                }
                //Fiat
                if (cmbMarka.SelectedIndex == 6)
                {
                    cmbSeri.Items.Add("500");
                    cmbSeri.Items.Add("Panda");
                    cmbSeri.Items.Add("Doblo");
                    cmbSeri.Items.Add("Linea");
                    cmbSeri.Items.Add("Punto");
                    cmbSeri.Items.Add("124 Spider");
                }
                //Ford
                if (cmbMarka.SelectedIndex == 7)
                {
                    cmbSeri.Items.Add("Mustang");
                    cmbSeri.Items.Add("Fiesta");
                    cmbSeri.Items.Add("Aspire");
                    cmbSeri.Items.Add("Ranger");
                    cmbSeri.Items.Add("Everest");
                    cmbSeri.Items.Add("Focus");
                }
            }
            catch
            {

            }
        }

        private void cmbAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbAraclar.SelectedIndex == 0)
                {
                    yenileListele();
                }
                if (cmbAraclar.SelectedIndex == 1)
                {
                    string cumle = "select * from arac where durum='BOŞ'";
                    SqlDataAdapter goster = new SqlDataAdapter();
                    dgvListele.DataSource = kiralama.listele(goster, cumle);
                }
                if (cmbAraclar.SelectedIndex == 2)
                {
                    string cumle = "select * from arac where durum='DOLU'";
                    SqlDataAdapter goster = new SqlDataAdapter();
                    dgvListele.DataSource = kiralama.listele(goster, cumle);
                }
            }
            catch 
            { 

            }
        }
    }
}
