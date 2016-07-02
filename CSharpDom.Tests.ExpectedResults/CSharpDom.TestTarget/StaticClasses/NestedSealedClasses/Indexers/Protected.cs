namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Indexers
{
    public static class StaticClassWithNestedSealedClassWithProtectedIndexer
    {
        public sealed class Class
        {
            protected string this[int index]
            {
                set { }
            }
        }
    }
}
