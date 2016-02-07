using System;

namespace CSharpDom.TestTarget
{
    [AttributeUsage(AttributeTargets.All)]
    public sealed class Attribute1Attribute : Attribute
    {
        public int IntegerField;
        public string StringField;
        public Type TypeField;

        public Attribute1Attribute()
        {
        }

        public Attribute1Attribute(int integer)
        {
        }

        public Attribute1Attribute(string @string)
        {
        }

        public int IntegerProperty { get; set; }
    }
}
