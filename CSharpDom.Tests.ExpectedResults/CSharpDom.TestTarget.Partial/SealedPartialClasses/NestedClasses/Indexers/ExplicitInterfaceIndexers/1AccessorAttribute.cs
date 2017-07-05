namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithNestedClassWithExplicitInterfaceIndexerWith1AccessorAttribute
    {
        public class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                [Attribute1]
                get { return default(string); }
                [Attribute1]
                set { }
            }
        }
    }
}
