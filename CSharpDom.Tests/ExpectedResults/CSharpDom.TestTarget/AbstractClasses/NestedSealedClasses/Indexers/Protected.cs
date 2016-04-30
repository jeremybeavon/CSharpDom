namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedClassWithProtectedIndexer
    {
        public sealed class Class
        {
            protected string this[int index]
            {
                set { }
            }
        }
    }
}
