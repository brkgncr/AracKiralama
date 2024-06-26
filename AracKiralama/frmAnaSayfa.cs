﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMusteriListele listele = new frmMusteriListele();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAracEkle kayit = new frmAracEkle();
            kayit.ShowDialog();
        }

        private void btnAracListeleme_Click(object sender, EventArgs e)
        {
            frmAracListele listele = new frmAracListele();
            listele.ShowDialog();
        }

        private void btnKiralama_Click(object sender, EventArgs e)
        {
            frmKiralama kiralama = new frmKiralama();
            kiralama.ShowDialog();
        }
    }
}
