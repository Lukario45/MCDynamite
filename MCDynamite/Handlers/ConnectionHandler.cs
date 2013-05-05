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
                    break;
                }
                catch (SocketException e)
                {
                    Logging.Logger.Log("Error Code: " + e.ErrorCode);
                    break;
                }
                catch (Exception e)
                {
                    Logging.Logger.Log("An error occured!");
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
                Logging.Logger.Log("A Connection error occured!");
            }

            if (Server.getServer().isRunning)
            {
                _listener.BeginAcceptTcpClient(AcceptCallback, _listener);
            }
        }
    }
}
