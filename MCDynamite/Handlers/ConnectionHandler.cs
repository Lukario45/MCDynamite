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
            StartListening();
        }

        private static void StartListening()
        {
            while (Server.getServer().isRunning)
            {
                try
                {
                    _listener = new TcpListener(IPAddress.Any, Server.getServer().port);
                    _listener.Start();
                    _listener.BeginAcceptTcpClient(AcceptCallback, _listener);
                    Server.getLogger().Log("Successfully listening for connections!");
                    break;
                }
                catch (SocketException e)
                {
                    Server.getLogger().Log("Could not listen on port " + Server.getServer().port + "!");
                    break;
                }
                catch (Exception e)
                {
                    Server.getLogger().Log("An error occured!");
                }
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
