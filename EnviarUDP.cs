using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


class Program 
{
    static void Main(string[] args) 
    {
    
        try{

            UdpClient UDP = new UdpClient();
            // Conectar
            UDP.Connect("192.168.0.3", 20000);
            
            //Envia os dados
            Byte[] sendBytes = Encoding.ASCII.GetBytes(args[0]);
            UDP.Send(sendBytes, sendBytes.Length);

        }
        catch (Exception e ) {
                Console.WriteLine(e.ToString());
        }
            
    }


}






