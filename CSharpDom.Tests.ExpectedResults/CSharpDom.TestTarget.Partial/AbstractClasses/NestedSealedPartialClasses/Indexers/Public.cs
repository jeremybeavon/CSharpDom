namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithPublicIndexer
    {
        public sealed partial class Class
        {
            public string this[int index]
            {
                set { }
            }
        }
    }
}
