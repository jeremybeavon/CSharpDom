namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedSealedPartialClassWith2AttributesIn1AttributeGroup
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
