using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace DriverClient
{
    class MyUDPSocket
    {
        #region 定义
        public static byte[] recvBuffer = new byte[bufferSize];
        public const int bufferSize = 1024;
        public static string recvMessage;
        static IPAddress recvIp = IPAddress.Any;
        static IPAddress sendIp = IPAddress.Parse("127.0.0.1");
        static int recvPort = 12345;
        static int sendPort = 12346;
        static Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        static EndPoint remoteEP;
        static EndPoint epSender;
        #endregion

        #region 初始化
        public static void Init()
        {
            server.Bind(new IPEndPoint(recvIp, recvPort));
            remoteEP = (EndPoint)(new IPEndPoint(IPAddress.Any, 0));
            epSender = (EndPoint)(new IPEndPoint(sendIp, sendPort));
        }
        #endregion

        #region 发送
        public static void Send(string message)
        {
            byte[] sendBuffer = Encoding.UTF8.GetBytes(message);
            server.BeginSendTo(sendBuffer, 0, sendBuffer.Length, SocketFlags.None, epSender, null, server);
        }
        #endregion

        #region 接收
        public static void Receive()
        {
            server.BeginReceiveFrom(recvBuffer, 0, bufferSize, SocketFlags.None, ref remoteEP, new AsyncCallback(ReceiveCallback), remoteEP);
        }

        static void ReceiveCallback(IAsyncResult res)
        {
            remoteEP = (EndPoint)(new IPEndPoint(IPAddress.Any, 0));
            int recvLength = server.EndReceiveFrom(res, ref remoteEP);
            recvMessage = Encoding.UTF8.GetString(recvBuffer, 0, recvLength);
            server.BeginReceiveFrom(recvBuffer, 0, bufferSize, SocketFlags.None, ref remoteEP, new AsyncCallback(ReceiveCallback), remoteEP);
        }
        #endregion
    }
}
