using System;

using System.Windows.Forms;

namespace İstemci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UzakNesne.Nesne nesne;
        UzakNesne.Nesne nesne1;
        UzakNesne.Nesne nesne2;
        UzakNesne.Nesne nesne3;

        private void Form1_Load(object sender, EventArgs e)
        {
            nesne = Activator.GetObject(typeof(UzakNesne.Nesne), "tcp://192.168.1.9:1000/IsimAl") as UzakNesne.Nesne;
            nesne1 = Activator.GetObject(typeof(UzakNesne.Nesne),"tcp://localhost:1000/SoyisimAl") as UzakNesne.Nesne;
            nesne2= Activator.GetObject(typeof(UzakNesne.Nesne),"tcp://localhost:1000/KucukHarf")as UzakNesne.Nesne;
            nesne3= Activator.GetObject(typeof(UzakNesne.Nesne), "tcp://localhost:1000/KucukHarf") as UzakNesne.Nesne;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nesne.IsimVer());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nesne1.SoyIsımVer());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KucukHarf.Text = nesne2.KucukHarfCevir(anametin.Text);
            KucukHarf.SelectionStart = KucukHarf.Text.Length;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KucukHarf.Text = nesne3.BuyukHarfCevir(anametin.Text);
            KucukHarf.SelectionStart = KucukHarf.Text.Length;
        }
    }
}
