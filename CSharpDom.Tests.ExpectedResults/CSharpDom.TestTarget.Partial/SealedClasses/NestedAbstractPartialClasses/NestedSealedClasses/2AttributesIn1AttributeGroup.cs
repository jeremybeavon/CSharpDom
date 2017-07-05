namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedSealedPartialClassWith2AttributesIn1AttributeGroup
    {
        public abstract partial class Class
        {
            [Attribute1, Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
