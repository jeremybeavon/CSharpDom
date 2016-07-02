namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedEnums
{
    public struct StructWithNestedSealedClassWithNestedEnumWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public enum Enum
            {
            }
        }
    }
}
