namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups
    {
        public abstract class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                [Attribute1]
                [Attribute2]
                get { return default(string); }
                [Attribute1]
                [Attribute2]
                set { }
            }
        }
    }
}
