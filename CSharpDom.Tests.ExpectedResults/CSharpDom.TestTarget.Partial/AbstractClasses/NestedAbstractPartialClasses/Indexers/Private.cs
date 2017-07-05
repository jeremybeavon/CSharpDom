namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Indexers
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithPrivateIndexer
    {
        public abstract partial class Class
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
