namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedClassWithNewIndexer
    {
        public sealed class Class : BaseClassWithIndexer
        {
            public new string this[int index]
            {
                set { }
            }
        }
    }
}
