using System;

using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UzakNesne.Nesne nesne;

        private void Form1_Load(object sender, EventArgs e)
        {
            nesne = Activator.GetObject(typeof(UzakNesne.Nesne), "tcp://localhost:1000/AdSoyad") as UzakNesne.Nesne;                                                           
            nesne = Activator.GetObject(typeof(UzakNesne.Nesne), "tcp://192.168.1.223:1000/KucukHarf") as UzakNesne.Nesne;                                                        
            nesne = Activator.GetObject(typeof(UzakNesne.Nesne), "tcp://192.168.1.223:1001/BuyukHarf") as UzakNesne.Nesne;                                                        
            nesne = Activator.GetObject(typeof(UzakNesne.Nesne), "tcp://192.168.1.223:1000/TersCevir") as UzakNesne.Nesne;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IslemSonucu.Text = nesne.KucukHarfCevir(AnaMetin.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(nesne.AdSoyadVer());
        }
    }
}
