using System.Net.NetworkInformation;

namespace WinForms.Exercise.Asinhrono
{
    public partial class frmPing : Form
    {
        private string _sadrzaj;
        public frmPing()
        {
            InitializeComponent();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            var threadGoogle = new Thread(() => Ping("www.google.ba"));
            var threadOlx = new Thread(() => Ping("www.olx.ba"));
            PrikaziSadrzaj();

            threadGoogle.Start();
            threadOlx.Start();
        }

        private void Ping(string adresa, int brojPokusaja = 10, int sleep = 200)
        {
            try
            {
                var ping = new Ping();
                for (int i = 0; i < brojPokusaja; i++)
                {
                    var reply = ping.Send(adresa);

                    _sadrzaj += $"{i + 1}. {reply.Address}\t\t{reply.RoundtripTime}\t{reply.Status}{Environment.NewLine}";
                    //BeginInvoke(PrikaziSadrzaj);
                    Thread.Sleep(sleep);
                }
                
            }
            catch (Exception ex)
            {
                _sadrzaj += ex.Message;
            }
        }

        private void PrikaziSadrzaj()
        {
            txtSadrzaj.Text += _sadrzaj;
        }
    }
}
