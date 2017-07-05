namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Indexers
{
    public abstract class AbstractClassWithNestedPartialClassWithInternalIndexer
    {
        public partial class Class
        {
            internal string this[int index]
            {
                set { }
            }
        }
    }
}
