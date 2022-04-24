using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TcpChannel tcp = new TcpChannel(1000);
            ChannelServices.RegisterChannel(tcp);
            
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(UzakNesne.Nesne), "AdSoyad", WellKnownObjectMode.SingleCall);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(UzakNesne.Nesne), "KucukHarf",
                WellKnownObjectMode.SingleCall);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(UzakNesne.Nesne), "BuyukHarf",
                WellKnownObjectMode.SingleCall);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(UzakNesne.Nesne), "TersÇevir",
                WellKnownObjectMode.SingleCall);
        }
    }
}
