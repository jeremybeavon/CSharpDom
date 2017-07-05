namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNewIndexer
    {
        public class Class : BaseClassWithIndexer
        {
            public new string this[int index]
            {
                set { }
            }
        }
    }
}
