using System;
using System.Net;
using System.Net.Sockets;

namespace MCDynamite.Handlers
{
    public class ConnectionHandler
    {
        private static TcpListener _listener;

        public ConnectionHandler()
        {

        }

        public void StartListening()
        {
                try
                {
                    _listener = new TcpListener(IPAddress.Any, Server.getServer().port);
                    _listener.Start();
                    _listener.BeginAcceptTcpClient(AcceptCallback, _listener);
                }
                catch (SocketException e)
                {
                }
                catch (Exception e)
                {
                }
        }

        private static void AcceptCallback(IAsyncResult ar)
        {
            var listener2 = (TcpListener)ar.AsyncState;
            try
            {
                TcpClient clientSocket = listener2.EndAcceptTcpClient(ar);
                PlayerHandler.newPlayer(new Player(clientSocket));
            }
            catch (Exception e)
            {
                Server.getLogger().Log("A Connection error occured!");
            }

            if (Server.getServer().isRunning)
            {
                _listener.BeginAcceptTcpClient(AcceptCallback, _listener);
            }
        }
    }
}
