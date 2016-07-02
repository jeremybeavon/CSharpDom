namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedClassWithOverrideIndexer
    {
        public sealed class Class : BaseClassWithIndexer
        {
            public override string this[int index]
            {
                set { }
            }
        }
    }
}
