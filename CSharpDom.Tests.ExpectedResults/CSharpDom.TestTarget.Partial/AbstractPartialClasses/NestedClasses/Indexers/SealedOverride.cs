namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedClassWithSealedOverrideIndexer
    {
        public class Class : BaseClassWithIndexer
        {
            public sealed override string this[int index]
            {
                set { }
            }
        }
    }
}
