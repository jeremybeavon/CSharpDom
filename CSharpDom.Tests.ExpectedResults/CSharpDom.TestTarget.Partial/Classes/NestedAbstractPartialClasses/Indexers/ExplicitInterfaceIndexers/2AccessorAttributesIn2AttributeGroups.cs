namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedAbstractPartialClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups
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
