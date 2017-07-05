namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedPartialClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups
    {
        public class Class : IInterfaceWithIndexer
        {
            [Attribute1]
            [Attribute2]
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
