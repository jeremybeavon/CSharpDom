namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedAbstractPartialClassWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            public abstract class NestedClass
            {
            }
        }
    }
}
