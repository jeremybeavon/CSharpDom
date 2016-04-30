namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedClassWithProtectedInternalIndexer
    {
        public sealed class Class
        {
            protected internal string this[int index]
            {
                set { }
            }
        }
    }
}
