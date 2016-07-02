namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers
{
    public sealed class SealedClassWithNestedClassWithNewVirtualIndexer
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
