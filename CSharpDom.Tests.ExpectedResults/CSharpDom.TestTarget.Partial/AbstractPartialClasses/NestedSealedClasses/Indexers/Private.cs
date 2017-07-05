namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithPrivateIndexer
    {
        public sealed class Class
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
