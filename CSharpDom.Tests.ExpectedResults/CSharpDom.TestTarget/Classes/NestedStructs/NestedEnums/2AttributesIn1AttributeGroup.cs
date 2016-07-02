namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedEnums
{
    public class ClassWithNestedStructWithNestedEnumWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public enum Enum
            {
            }
        }
    }
}
