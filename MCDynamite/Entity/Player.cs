using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MCDynamite.Net;
using System.Net;
using System.Net.Sockets;

namespace MCDynamite
{
    public class Player : Entity
    {
        public Thread pThread = new Thread(new ThreadStart(whileOnline));

        public static string name;
        public static string ip;
        public static bool dead = false;
        public bool threadRunning = false;
        public static bool verified = false;
        public static Player p;
        public static TcpClient pclient;
        public static Socket socket;
        public static NetworkStream stream;

        public Player(TcpClient client)
        {
            p = this;
            pclient = client;
            new Thread(onConnect).Start();
        }

        public static Player getPlayer()
        {
            return p;
        }

        public string getIP()
        {
            return ip;
        }

        public override void onDeath()
        {
            Packet.Write(new Packets().DestroyEntity, new PacketStream());
            onSpawn();
        }

        public override void onSpawn()
        {
            Packet.Write(new Packets().Respawn, new PacketStream());
        }

        public static void onConnect()
        {
            Packet.Write(new Packets().LoginRequest, new PacketStream()); //i have no idea what i'm doing
            HandleLogin();
            Packet.Write(new Packets().Handshake, new PacketStream());
            socket = pclient.Client;
            stream = pclient.GetStream();
            ip = socket.RemoteEndPoint.ToString().Split(':')[0];
            Server.getLogger().Log("[" + ip + "] " + name + " connected");
            HandleLogin();
            whileOnline();
        }

        public static void HandleLogin()
        {
            String rh = String.Empty;

            if (Server.getServer().online)
            {
                try
                {
                    using (WebClient web = new WebClient())
                    {
                        string response = web.DownloadString("http://session.minecraft.net/game/checkserver.jsp?user=" + name + "&serverId=" + rh);
                        verified = (response.Trim() == "YES");
                    }
                }
                catch { }
                if (!verified) { Kick("Failed to verify username!"); return; }
            }
            else
            {
                verified = true;
            }
        }

        public static void Kick(string reason)
        {
            Packet packet = new Packet();
            Packet.Write(new Packets().Kick, new PacketStream());
        }

        public override int hearts
        {
            get { return 20; } //10 hearts
        }

        public override MobType type
        {
            get { return MobType.Player; }
        }

        public static void whileOnline()
        {
            try
            {
                Packet.Write(new Packets().KeepAlive, new PacketStream()); //i have no idea what i'm doing
            } 
            catch
            {
                Packet.Write(new Packets().Kick, new PacketStream());
                Server.getLogger().Log(name + " disconnected.");
            }
        }

        public override int attack
        {
            get { return 4; } //2
        }
    }
}
