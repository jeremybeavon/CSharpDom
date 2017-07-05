namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedEnums
{
    public struct StructWithNestedSealedPartialClassWithNestedEnumWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            public enum Enum
            {
            }
        }
    }
}
