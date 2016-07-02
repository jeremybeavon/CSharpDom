namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Indexers
{
    public static class StaticClassWithNestedClassWithPrivateIndexer
    {
        public class Class
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
