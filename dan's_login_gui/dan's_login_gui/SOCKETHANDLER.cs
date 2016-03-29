using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace dan_s_login_gui
{
    public class SOCKETHANDLER
    {
        private Socket sck;
        private IPEndPoint iep;
        public SOCKETHANDLER()
        {
            this.sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public void Connect(string ip, int port)
        {
            this.iep = new IPEndPoint(IPAddress.Parse(ip), port);
            this.sck.Connect(iep);
        }
        public void Send(string text)
        {
            byte[] data = Encoding.ASCII.GetBytes(text);
            this.sck.Send(data);
        }
        public byte[] Recv(int BUFFSIZE)
        {
            byte[] buffer = new byte[BUFFSIZE];
            this.sck.Receive(buffer);
            return buffer;
        }
    }
}
