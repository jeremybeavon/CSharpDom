namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public static partial class StaticPartialClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups
    {
        public sealed class Class : IInterfaceWithIndexer
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
