using System;
using Maple.Net;
using Averte.Net.Packet;

namespace Averte.Net.Handler
{
    public static class GeneralHandler
    {
        [PacketHandler(RecvOps.Ping)]
        public static void HandlePing(MapleConnection connection, InPacket packet)
        {
            connection.Send(GeneralPacket.Pong());
        }
    }
}
