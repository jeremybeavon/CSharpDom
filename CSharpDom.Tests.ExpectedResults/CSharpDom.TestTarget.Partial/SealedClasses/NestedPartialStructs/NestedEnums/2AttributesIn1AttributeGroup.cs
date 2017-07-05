namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedEnums
{
    public sealed class SealedClassWithNestedStructWithNestedEnumWith2AttributesIn1AttributeGroup
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
