namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Indexers
{
    public sealed class SealedClassWithNestedAbstractClassWithInternalIndexer
    {
        public abstract class Class
        {
            internal string this[int index]
            {
                set { }
            }
        }
    }
}
