using SuperSimpleTcp;
using System.Diagnostics.CodeAnalysis;
using System.Media;
using System.Text;

namespace HangmanServer
{
    public partial class Form1 : Form
    {
        SimpleTcpServer server;
        GameLogic logic;
        List<Player> players = new List<Player>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logic = new GameLogic();
            btn_stop.Enabled = false;
            server = new SimpleTcpServer("127.0.0.1:9000");
            server.Events.DataReceived += Events_DataReceived;
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            players.Remove(FindPlayerOnIP(e.IpPort));
            listClients.Items.Remove(e.IpPort);
        }
        Player FindPlayerOnIP(string ip)
        {
            foreach (var player in players)
            {
                if(player.ip == ip)
                    return player;
            }
            return null;
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            players.Add(new Player(e.IpPort));
            listClients.Items.Add(e.IpPort);
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            if (!logic.CheckInput(Encoding.UTF8.GetString(e.Data.Array)[0]))
            {
                Player.hp--;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            server.Start();
            btn_start.Enabled = false;
            btn_stop.Enabled = true;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            server.Stop();
            btn_start.Enabled = true;
            btn_stop.Enabled = false;
        }
    }
}