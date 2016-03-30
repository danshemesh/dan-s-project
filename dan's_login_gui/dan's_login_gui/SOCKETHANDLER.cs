using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace dan_s_login_gui
{
    public class SOCKETHANDLER
    {
        private Socket sck;
        private IPEndPoint iep;
        public Stream stm;
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
        public string RecvStr(int BUFFSIZE)
        {
            return Encoding.UTF8.GetString(Recv(BUFFSIZE));
        }
        public byte[] Recv(int BUFFSIZE)
        {
            byte[] buffer = new byte[BUFFSIZE];
            int l = -1;
            List<byte> recvBuffer = new List<byte>();
            while (true)
            {
                l = this.sck.Receive(buffer);
                if (l > 0)
                {
                    recvBuffer.AddRange(buffer.Take(l));
                }
                if (l < BUFFSIZE)
                {
                    break;
                }
            }
            return recvBuffer.ToArray();
        }
        public string Recv2()
        {
            byte[] bb = new byte[1024];
            int k = this.stm.Read(bb, 0, 1024);
            string info = "";
            for (int i = 0; i < k; i++)
                info = info + Convert.ToString(bb[i]);
            return info;

        }
    }
}
