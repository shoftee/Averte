using System;

namespace Averte.Maple.Fields
{
    public class Field
    {
        public int MapleID { get; private set; }

        public FieldCharacters Characters { get; private set; }

        private int _objectIds;

        public Field(int mapleId)
        {
            this.MapleID = mapleId;

            this.Characters = new FieldCharacters(this);
        }

        public int AssignObjectID()
        {
            this._objectIds++;

            return this._objectIds;
        }
    }
}
