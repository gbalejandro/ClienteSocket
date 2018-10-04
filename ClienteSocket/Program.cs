using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClienteSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            Enviar();
        }

        private static void Enviar()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            string datosAEnviar = "hola Alex";
            string ipDestino = "127.0.0.1";
            int puertoDestino = 8000;
            byte[] datosEnBytes = Encoding.Default.GetBytes(datosAEnviar);
            EndPoint ipPuertoRemoto = new IPEndPoint(IPAddress.Parse(ipDestino), puertoDestino);
            socket.SendTo(datosEnBytes, ipPuertoRemoto);
            //si ya tienes un EndPoint como por ejemplo el de quien  
            //te ha enviado datos, entonces puedes usar ese en el método SendTo 
        }
    }
}
