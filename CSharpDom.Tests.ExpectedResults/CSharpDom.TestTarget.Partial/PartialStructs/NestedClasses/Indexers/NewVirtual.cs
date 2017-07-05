namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Indexers
{
    public partial struct PartialStructWithWithNestedClassWithNewVirtualIndexer
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
