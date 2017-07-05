namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Indexers
{
    public static class StaticClassWithNestedPartialClassWithNewVirtualIndexer
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
