namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedEnums
{
    public abstract class AbstractClassWithNestedStructWithNestedEnumWith2AttributesIn1AttributeGroup
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
