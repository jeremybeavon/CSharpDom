namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithProtectedIndexer
    {
        public sealed partial class Class
        {
            protected string this[int index]
            {
                set { }
            }
        }
    }
}
