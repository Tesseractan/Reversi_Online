using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Timers;
using System.Runtime.Serialization.Formatters.Binary;
using ReversiSerializableTypes;

namespace Reversi_Online
{
    /*static class Server
    {
        private static bool isReconnecting = false;
        
        static readonly IPEndPoint endPoint = new IPEndPoint(new IPAddress(new byte[4] { 192, 168, 1, 16 }), 2018);

        private static ServerDialog dialog;
        private static bool connected;
        static Server()
        {
            dialog = new ServerDialog(endPoint);
        }
        public static void Stimulate() { }
        public static ServerDialog Dialog => dialog;
        public static bool Connected => connected;
    }*/
    public enum ConnectionState
    {
        Disconnected, Connecting, Connected
    }
    public class ServerDialog : IDisposable
    {
        private TcpClient tcpClient;
        private NetworkStream stream;
        private ASCIIEncoding ascii = new ASCIIEncoding();
        private Serializer serializer = new Serializer();
        private IPEndPoint endPoint;
        protected ConnectionState state;
        protected Dictionary<string, object> info = new Dictionary<string, object>();
        private bool abortReconnecting;
        public event EventHandler Connected;
        public event EventHandler Disconnected;
        public ServerDialog(IPEndPoint endPoint)
        {
            this.endPoint = endPoint;
            
            /*Thread connecting = new Thread(() => { TryConnect(); });
            connecting.Start();*/
            
        }
        public void Connect()
        {
            BeginReconnecting();
        }
        ~ServerDialog()
        {
            this.Dispose();
        }
        public void Close()
        {
            if (stream != null)
            {
                this.stream.Close();
                this.stream.Dispose();
                this.tcpClient.Close();
                this.tcpClient.Dispose();
            }
            this.AbortReconnecting();
            this.state = ConnectionState.Disconnected;
        }
        public void Dispose()
        {
            this.Close();
        }
        private void AbortReconnecting()
        {
            this.abortReconnecting = true;
        }
        private bool TryConnect()
        {
            ConnectionState earlierState = this.state;
            this.state = ConnectionState.Connecting;
            try
            {
                //System.Windows.Forms.MessageBox.Show("trying to connect the server");
                this.tcpClient = new TcpClient();
                tcpClient.Connect(this.endPoint);
                if (!tcpClient.Connected) throw new SocketException(); 
                this.stream = tcpClient.GetStream(); //error occured here four times :( and I don't know why?
                //System.Windows.Forms.MessageBox.Show("successfully connected the server");
                this.state = ConnectionState.Connected;
                this.Connected?.Invoke(this, new EventArgs());
                return true;
            }
            catch (SocketException)
            {
                //System.Windows.Forms.MessageBox.Show("cannot connect the server");
                this.state = ConnectionState.Disconnected;
                if (earlierState != ConnectionState.Disconnected)
                {
                    this.Disconnected?.Invoke(this, new EventArgs());
                }
                return false;
            }
        }
        private Thread BeginReconnecting()
        {
            if (this.state!=ConnectionState.Connecting)
            {
                Thread reconnecting = new Thread(() =>
                {
                    while (true)
                    {
                        if (abortReconnecting)
                        {
                            break;
                        }
                        else
                        {
                            //System.Windows.Forms.MessageBox.Show("Reconnecting, thread: " + Thread.CurrentThread.Name);
                            if (TryConnect()) break;
                            //this.state = ConnectionState.Connecting;
                            Thread.Sleep(1000);
                            
                        }
                    }
                });
                reconnecting.Start();
                return reconnecting;
            }
            else return null;
        }
        public bool SendBytes(byte[] bytes)
        {
            try
            {
                this.stream.Write(bytes, 0, bytes.Length);
                return true;
            }
            catch (Exception)
            {
                /*if (this.state == ConnectionState.Connected)
                {
                    this.state = ConnectionState.Disconnected;
                }*/
                /*while (!TryConnect()) {
                    System.Windows.Forms.MessageBox.Show("Send reconncting, thread: " + Thread.CurrentThread.Name);  Thread.Sleep(1000);
                }*/

                //SendBytes(bytes);
                BeginReconnecting();
                return false;

            }
        }

        public byte[] ReceiveBytes()
        {
            List<byte> data = new List<byte>();
            try
            {
                do
                {
                    byte[] bitOctet = new byte[1];
                    stream.Read(bitOctet, 0, bitOctet.Length);
                    data.AddRange(bitOctet);
                }
                while (this.stream.DataAvailable);
                return data.ToArray();
            }
            catch (Exception)
            {
                /*if (this.state == ConnectionState.Connected)
                {
                    this.state = ConnectionState.Disconnected;
                }*/
                /*while (!TryConnect()) {
                    System.Windows.Forms.MessageBox.Show("Receive reconncting, thread: "+Thread.CurrentThread.Name); Thread.Sleep(1000);
                }*/
                //return ReceiveBytes();
                BeginReconnecting();
                return null;
            }
        }
        public bool SendText(string message)
        {
            return SendBytes(ascii.GetBytes(message.ToArray()));
        }
        public string ReceiveText()
        {
            return ascii.GetString(ReceiveBytes());
        }
        public bool SendObject(object @object)
        {
            return SendBytes(this.serializer.Serialize(@object));
        }
        public object ReceiveObject()
        {
            byte[] bytes = ReceiveBytes();
            if (bytes != null)
            {
                return this.serializer.Deserialize(bytes);
            }
            else return null;
        }
        public bool SendMessage(string title, params (string, object)[] payload)
        {
            Message message = new Message();
            message.Title = title;
            for (int i = 0; i < payload.Length; i++)
            {
                message.Payload.Add(payload[i].Item1, payload[i].Item2);
            }
            return SendObject(message);
        }
        public Message ReceiveMessage()
        {
            return (Message)ReceiveObject();
        }

        public IPEndPoint EndPoint;
        public ConnectionState State => this.state;
        public Dictionary<string, object> Info => this.info;
        public class Reactions
        {
            public Action RequestSentCallback;
            public Action<Message> MessageReceivedCallback;
            public Action DisconnectionErrorCallback;
        }

    }
}
