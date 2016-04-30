namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Indexers
{
    public static class StaticClassWithNestedSealedClassWithPrivateIndexer
    {
        public sealed class Class
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
