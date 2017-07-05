namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Indexers
{
    public abstract class AbstractClassWithNestedPartialClassWithPrivateIndexer
    {
        public partial class Class
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
