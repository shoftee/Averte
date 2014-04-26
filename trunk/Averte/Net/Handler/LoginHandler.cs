using System;
using Maple.Net;
using Averte.Net.Packet;
using Averte.Maple.Characters;

namespace Averte.Net.Handler
{
    public static class LoginHandler
    {
        [PacketHandler(RecvOps.Login)]
        public static void HandleLogin(MapleConnection connection, InPacket packet)
        {
            LoginStatus status = (LoginStatus)packet.ReadByte();

            if (status == LoginStatus.Valid)
            {
                packet.Reset(packet.Length - 8);

                MapleConnection.User.SessionID = packet.ReadLong();

                connection.Send(LoginPacket.RequestWorldList());
            }
        }

        [PacketHandler(RecvOps.WorldInformation)]
        public static void HandleWorldInformation(MapleConnection connection, InPacket packet)
        {
            byte worldId = packet.ReadByte();

            if (worldId == byte.MaxValue)
            {
                Main.Instance.SetTab(Indexer.WorldSelect);
            }
            else
            {
                string name = packet.ReadString();

                Main.Instance.DrawWorldTile(worldId, name);
            }
        }

        [PacketHandler(RecvOps.CharacterList)]
        public static void HandleCharacterList(MapleConnection connection, InPacket packet)
        {
            bool viewAllCharacters = packet.ReadBool();
            byte count = packet.ReadByte();

            for (byte b = 0; b < count; b++)
            {
                Character character = new Character();

                character.Index = b;

                HelpPacket.DecodeCharacterStatistics(character, packet);
                HelpPacket.DecodeCharacterAppearance(character, packet);

                packet.ReadByte();

                if (packet.ReadBool())
                {
                    packet.ReadBytes(16); // NOTE: Ranking.
                }

                character.AvatarUrl = "http://direct.craftnet.nl/maplestory_get_rank_info.php?name=" + character.Name + "&get_character_image";

                Main.Instance.DrawCharacterTile(character);
            }

            MapleConnection.User.PicMode = (PicMode)packet.ReadByte();

            Main.Instance.SetTab(Indexer.CharacterSelect);
        }

        [PacketHandler(RecvOps.Migrate)]
        public static void HandleMigrate(MapleConnection connection, InPacket packet)
        {
            ushort status = packet.ReadUShort();

            if (status == 0)
            {
                string ip = string.Join(".", packet.ReadBytes(4));
                ushort port = packet.ReadUShort();

                packet.ReadBytes(6); // NOTE: Unknown.

                MapleConnection.User.ID = packet.ReadInt();
                MapleConnection.Instance.Reconnect(UserState.Game, ip, port);
            }
        }
    }
}
