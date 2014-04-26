using System;
using Maple.Net;

namespace Averte.Net.Packet
{
    public static class LoginPacket
    {
        public static byte[] Validate()
        {
            using (OutPacket p = new OutPacket(SendOps.Validate))
            {
                p.WriteByte(Constants.Localisation);
                p.WriteUShort(Constants.MapleVersion);
                p.WriteShort(Constants.PatchLocation);

                return p.ToArray();
            }
        }

        public static byte[] Initiate()
        {
            using (OutPacket p = new OutPacket(SendOps.Initiate))
            {
                return p.ToArray();
            }
        }

        public static byte[] Login(string password, string authenticationToken)
        {
            using (OutPacket p = new OutPacket(SendOps.Login))
            {
                p.WriteString(password);
                p.WriteString(authenticationToken);
                p.WriteInt();
                p.WriteShort();
                p.WriteInt(MapleConnection.User.HardwareID_1);
                p.WriteInt();
                p.WriteInt(MapleConnection.User.HardwareID_2);
                p.WriteShort();
                p.WriteLong(2);

                return p.ToArray();
            }
        }

        public static byte[] RequestWorldList()
        {
            using (OutPacket p = new OutPacket(SendOps.WorldListRequest))
            {
                return p.ToArray();
            }
        }

        public static byte[] SelectWorld(byte worldId, byte channelId)
        {
            using (OutPacket p = new OutPacket(SendOps.SelectWorld))
            {
                p.WriteByte(2); // NOTE: Connection Type.
                p.WriteByte(worldId);
                p.WriteByte(channelId);
                p.WriteBytes(10, 0, 0, 1); // NOTE: IPv4 Address.

                return p.ToArray();
            }
        }

        public static byte[] SelectCharacter(string pic, int characterId)
        {
            using (OutPacket p = new OutPacket(SendOps.SelectCharacter))
            {
                p.WriteString(pic);
                p.WriteInt(characterId);
                p.WriteString("6-4-3-2-1-5");
                p.WriteEmpty(10);

                return p.ToArray();
            }
        }
    }
}
