namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Indexers
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithIndexerWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
