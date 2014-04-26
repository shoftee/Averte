using System;

namespace Averte
{
    public static class Constants
    {
        public const string LoginAddress = "8.31.99.141";
        public const ushort LoginPort = 8484;

        public const byte Localisation = 8;
        public const ushort MapleVersion = 148;
        public const short PatchLocation = 3;
    }

    public enum Indexer : int
    {
        Connection,
        Login,
        WorldSelect,
        CharacterSelect,
        Field,
        CashShop,
        Farm
    }

    public enum UserState : byte
    {
        Login,
        Game,
        Shop,
        Farm
    }

    public enum LoginStatus : byte
    {
        Valid = 0,
        Banned = 2
    }

    public enum PicMode : byte
    {
        ChangeRecommended = 4
    }

    public enum MapleChatMode : byte
    {
        InviteReceive = 3,
        InviteSent = 4,
    }
}
