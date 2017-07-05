namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithNestedPartialClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
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
