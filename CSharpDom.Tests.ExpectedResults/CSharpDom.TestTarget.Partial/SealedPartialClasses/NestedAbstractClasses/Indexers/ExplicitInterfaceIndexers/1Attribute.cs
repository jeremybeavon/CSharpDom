namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith1Attribute
    {
        public abstract class Class : IInterfaceWithIndexer
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
