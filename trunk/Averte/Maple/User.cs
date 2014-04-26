using Averte.Maple.Characters;
using System;
using System.Collections.Generic;

namespace Averte.Maple
{
    public class User
    {
        public UserState State { get; set; }

        public int ID { get; set; }
        public string Username { get; set; }
        public string Pin { get; set; }
        public string Pic { get; set; }
        public PicMode PicMode { get; set; }
        public long SessionID { get; set; }

        public int HardwareID_1 { get; private set; }
        public int HardwareID_2 { get; private set; }

        public Character Character { get; set; }

        public User()
        {
            this.State = UserState.Login; // NOTE: Initially it's login.

            this.HardwareID_1 = new Random().Next(0, int.MaxValue);
            this.HardwareID_2 = new Random().Next(0, short.MaxValue);
        }
    }
}
