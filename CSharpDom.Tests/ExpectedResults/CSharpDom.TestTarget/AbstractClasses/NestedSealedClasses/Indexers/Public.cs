namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedClassWithPublicIndexer
    {
        public sealed class Class
        {
            public string this[int index]
            {
                set { }
            }
        }
    }
}
