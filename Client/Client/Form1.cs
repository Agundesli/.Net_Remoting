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
            nesne = Activator.GetObject(typeof(UzakNesne.Nesne), "tcp://192.168.1.9:1001/IsimAl") as UzakNesne.Nesne;
            nesne = Activator.GetObject(typeof(UzakNesne.Nesne), "tcp://localhost:1001/SoyisimAl") as UzakNesne.Nesne;
            nesne = Activator.GetObject(typeof(UzakNesne.Nesne), "tcp://localhost:1001/KucukHarf") as UzakNesne.Nesne;
            nesne = Activator.GetObject(typeof(UzakNesne.Nesne), "tcp://localhost:1001/KucukHarf") as UzakNesne.Nesne;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nesne.IsimVer());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IslemSonucu.Text = nesne.KucukHarfCevir(AnaMetin.Text);
            IslemSonucu.SelectionStart = IslemSonucu.Text.Length;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IslemSonucu.Text = nesne.BuyukHarfCevir(AnaMetin.Text);
            IslemSonucu.SelectionStart = IslemSonucu.Text.Length;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IslemSonucu.Text = nesne.TersCevir(AnaMetin.Text);
        }
    }
}
