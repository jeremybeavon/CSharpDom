namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedPartialClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups
    {
        public class Class : IInterfaceWithIndexer
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
