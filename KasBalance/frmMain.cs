using Protowire;
using System.Diagnostics;
using Grpc.Core;
using static Protowire.RPC;
using Google.Protobuf.WellKnownTypes;

namespace KasBalance
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void llCheck_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BalanceCheck(txtAddress.Text);
        }

        private async void BalanceCheck(string strAdress)
        {
            string strConn = "http://" + txtIP.Text + ":" + txtPort.Text;
            KasClient kc = new KasClient(strConn);
            using var messageStream = kc.Client.MessageStream();
            double dBalance = 0;

            KaspadMessage getUTXOsRequest = new KaspadMessage
            {
                GetUtxosByAddressesRequest = new GetUtxosByAddressesRequestMessage
                {
                    Addresses = { strAdress } // change this to your address
                                              //             Addresses = { "kaspa:qq8vljkccder84lnch6je68z426smzs8are6060535e50dmg9dzl6xuznrf53" } // change this to your address
                }
            };

            await messageStream.RequestStream.WriteAsync(getUTXOsRequest);
            await messageStream.ResponseStream.MoveNext();
            var response = messageStream.ResponseStream.Current;

            Trace.WriteLine("UTXOs by address:");
            ulong nTotal = 0;
            foreach (UtxosByAddressesEntry ab in response.GetUtxosByAddressesResponse.Entries)
            {
                Trace.WriteLine(ab.ToString());
                nTotal += ab.UtxoEntry.Amount;
            }
            dBalance = nTotal / 100000000.0;
            Trace.WriteLine("×ÜÓà¶î£º" + dBalance);

            txtBalance.Text = string.Format("{0:F8}", dBalance); //dBalance.ToString();
        }
    }
}