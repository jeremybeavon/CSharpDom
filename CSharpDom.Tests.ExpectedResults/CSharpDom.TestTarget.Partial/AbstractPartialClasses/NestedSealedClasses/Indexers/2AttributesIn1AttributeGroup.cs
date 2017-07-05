namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
