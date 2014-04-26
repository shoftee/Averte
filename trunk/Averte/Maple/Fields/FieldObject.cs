using System;

namespace Averte.Maple.Fields
{
    public class FieldObject
    {
        public Field Field { get; set; }
        public int ObjectID { get; set; }

        public FieldObject()
        {
            this.ObjectID = -1;
        }
    }
}
