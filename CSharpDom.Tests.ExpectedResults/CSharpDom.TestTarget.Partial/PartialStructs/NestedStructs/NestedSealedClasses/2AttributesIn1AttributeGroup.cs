namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedStructWithNestedSealedClassWith2AttributesIn1AttributeGroup
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
