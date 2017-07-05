namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedClassWithOverrideIndexer
    {
        public class Class : BaseClassWithIndexer
        {
            public override string this[int index]
            {
                set { }
            }
        }
    }
}
