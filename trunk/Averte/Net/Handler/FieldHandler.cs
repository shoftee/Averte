using System;
using Maple.Net;
using Averte.Net.Packet;
using Averte.Maple.Characters;
using System.Drawing;

namespace Averte.Net.Handler
{
    public static class FieldHandler
    {
        [PacketHandler(RecvOps.SetField)]
        public static void HandleSetField(MapleConnection connection, InPacket packet)
        {
            connection.Character = new Character();

            ushort loopCount = packet.ReadUShort();

            for (int i = 0; i < loopCount; i++)
            {
                packet.ReadLong();
            }

            int gameServerId = packet.ReadInt();
            packet.ReadByte();
            packet.ReadInt();
            connection.Character.PortalCount = packet.ReadByte();
            packet.ReadInt();

            bool characterData = packet.ReadBool();

            if (characterData)
            {
                HelpPacket.DecodeCharacterData(connection.Character, packet);
            }
            else
            {

            }

            Main.Instance.SetField(new Bitmap(1500, 2000));
        }

        [PacketHandler(RecvOps.SpawnCharacter)]
        public static void HandleSpawnCharacter(MapleConnection connection, InPacket packet)
        {
            Character character = new Character();

            character.ID = packet.ReadInt();
            character.Level = packet.ReadByte();
            packet.ReadShort();
            character.Name = packet.ReadString();

            Main.Instance.DrawCharacterObject(character);
        }
    }
}
