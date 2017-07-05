namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Indexers
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithIndexerWith1Attribute
    {
        public abstract partial class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
