namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Indexers
{
    public static class StaticClassWithNestedClassWithNewIndexer
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
