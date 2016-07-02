namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedClassWithExplicitInterfaceIndexerWith1Attribute
    {
        public class Class : IInterfaceWithIndexer
        {
            [Attribute1]
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
