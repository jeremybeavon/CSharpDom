namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Indexers
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithIndexerWith1AccessorAttribute
    {
        public abstract partial class Class
        {
            public string this[int index]
            {
                [Attribute1]
                get { return default(string); }
                [Attribute1]
                set { }
            }
        }
    }
}
