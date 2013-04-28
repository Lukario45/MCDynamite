using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MCDynamite.Net;

namespace MCDynamite
{
    public class Player : Entity
    {
        public Thread pThread = new Thread(new ThreadStart(whileOnline));

        public static string name;
        public static string ip;
        public static bool dead = false;
        public bool threadRunning = false;

        public override void onDeath()
        {
        }

        public override void onSpawn()
        {
        }

        public static void onConnect()
        {
            Packet.Write(new Packets().LoginRequest, new PacketStream()); //i have no idea what i'm doing
            Packet.Write(new Packets().Handshake, new PacketStream());
        }

        public override int health
        {
            get { return 100; }
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
                Logging.Logger.Log(name + " disconnected.");
            }
        }
    }
}
