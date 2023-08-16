using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Linq;
using System.Threading;

namespace MultichatServer
{
    class Program
    {
        static int port = 11000;
        static Socket listen;
        static List<Socket> connections = new List<Socket>();
        static Dictionary<Socket, string> userNames = new Dictionary<Socket, string>();
        static Dictionary<List<Socket>, string> grupos = new Dictionary<List<Socket>, string>();

        static void Main(string[] args)
        {
            listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint connect = new IPEndPoint(IPAddress.Any, port);

            listen.Bind(connect);
            listen.Listen(10);
            Console.WriteLine("Servidor iniciado. Esperando conexiones...");

            while (true)
            {
                Socket contenedor = listen.Accept();
                connections.Add(contenedor);
                Console.WriteLine("Conexión Exitosa");

                byte[] receiveData = new byte[1024];
                int dataSize = contenedor.Receive(receiveData);
                string userName = Encoding.UTF8.GetString(receiveData, 0, dataSize);
                userNames.Add(contenedor, userName);
                Console.WriteLine("Usuario conectado: " + userName);

                SendUserList();

                Thread receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start(contenedor);
            }
        }

        static void ReceiveMessages(object socketObj)
        {
            Socket socket = (Socket)socketObj;
            string userName = userNames[socket];
           
            while (true)
            {
                byte[] receiveData = new byte[1024];
                int dataSize = socket.Receive(receiveData);

                if (dataSize > 0)
                {
                    string receivedMessage = Encoding.UTF8.GetString(receiveData, 0, dataSize);
                    Console.WriteLine(receivedMessage);

                    if (receivedMessage.StartsWith("private_message:"))
                    {
                        string recipient = receivedMessage.Split(':')[1];
                        Socket recipientSocket = userNames.FirstOrDefault(x => x.Value == recipient).Key;
                        if (recipientSocket != null)
                        {
                            byte[] sendData = Encoding.UTF8.GetBytes(receivedMessage);
                            recipientSocket.Send(sendData);
                        }
                    }
                    if (receivedMessage.StartsWith("nuevo_grupo:"))
                    {
                        string nombreGrupo = receivedMessage.Split(':')[1];
                        string receptores = receivedMessage.Split(':')[2];
                        string[] receptorArray = receptores.Split(',');

                        List<Socket> grupoSockets = new List<Socket>();

                        foreach (string receptor in receptorArray)
                        {
                            string receptorTrimmed = receptor.Trim();
                            Socket recipientSocket = userNames.FirstOrDefault(x => x.Value == receptorTrimmed).Key;
                            if (recipientSocket != null)
                            {
                                grupoSockets.Add(recipientSocket);
                            }
                        }

                        grupos.Add(grupoSockets, nombreGrupo);

                        // Enviar mensaje solo a los usuarios del grupo
                        foreach (Socket groupSocket in grupoSockets)
                        {
                            byte[] sendData = Encoding.UTF8.GetBytes(receivedMessage);
                            groupSocket.Send(sendData);
                        }
                    }
                    if (receivedMessage.StartsWith("group_message:"))
                    {
                        string nombreGrupo = receivedMessage.Split(':')[1];
                        string receptores = receivedMessage.Split(':')[2];
                        string[] receptorArray = receptores.Split(',');

                        // Buscar los sockets correspondientes al grupo
                        List<Socket> socketsGrupo = grupos.FirstOrDefault(pair => pair.Value == nombreGrupo)
                                                             .Key;

                        foreach (string receptor in receptorArray)
                        {
                            string receptorTrimmed = receptor.Trim();
                            Socket recipientSocket = userNames.FirstOrDefault(x => x.Value == receptorTrimmed).Key;
                            if (recipientSocket != null && socketsGrupo.Contains(recipientSocket))
                            {
                                byte[] sendData = Encoding.UTF8.GetBytes(receivedMessage);
                                recipientSocket.Send(sendData);
                            }
                        }
                    }
                    if (receivedMessage.StartsWith("desconectar:"))
                    {
                        string usuario = receivedMessage.Split(':')[1];
                        Socket userSocket = userNames.FirstOrDefault(x => x.Value == usuario).Key;
                        if (userSocket != null)
                        {
                            userNames.Remove(userSocket);
                            SendDisconnectMessage(usuario);
                            SendUserList();
                            break;
                        }
                    }
                    else
                    {
                        byte[] sendData = Encoding.UTF8.GetBytes(receivedMessage);
                        foreach (Socket connection in connections)
                        {
                            if (connection.Connected)
                            {
                                connection.Send(sendData);
                            }
                        }
                    }
                }
            }
        }

        static void SendUserList()
        {
            List<string> connectedUserNames = userNames.Values.ToList();
            string userListMessage = "user_lists:" + string.Join(",", connectedUserNames);
            Console.WriteLine(userListMessage);
            byte[] userListData = Encoding.UTF8.GetBytes(userListMessage);

            foreach (Socket connection in connections)
            {
                connection.Send(userListData);
            }
        }
        static void SendDisconnectMessage(string disconnectedUser)
        {
            string disconnectMessage = "disconnected:" + disconnectedUser;
            byte[] disconnectData = Encoding.UTF8.GetBytes(disconnectMessage);

            foreach (Socket connection in connections)
            {
                connection.Send(disconnectData);
            }
        }

    }
}
