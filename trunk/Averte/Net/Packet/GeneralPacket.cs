using System;
using Maple.Net;

namespace Averte.Net.Packet
{
    public static class GeneralPacket
    {
        public static byte[] Pong()
        {
            using (OutPacket p = new OutPacket(SendOps.Pong))
            {
                p.WriteInt(Environment.TickCount);

                return p.ToArray();
            }
        }
    }
}
