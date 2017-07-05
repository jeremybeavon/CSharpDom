namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Indexers
{
    public static class StaticClassWithNestedPartialClassWithNewIndexer
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
