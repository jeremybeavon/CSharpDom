namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Indexers
{
    public sealed class SealedClassWithNestedAbstractClassWithProtectedInternalIndexer
    {
        public abstract class Class
        {
            protected internal string this[int index]
            {
                set { }
            }
        }
    }
}
