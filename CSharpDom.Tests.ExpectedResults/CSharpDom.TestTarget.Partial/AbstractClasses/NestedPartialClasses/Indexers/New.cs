namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Indexers
{
    public abstract class AbstractClassWithNestedPartialClassWithNewIndexer
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
