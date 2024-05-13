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
    public partial class frmAracEkle : Form
    {
        Arac_Kiralama arac_kira = new Arac_Kiralama();
        public frmAracEkle()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string cumle = "insert into arac(plaka,marka,seri,yil,renk,km,yakit,ucret,tarih,durum) values(@plaka,@marka,@seri,@yil,@renk,@km,@yakit,@ucret,@tarih,@durum)";
            SqlCommand komutGir = new SqlCommand();
            komutGir.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komutGir.Parameters.AddWithValue("@marka", cmbMarka.Text);
            komutGir.Parameters.AddWithValue("@seri", cmbSeri.Text);
            komutGir.Parameters.AddWithValue("@yil", txtYil.Text);
            komutGir.Parameters.AddWithValue("@renk", txtRenk.Text);
            komutGir.Parameters.AddWithValue("@km", txtKm.Text);
            komutGir.Parameters.AddWithValue("@yakit", cmbYakit.Text);
            komutGir.Parameters.AddWithValue("@ucret", txtUcret.Text);
            komutGir.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komutGir.Parameters.AddWithValue("@durum", "BOŞ");
            arac_kira.ekle_sil_guncelle(komutGir, cumle);
            foreach (Control Item in Controls) if (Item is TextBox) Item.Text = "";
            foreach (Control Item in Controls) if (Item is ComboBox) Item.Text = "";
            MessageBox.Show("Araç Eklendi");
        }
    }
}
