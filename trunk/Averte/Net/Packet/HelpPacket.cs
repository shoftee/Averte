using System;
using Maple.Net;
using Averte.Maple.Characters;

namespace Averte.Net.Packet
{
    public static class HelpPacket
    {
        public static void DecodeCharacterStatistics(Character character, InPacket packet)
        {
            character.ID = packet.ReadInt();
            character.Name = packet.ReadString(13).Replace("\0", "");
            character.Gender = packet.ReadByte();
            character.Skin = packet.ReadByte();
            character.Face = packet.ReadInt();
            character.Hair = packet.ReadInt();

            for (int i = 0; i < 3; i++)
            {
                packet.ReadLong(); // Pet i's Unique ID.
            }

            character.Level = packet.ReadByte();
            character.Job = packet.ReadShort();
            character.Strength = packet.ReadShort();
            character.Dexterity = packet.ReadShort();
            character.Intelligence = packet.ReadShort();
            character.Luck = packet.ReadShort();
            character.CurrentHP = packet.ReadInt();
            character.MaxMP = packet.ReadInt();
            character.CurrentMP = packet.ReadInt();
            character.MaxMP = packet.ReadInt();
            character.AvailableAP = packet.ReadShort();

            bool separated = true;
            short job = character.Job;

            if ((job / 1000) == 1)
            {
                if ((((job % 1000) / 100) == 2) || (((job % 1000) / 100) == 4))
                {
                    separated = false;
                }
            }

            if (character.IsBeastTamer || job == 800 || ((job / 100) == 9) || (((job / 1000) == 2) && (((job % 1000) / 100)) == 1))
            {
                separated = false;
            }

            if (separated)
            {
                byte count = packet.ReadByte();

                for (byte b = 0; b < count; b++)
                {
                    byte advancement = packet.ReadByte();
                    int value = packet.ReadInt();

                    character.AvailableSP[advancement] = value;
                }
            }
            else
            {
                character.AvailableSP[0] = packet.ReadShort();
            }

            character.Experience = packet.ReadLong();
            character.Fame = packet.ReadInt();
            character.WeaponPoints = packet.ReadInt(); // Zero Weapon Points
            character.GachaponExperience = packet.ReadInt();
            character.FieldID = packet.ReadInt();
            character.SpawnPoint = packet.ReadByte();
            packet.ReadInt();
            packet.ReadShort();

            if (character.IsDemonSlayer || character.IsDemonAvenger || character.IsXenon || character.IsBeastTamer)
            {
                character.FaceMarking = packet.ReadInt();
            }

            packet.ReadByte(); // Fatigue
            packet.ReadInt(); // Current Date

            for (int i = 0; i < 6; i++)
            {
                packet.ReadInt(); // Traits (Total)
            }

            packet.ReadBytes(21);
            character.BattleExperience = packet.ReadInt();
            character.BattleRank = packet.ReadByte();
            character.BattlePoints = packet.ReadInt();
            packet.ReadByte();
            packet.ReadByte();
            packet.ReadInt();

            // Part Time Job
            {
                packet.ReadByte();
                packet.ReadReversedLong();
                packet.ReadInt();
                packet.ReadBool();
            }

            // Character Cards
            {
                for (int i = 0; i < 9; i++)
                {
                    packet.ReadInt();
                    packet.ReadByte();
                    packet.ReadInt();
                }
            }

            packet.ReadLong();
        }

        public static void DecodeCharacterAppearance(Character character, InPacket packet)
        {
            character.Gender = packet.ReadByte();
            character.Skin = packet.ReadByte();
            character.Face = packet.ReadInt();
            character.Job = (short)packet.ReadInt();
            packet.ReadBool(); // NOTE: In earlier versions, hair used to be an equip slot.
            character.Hair = packet.ReadInt();

            // Shown Layer
            {
                byte slot = packet.ReadByte();

                while (slot != byte.MaxValue)
                {
                    packet.ReadInt(); // Item Maple ID
                    slot = packet.ReadByte();
                }
            }

            // Hidden Layer 
            {
                byte slot = packet.ReadByte();

                while (slot != byte.MaxValue)
                {
                    packet.ReadInt(); // Item Maple ID
                    slot = packet.ReadByte();
                }
            }

            // Totem Layer
            {
                byte slot = packet.ReadByte();

                while (slot != byte.MaxValue)
                {
                    packet.ReadInt(); // Item Maple ID
                    slot = packet.ReadByte();
                }
            }

            packet.ReadInt(); // Cash Weapon Maple ID
            packet.ReadInt(); // Weapon Maple ID
            packet.ReadInt(); // Shield Maple ID
            packet.ReadBool(); // Mercedes Ears
            packet.ReadBytes(12); // Pets' Maple IDs

            if (character.IsDemonSlayer || character.IsDemonAvenger || character.IsXenon || character.IsBeastTamer)
            {
                character.FaceMarking = packet.ReadInt();
            }
            else if (character.IsZero)
            {
                packet.ReadBool();
            }

            if (character.IsBeastTamer)
            {
                if (packet.ReadBool())
                {
                    packet.ReadInt(); // Tale Effect
                }

                if (packet.ReadBool())
                {
                    packet.ReadInt(); // Ears Effect
                }
            }
        }

        public static void DecodeCharacterData(Character character, InPacket packet)
        {
            packet.ReadShort();

            for (int i = 0; i < 3; i++)
            {
                uint damageSeed = packet.ReadUInt();
            }

            ulong flags = packet.ReadULong();


        }
    }
}