using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment29
{
    public class CustomObject
    {
        private int _id;
        public int ID { get => _id; set => _id = value; }
        private string _name;
        public string Name { get => _name; set => _name = value; }
        public CustomObject(int id, string name)
        {
            this._name = name;
            this._id = id;
        }
        public override string ToString() => $"Object [ID: {ID}, Name: {Name}]";

        //public override bool Equals(object obj)
        //{
        //   CustomObject obj1 = obj as CustomObject;
        //   if (obj1 == null) { return false; }
        //   if (this._id == obj1._id) { return true; }
        //   return false;
        //   }
        public static bool operator ==(CustomObject obj1, CustomObject obj2)
        {
            if (!obj1.Equals(null) && !obj2.Equals(null))
            {
                if (obj1._id.Equals(obj2._id)) return true;

            }
            return false;
        }
        public static bool operator !=(CustomObject obj1, CustomObject obj2)
        {
            if (!obj1.Equals(null) && !obj2.Equals(null))
            {
                if (!obj1._id.Equals(obj2._id)) return true;

            }
            return false;
        }

    }
}