using System;
using System.Net;
using System.Net.Sockets;
using System.Text;



class Program 
{
    static void Main(string[] args) 
    {
        UdpClient receivingUdpClient = new UdpClient(11000); // porta do dispositivo que recebe
        IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0); // pega o ip da maquina
        try{

            while (true)
            {
                Byte[] receiveBytes = receivingUdpClient.Receive(ref RemoteIpEndPoint);

                string returnData = Encoding.ASCII.GetString(receiveBytes);

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Messagem recebida:" + returnData.ToString());
                Console.WriteLine("Messagem enviada do ip: " +
                                            RemoteIpEndPoint.Address.ToString() +
                                            " - Porta: " +
                                            RemoteIpEndPoint.Port.ToString());     
            }
        }
        catch ( Exception e ){
            Console.WriteLine(e.ToString());
        }
  
            
    }


}
 