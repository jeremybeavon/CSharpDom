namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedSealedPartialClassWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
