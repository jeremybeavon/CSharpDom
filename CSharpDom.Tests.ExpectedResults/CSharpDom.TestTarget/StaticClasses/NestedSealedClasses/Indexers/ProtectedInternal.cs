namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Indexers
{
    public static class StaticClassWithNestedSealedClassWithProtectedInternalIndexer
    {
        public sealed class Class
        {
            protected internal string this[int index]
            {
                set { }
            }
        }
    }
}
