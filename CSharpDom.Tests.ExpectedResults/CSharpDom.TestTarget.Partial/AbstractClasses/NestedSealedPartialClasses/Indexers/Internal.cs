namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithInternalIndexer
    {
        public sealed partial class Class
        {
            internal string this[int index]
            {
                set { }
            }
        }
    }
}
