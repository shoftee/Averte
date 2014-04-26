using Maple.Collections;
using System;

namespace Averte.Maple.Fields
{
    public abstract class FieldObjects<T> : NumericalKeyedCollection<T> where T : FieldObject
    {
        public Field Field { get; private set; }

        public FieldObjects(Field parent)
        {
            this.Field = parent;
        }

        protected override int GetKeyForItem(T item)
        {
            return item.ObjectID;
        }

        protected override void InsertItem(int index, T item)
        {
            item.Field = this.Field;
            item.ObjectID = this.Field.AssignObjectID();

            base.InsertItem(index, item);
        }

        protected override void RemoveItem(int index)
        {
            T item = this.GetAtIndex(index);

            item.Field = null;
            item.ObjectID = -1;

            base.RemoveItem(index);
        }
    }
}
