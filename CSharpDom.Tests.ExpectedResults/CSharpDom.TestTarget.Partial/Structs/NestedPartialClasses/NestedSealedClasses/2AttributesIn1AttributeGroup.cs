namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedPartialClassWithNestedSealedPartialClassWith2AttributesIn1AttributeGroup
    {
        public partial class Class
        {
            [Attribute1, Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
