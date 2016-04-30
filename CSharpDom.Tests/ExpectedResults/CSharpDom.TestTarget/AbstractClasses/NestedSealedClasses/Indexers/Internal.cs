namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedClassWithInternalIndexer
    {
        public sealed class Class
        {
            internal string this[int index]
            {
                set { }
            }
        }
    }
}
