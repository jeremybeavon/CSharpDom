namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Indexers
{
    public static class StaticClassWithNestedSealedClassWithInternalIndexer
    {
        public sealed class Class
        {
            internal string this[int index]
            {
                set { }
            }
        }
    }
}
