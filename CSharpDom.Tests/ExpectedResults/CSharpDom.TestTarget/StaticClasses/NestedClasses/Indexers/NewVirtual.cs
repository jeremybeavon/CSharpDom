namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Indexers
{
    public static class StaticClassWithNestedClassWithNewVirtualIndexer
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
