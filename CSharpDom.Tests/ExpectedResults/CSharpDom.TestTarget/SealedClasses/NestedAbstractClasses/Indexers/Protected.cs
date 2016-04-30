namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Indexers
{
    public sealed class SealedClassWithNestedAbstractClassWithProtectedIndexer
    {
        public abstract class Class
        {
            protected string this[int index]
            {
                set { }
            }
        }
    }
}
