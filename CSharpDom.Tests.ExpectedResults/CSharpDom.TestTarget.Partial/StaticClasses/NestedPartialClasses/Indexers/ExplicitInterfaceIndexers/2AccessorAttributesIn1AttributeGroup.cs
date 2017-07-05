namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedPartialClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup
    {
        public class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                [Attribute1, Attribute2]
                get { return default(string); }
                [Attribute1, Attribute2]
                set { }
            }
        }
    }
}
