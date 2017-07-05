namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Indexers
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup
    {
        public abstract partial class Class
        {
            public string this[int index]
            {
                [Attribute1, Attribute2]
                get { return default(string); }
                [Attribute1, Attribute2]
                set { }
            }
        }
    }
}
