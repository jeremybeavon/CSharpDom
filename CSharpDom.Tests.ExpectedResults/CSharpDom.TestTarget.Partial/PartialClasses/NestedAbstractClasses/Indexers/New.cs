namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Indexers
{
    public partial class PartialClassWithNestedAbstractClassWithNewIndexer
    {
        public abstract class Class : BaseClassWithIndexer
        {
            public new string this[int index]
            {
                set { }
            }
        }
    }
}
