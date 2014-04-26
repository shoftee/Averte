using System;

namespace Averte.Net
{
    public static class SendOps
    {
        public const ushort
            WorldListRequest = 0x0022,
            MigrateIn = 0x0027,
            Initiate = 0x0038,
            Validate = 0x003F,
            Login = 0x0040,
            SelectWorld = 0x0043,
            Pong = 0x0046,
            SelectCharacter = 0x0047,
            MapleChat = 0x012C;
    }

    public static class RecvOps
    {
        public const ushort
            Login = 0x0000,
            WorldInformation = 0x0009,
            CharacterList = 0x000A,
            Migrate = 0x000B,
            Ping = 0x0012,
            SetField = 0x0137,
            SpawnCharacter = 0x0178,
            MapleChat = 0x037E;
    }
}
