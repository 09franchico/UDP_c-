using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class UDPListener // Recebe um brodcats na rede
{
    private const int listenPort = 11000;

    private static void StartListener()
    {
        UdpClient listener = new UdpClient(listenPort);
        IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);

        try
        {
            while (true)
            {
                Console.WriteLine("Aguardando envio do pacote...");
                byte[] bytes = listener.Receive(ref groupEP);

                Console.WriteLine("Transmissão recebida de"+groupEP+":");
                Console.WriteLine(Encoding.ASCII.GetString(bytes, 0, bytes.Length));
            }
        }
        catch (SocketException e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            listener.Close();
        }
    }

    public static void Main()
    {
        StartListener();
    }
}
