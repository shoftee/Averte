using System;
using Maple.Net;

namespace Averte.Net.Packet
{
    public static class InterPacket
    {
        public static byte[] MigrateIn()
        {
            using (OutPacket p = new OutPacket(SendOps.MigrateIn))
            {
                p.WriteInt(6); // TODO: World ID.
                p.WriteInt(MapleConnection.User.ID);
                p.WriteHexString("00 30 67 62 18 18");
                p.WriteInt(MapleConnection.User.HardwareID_1);
                p.WriteInt();
                p.WriteInt(MapleConnection.User.HardwareID_2);
                p.WriteLong(MapleConnection.User.SessionID);

                return p.ToArray();
            }
        }
    }
}
