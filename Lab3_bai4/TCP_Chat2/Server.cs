using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.ComponentModel;
using System.Text;

namespace TCP_Chat2
{
    public partial class Server : Form
    {
        //private TcpClient tcpClient;
        private int PORT;
        private TcpListener listener;
        private string chat_history;
        private List<TcpClient> clients_list = new List<TcpClient>();
        static private string names = "";


        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (this.Chat_box.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Chat_box.Text = text;
            }
        }
        private void UI_AddClient(string text)
        {
            if (this.Chat_box.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(UI_AddClient);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Clients_box.Text = text;
            }
        }

        public Server()
        {
            InitializeComponent();
            Port_box.Text = "9999";
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress ip in localIP)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    IP_box.Text = ip.ToString();
                }
            }
        }
        private void Start_btn_Click(object sender, EventArgs e)
        {
            PORT= Int32.Parse(Port_box.Text);
            listener = new TcpListener(IPAddress.Any, PORT);
            listener.Start();

            if(clients_list.Count() == 0)
            {
                this.Text = "Waiting for any connections...";
            }

            Start_btn.BackColor = Color.LightGreen;

            Thread listen = new Thread(this.Listen); 
            listen.Start();
        }


        private async Task HandleClient(TcpClient client)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    chat_history += message ;
                    SetText(chat_history);
                    // Broadcast lại cho may thằng client khác
                    foreach (TcpClient otherClient in clients_list)
                    {
                        if (otherClient != client)
                        {
                            await otherClient.GetStream().WriteAsync(buffer, 0, bytesRead);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show($"Error handling client: {ex.Message}");
            }
            finally
            {
                clients_list.Remove(client);
                client.Close();
            }
        }

        private async void Listen()
        {
            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                clients_list.Add(client);
                names += client.Client.LocalEndPoint + "\n";
                UI_AddClient(names);
                Task.Run(() => { HandleClient(client); });
            }
        }

        private void Send_btn_Click(object sender, EventArgs e)
        {

        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {

        }
    }
}