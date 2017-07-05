namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithProtectedInternalIndexer
    {
        public sealed partial class Class
        {
            protected internal string this[int index]
            {
                set { }
            }
        }
    }
}
