//Copyright (c) 2018 Yardi Technology Limited. Http://www.kooboo.com
//All rights reserved.
using Kooboo.IndexedDB.Helper;
using System;

namespace Kooboo.IndexedDB.Serializer.Simple.FieldConverter
{
    public class ObjectFieldConverter<T> : IFieldConverter<T>
    {
        private Func<T, object> getValue;
        private Action<T, object> setValue;

        public ObjectFieldConverter(string FieldName)
        {
            this.getValue = ObjectHelper.GetGetValue<T, object>(FieldName);
            this.setValue = ObjectHelper.GetSetValue<T, object>(FieldName);
            this.FieldNameHash = ObjectHelper.GetHashCode(FieldName);
        }

        public int ByteLength
        {
            get
            {
                return 0;
            }
        }

        public int FieldNameHash
        {
            get; set;
        }

        public void SetByteValues(T value, byte[] bytes)
        {
            object bytevalue = ValueConverter.FromObjectBytes(bytes);
            this.setValue(value, bytevalue);
        }

        public byte[] ToBytes(T Value)
        {
            object fieldvalue = this.getValue(Value);
            return ValueConverter.ObjectToTypes(fieldvalue);
        }
    }

    public class ObjectFieldConverter : IFieldConverter
    {
        private Func<object, object> getValue;
        private Action<object, object> setValue;

        public ObjectFieldConverter(string FieldName, Type ObjectType)
        {
            this.getValue = ObjectHelper.GetGetFieldValue<object>(FieldName, ObjectType);
            this.setValue = ObjectHelper.GetSetFieldValue<object>(FieldName, ObjectType);
            this.FieldNameHash = ObjectHelper.GetHashCode(FieldName);
        }

        public int ByteLength
        {
            get
            {
                return 0;
            }
        }

        public int FieldNameHash
        {
            get; set;
        }

        public void SetByteValues(object value, byte[] bytes)
        {
            object bytevalue = ValueConverter.FromObjectBytes(bytes);
            this.setValue(value, bytevalue);
        }

        public byte[] ToBytes(object Value)
        {
            object fieldvalue = this.getValue(Value);
            return ValueConverter.ObjectToTypes(fieldvalue);
        }
    }
}