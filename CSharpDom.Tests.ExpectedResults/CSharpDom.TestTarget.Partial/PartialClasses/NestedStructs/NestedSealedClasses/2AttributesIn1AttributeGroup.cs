namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedSealedClasses
{
    public partial class PartialClassWithNestedStructWithNestedSealedClassWith2AttributesIn1AttributeGroup
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
