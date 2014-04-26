using System;
using Maple.Net;
using Averte.Maple;
using Averte.Net.Packet;
using System.Reflection;
using System.Diagnostics;
using Averte.Maple.Characters;

namespace Averte.Net
{
    public class MapleConnection : Session 
    {
        public static User User { get; private set; }
        public static MapleConnection Instance { get; private set; }

        public Character Character
        {
            get
            {
                return MapleConnection.User.Character;
            }
            set
            {
                MapleConnection.User.Character = value;
            }
        }

        public MapleConnection(string ip, ushort port)
            : base(ip, port)
        {
            MapleConnection.User = new User();
            MapleConnection.Instance = this;
        }

        public void Reconnect(UserState state, string ipAddress, ushort port)
        {
            Main.Instance.SetTab(Indexer.Connection);

            MapleConnection.User.State = state;

            base.Reconnect(ipAddress, port);
        }

        public override void OnHandshake()
        {
            switch (MapleConnection.User.State)
            {
                case UserState.Login:
                    {
                        this.Send(LoginPacket.Validate());
                        this.Send(LoginPacket.Initiate());

                        Main.Instance.SetTab(Indexer.Login);
                    }
                    break;

                case UserState.Game:
                    {
                        this.Send(InterPacket.MigrateIn());

                        Main.Instance.SetTab(Indexer.Field);
                    }
                    break;
            }
        }

        public override void OnPacket(InPacket inPacket)
        {
            MethodInfo method = MapleHandler.GetHandler(inPacket.OperationCode);

            if (method == null)
            {
                base.OnPacket(inPacket);
                return;
            }

            try
            {
                MapleHandler.GetCallback(method, this, inPacket)();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Packet handling exception: {0}", e.ToString(), 0);
            }
        }

        public override void OnDisconnect()
        {
            base.OnDisconnect();
        }
    }
}
