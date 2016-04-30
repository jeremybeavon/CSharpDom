namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Indexers
{
    public sealed class SealedClassWithNestedSealedClassWithPrivateIndexer
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
