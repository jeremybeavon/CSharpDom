namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedStructWithExplicitInterfaceIndexer
    {
        public struct Struct : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
