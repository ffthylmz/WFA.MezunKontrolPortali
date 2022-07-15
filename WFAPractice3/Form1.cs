using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAPractice3.Classes;

namespace WFAPractice3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cboxHarfNotu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxHarfNotu.SelectedIndex = 0;

            cboxAkts.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxAkts.SelectedIndex = 0;

            cboxDersKredisi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxDersKredisi.SelectedIndex = 0;
        }

        List<Ders> dersler = new List<Ders>();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ders eklenecekDers = new Ders();

            eklenecekDers.DersAdi = txtDersAdi.Text;
            eklenecekDers.DersKodu = txtDersKodu.Text;
            eklenecekDers.DersKredisi = Convert.ToInt32(cboxDersKredisi.Text);
            eklenecekDers.AKTS = Convert.ToInt32(cboxAkts.Text);
            eklenecekDers.HarfNotu = cboxHarfNotu.Text;

            dersler.Add(eklenecekDers);  // GİRİLEN DERS BİLGİLERİNİ LİSTEYE EKLEDİM.

            dataGridView1.DataSource = dersler.ToList();  // ToList() ; her butona basıldığında txtboxlardaki metinleri listeye ekleyecek.
        }
        private void btnHesapla_Click_1(object sender, EventArgs e)
        {
            double katsayi = 0;
            double ort = 0;
            double krediToplami = 0;
            double aktsToplam = 0;

            foreach (Ders item in dersler)
            {
                switch (item.HarfNotu)
                {
                    case "AA":
                        katsayi = 4;
                        break;

                    case "BA":
                        katsayi = 3.5;
                        break;

                    case "BB":
                        katsayi = 3;
                        break;

                    case "CB":
                        katsayi = 2.5;
                        break;

                    case "CC":
                        katsayi = 2;
                        break;

                    case "DC":
                        katsayi = 1.5;
                        break;

                    case "DD":
                        katsayi = 1;
                        break;

                    case "FF":
                        katsayi = 0;
                        break;
                }

                ort += katsayi * item.DersKredisi;
                krediToplami += item.DersKredisi;
                aktsToplam += item.AKTS;
            }

            ort /= krediToplami;
            MessageBox.Show("Dönem Ortalaması: " + ort);

            if (aktsToplam < 10)
                MessageBox.Show("Mezun Olamazsınız. En az 240 AKTS' lik ders almanız gerekmektedir!");
            else if (dersler.Any(od => od.HarfNotu == "FF"))
                MessageBox.Show("FF dersiniz veya dersleriniz bulunmaktadır, mezun olamazsınız!");
            else if (dersler.Any(od => od.HarfNotu == "DD") && ort < 2.2)
                MessageBox.Show("Ortalamanız 2.2 nin altında ve DD dersiniz ya da dersleriniz mevcut. Mezun Olamazsınız!");
            else
                MessageBox.Show("Mezun Olabilirsiniz...");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSecilenDers.Text = "";
            lblSecilenDers.Text = (dataGridView1.CurrentCell.RowIndex +1).ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Ders guncellenecekDers = dersler[dataGridView1.CurrentCell.RowIndex];

            guncellenecekDers.DersAdi = txtDersAdi.Text;
            guncellenecekDers.DersKodu = txtDersKodu.Text;
            guncellenecekDers.DersKredisi = Convert.ToInt32(cboxDersKredisi.Text);
            guncellenecekDers.AKTS = Convert.ToInt32(cboxAkts.Text);
            guncellenecekDers.HarfNotu = cboxHarfNotu.Text;

            dataGridView1.DataSource = dersler.ToList();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Ders silinecekDers = dersler[dataGridView1.CurrentCell.RowIndex];
            dersler.Remove(silinecekDers);
            dataGridView1.DataSource = dersler.ToList();

        }
    }
}
