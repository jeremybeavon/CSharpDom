namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNewIndexer
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
