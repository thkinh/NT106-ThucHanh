using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Text;
using System;

namespace Client
{
    public partial class Client : Form
    {
        TcpClient client;

        NetworkStream stream ;
        private string chat_history = "";
        static private string name = "Alec";
        public Client()
        {
            InitializeComponent();
            Port_box.Text = "9999";
            IP_box.Text = "127.0.0.1";

        }
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
        async void Listen_to_Server()
        {
            while (client.Connected)
            {
                string mess = "";
                byte[] data = new byte[4096];
                int bytesRead;
                try
                {
                    while ((bytesRead = await stream.ReadAsync(data,0,data.Length)) > 0)
                    {
                        string message = Encoding.UTF8.GetString(data, 0, bytesRead);
                        chat_history += message + "\n";
                        SetText(chat_history);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private async void Connect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                await client.ConnectAsync(IPAddress.Parse(IP_box.Text), Int32.Parse(Port_box.Text));

                stream = client.GetStream();
                Connect_btn.BackColor = Color.LightGreen;

                Thread listen = new Thread(Listen_to_Server);
                listen.Start();
            }
            catch
            {
                MessageBox.Show("Khong co server ton tai");
            }
        }

        private void Send_btn_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = new byte[4096];
                data = Encoding.UTF8.GetBytes(Mess_box.Text);

                stream.WriteAsync(data, 0, data.Length);
            }
            catch
            {
                MessageBox.Show("Loi khi gui tin nhan cho server");
            }
            

            chat_history += "Me: " + Mess_box.Text + "\n";
            Chat_box.Text += "Me: " + Mess_box.Text + "\n";
            Mess_box.Text = "";

        }
    }
}