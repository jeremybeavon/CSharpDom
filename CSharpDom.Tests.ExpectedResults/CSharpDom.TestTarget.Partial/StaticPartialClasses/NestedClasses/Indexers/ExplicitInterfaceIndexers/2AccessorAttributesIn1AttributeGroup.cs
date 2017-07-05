namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup
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
