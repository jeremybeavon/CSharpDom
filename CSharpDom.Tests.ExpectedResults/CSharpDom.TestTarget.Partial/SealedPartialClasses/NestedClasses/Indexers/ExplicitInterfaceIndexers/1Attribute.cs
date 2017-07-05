namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithNestedClassWithExplicitInterfaceIndexerWith1Attribute
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
