using Multichat;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Multichat
{
    public class Cliente
    {
        private Socket clientSocket;
        private IPEndPoint endPoint;
        private string userName;
        private Inicio form;

        public void StartClient(string userName, Inicio form)
        {
            this.userName = userName;
            this.form = form;
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);
            clientSocket.Connect(endPoint);
            byte[] connectMessage = Encoding.ASCII.GetBytes(userName);
            clientSocket.Send(connectMessage);

            Thread receiveThread = new Thread(() => ReceiveMessages(form));
            receiveThread.Start();

        }

        public void SendMessages(string userName, string message)
        {
            string messageWithUser = userName + ": " + message;
            byte[] sendData = Encoding.UTF8.GetBytes(messageWithUser);
            clientSocket.Send(sendData);
        }
        public void SendPrivateMessage(string receptor, string message)
        {
            string privateMessage = "private_message:" + userName + ":" + receptor + ":" + message;
            byte[] sendData = Encoding.UTF8.GetBytes(privateMessage);
            clientSocket.Send(sendData);
        }

        public void SendGroupMessage(string grupo, string receptores, string message)
        {
            string groupMessage = "group_message:" + grupo + ":" + userName + ":" + receptores + "," + userName + ":" + message;
            byte[] sendData = Encoding.UTF8.GetBytes(groupMessage);
            clientSocket.Send(sendData);
        }

        public void SendCreateGroupMessage(string ngrupo, string receptores)
        {
            string groupMessage = "nuevo_grupo:" + ngrupo + userName + ":" + receptores + "," + userName;
            byte[] sendData = Encoding.UTF8.GetBytes(groupMessage);
            clientSocket.Send(sendData);
        }

        public void Disconnect(string usuario)
        {
            string privateMessage = "desconectar:" + usuario;
            byte[] sendData = Encoding.UTF8.GetBytes(privateMessage);
            clientSocket.Send(sendData);
        }

        private void ReceiveMessages(Inicio form)
        {
            while (true)
            {
                byte[] receiveData = new byte[1024];
                int dataSize = clientSocket.Receive(receiveData);
                if (dataSize > 0)
                {
                    string receivedMessage = Encoding.UTF8.GetString(receiveData, 0, dataSize);

                    if (receivedMessage.StartsWith("user_lists"))
                    {
                        form.Invoke((MethodInvoker)delegate
                        {
                            form.AgregarBotonUsuario(receivedMessage);
                        });
                    }

                    else if (receivedMessage.StartsWith("private_message"))
                    {
                        form.Invoke((MethodInvoker)delegate
                        {
                            form.PrivateMessage(receivedMessage);
                        });
                    }

                    else if (receivedMessage.StartsWith("crear_grupo"))
                    {
                        form.Invoke((MethodInvoker)delegate
                        {
                            form.AppendTo(receivedMessage);
                        });
                    }

                    else if (receivedMessage.StartsWith("group_message"))
                    {
                        form.Invoke((MethodInvoker)delegate
                        {
                            form.GroupMessage(receivedMessage);
                        });
                    }

                    else
                    {
                        form.Invoke((MethodInvoker)delegate
                        {
                            form.AppendTo(receivedMessage);
                        });
                    }
                }
            }
        }
    }
}
