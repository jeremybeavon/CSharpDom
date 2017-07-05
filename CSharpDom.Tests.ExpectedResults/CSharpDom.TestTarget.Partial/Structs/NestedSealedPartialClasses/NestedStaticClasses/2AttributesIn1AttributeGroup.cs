namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedStaticPartialClassWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            public static class NestedClass
            {
            }
        }
    }
}
