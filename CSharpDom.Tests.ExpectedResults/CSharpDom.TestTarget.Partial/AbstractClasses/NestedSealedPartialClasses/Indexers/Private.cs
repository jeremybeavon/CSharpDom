namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithPrivateIndexer
    {
        public sealed partial class Class
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
