using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

//---------------------------------------------
class Program // Envia um brodcast na rede
{
    static void Main(string[] args) // Passa o argumento para envio.
    {
        Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        IPAddress broadcast = IPAddress.Parse("192.168.0.255");

        byte[] sendbuf = Encoding.ASCII.GetBytes(args[0]);
        IPEndPoint ep = new IPEndPoint(broadcast, 20000);

        s.SendTo(sendbuf, ep);

        Console.WriteLine("Message sent to the broadcast address");
    }


}
