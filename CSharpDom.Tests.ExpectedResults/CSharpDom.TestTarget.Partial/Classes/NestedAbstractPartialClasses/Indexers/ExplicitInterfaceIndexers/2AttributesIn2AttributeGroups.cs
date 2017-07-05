namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedAbstractPartialClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups
    {
        public abstract class Class : IInterfaceWithIndexer
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
