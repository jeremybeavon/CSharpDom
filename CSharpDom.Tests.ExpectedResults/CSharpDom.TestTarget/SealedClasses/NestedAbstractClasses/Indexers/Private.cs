namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Indexers
{
    public sealed class SealedClassWithNestedAbstractClassWithPrivateIndexer
    {
        public abstract class Class
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
