using System;
using Maple.Net;
using System.Windows.Forms;
using Averte.Net.Packet;

namespace Averte.Net.Handler
{
    public static class SocialHandler
    {
        [PacketHandler(RecvOps.MapleChat)]
        public static void HandleMapleChat(MapleConnection connection, InPacket packet)
        {
            MapleChatMode mode = (MapleChatMode)packet.ReadByte();

            switch (mode)
            {
                case MapleChatMode.InviteReceive:
                    {
                        if (MapleChat.Instance != null)
                        {
                            return; // NOTE: Invite is automatically ignored while being in a chat session.
                        }

                        string sender = packet.ReadString();
                        byte unknown1 = packet.ReadByte();
                        MapleChat.ID = packet.ReadInt();
                        byte unknown2 = packet.ReadByte();

                        DialogResult result = Main.Instance.Notify(sender + " has invited you to a chat. Would you like to join?", "Maple Chat", 0, false, true);

                        if (result == DialogResult.Yes)
                        {
                            connection.Send(SocialPacket.JoinMapleChat(MapleChat.ID));
                        }
                    }
                    break;

                case MapleChatMode.InviteSent:
                    {

                    }
                    break;
            }
        }
    }
}
