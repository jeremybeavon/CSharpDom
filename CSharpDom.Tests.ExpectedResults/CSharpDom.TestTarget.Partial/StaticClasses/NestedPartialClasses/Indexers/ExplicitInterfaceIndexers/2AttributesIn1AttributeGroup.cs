namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedPartialClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
    {
        public class Class : IInterfaceWithIndexer
        {
            [Attribute1, Attribute2]
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
