using SuperSimpleTcp;
namespace HangmanClient
{
    public partial class Form1 : Form
    {
        SimpleTcpClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient("127.0.0.1:9000");
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            btn_connect.Enabled = false;
            btn_disconnect.Enabled = true;
            client.Connect();
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            btn_disconnect.Enabled = false;
            btn_connect.Enabled = true;
            client.Disconnect();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            client.Send(e.KeyCode.ToString());
        }
    }
}