namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Indexers
{
    public sealed partial class SealedPartialClassWithNestedClassWithNewVirtualIndexer
    {
        public class Class : BaseClassWithIndexer
        {
            public new virtual string this[int index]
            {
                set { }
            }
        }
    }
}
