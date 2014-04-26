using System;
using Maple.Net;

namespace Averte.Net.Packet
{
    public static class SocialPacket
    {
        public static byte[] JoinMapleChat(int chatId)
        {
            using (OutPacket p = new OutPacket(SendOps.MapleChat))
            {
                p.WriteByte(); // NOTE: Mode.
                p.WriteByte(); // NOTE: Unknown.
                p.WriteInt(chatId);
                p.WriteByte(); // NOTE: Unknown.

                return p.ToArray();
            }
        }

        public static byte[] MapleChatMessage(string sender, string text)
        {
            using (OutPacket p = new OutPacket(SendOps.MapleChat))
            {
                p.WriteByte(6); // NOTE: Mode.
                p.WriteString(sender);
                p.WriteString(text);

                return p.ToArray();
            }
        }
    }
}
