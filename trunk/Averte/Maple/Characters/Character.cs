using Averte.Maple.Fields;
using System;

namespace Averte.Maple.Characters
{
    public class Character : FieldObject
    {
        public int Index { get; set; }

        public int ID { get; set; }
        public string Name { get; set; }
        public byte Gender { get; set; }
        public byte Skin { get; set; }
        public int Face { get; set; }
        public int Hair { get; set; }
        public byte Level { get; set; }
        public byte PortalCount { get; set; }
        public short Job { get; set; }
        public short Strength { get; set; }
        public short Dexterity { get; set; }
        public short Intelligence { get; set; }
        public short Luck { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int CurrentMP { get; set; }
        public int MaxMP { get; set; }
        public short AvailableAP { get; set; }
        public int[] AvailableSP { get; set; }
        public long Experience { get; set; }
        public int Fame { get; set; }
        public int WeaponPoints { get; set; }
        public int GachaponExperience { get; set; }
        public int FieldID { get; set; }
        public byte SpawnPoint { get; set; }
        public short Subcategory { get; set; }
        public int FaceMarking { get; set; }
        public int BattleExperience { get; set; }
        public byte BattleRank { get; set; }
        public int BattlePoints { get; set; }

        public string AvatarUrl { get; set; }

        public Character()
        {
            this.AvailableSP = new int[10];
        }

        public bool IsDemonSlayer
        {
            get
            {
                return this.Job == 3001 || (this.Job >= 3100 && this.Job <= 3112 && this.Job != 3101);
            }
        }

        public bool IsDemonAvenger
        {
            get
            {
                return this.Job == 3001 || this.Job == 3101 || (this.Job >= 3120 && this.Job <= 3122);
            }
        }

        public bool IsXenon
        {
            get
            {
                return this.Job == 3002 || (this.Job >= 3600 && this.Job <= 3612);
            }
        }

        public bool IsZero
        {
            get
            {
                return this.Job == 10000 || (this.Job >= 10100 && this.Job <= 10112);
            }
        }

        public bool IsBeastTamer
        {
            get
            {
                return this.Job == 11212; // NOTE: Wat.
            }
        }
    }
}
