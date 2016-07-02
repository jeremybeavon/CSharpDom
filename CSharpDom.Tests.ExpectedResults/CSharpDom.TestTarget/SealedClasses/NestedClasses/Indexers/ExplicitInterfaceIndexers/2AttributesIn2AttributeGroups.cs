namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups
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
