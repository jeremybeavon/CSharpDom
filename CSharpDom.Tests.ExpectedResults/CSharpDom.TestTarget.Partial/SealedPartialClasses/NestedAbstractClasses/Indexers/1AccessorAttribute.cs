namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Indexers
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithIndexerWith1AccessorAttribute
    {
        public abstract class Class
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
