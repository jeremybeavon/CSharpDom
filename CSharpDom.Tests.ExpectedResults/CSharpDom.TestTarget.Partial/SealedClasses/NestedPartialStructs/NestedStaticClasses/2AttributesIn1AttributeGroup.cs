namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStructWithNestedStaticPartialClassWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public static class NestedClass
            {
            }
        }
    }
}
