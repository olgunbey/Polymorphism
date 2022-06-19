using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {     
            if(comboBox1.SelectedIndex==0)
            {
                Calisan insankaynaklari = new InsanKaynaklari(comboBox1.SelectedIndex);
                MessageBox.Show("Insan Kaynakları maaşı:"+insankaynaklari.maasHesapla());
            }
            else if(comboBox1.SelectedIndex==1)
            {
                Calisan developer = new Developer(comboBox1.SelectedIndex);
                MessageBox.Show("Developer maaşı: "+developer.maasHesapla());
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Calisan yonetım = new Yonetim(comboBox1.SelectedIndex);
                MessageBox.Show("Yonetim maaşı: " + yonetım.maasHesapla());
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Calisan temizlikci = new Temizlikci(comboBox1.SelectedIndex);
                MessageBox.Show("Temizlikçi maaşı: " + temizlikci.maasHesapla());
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
