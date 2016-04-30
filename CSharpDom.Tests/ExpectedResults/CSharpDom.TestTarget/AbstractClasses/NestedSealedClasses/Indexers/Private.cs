namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedClassWithPrivateIndexer
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
