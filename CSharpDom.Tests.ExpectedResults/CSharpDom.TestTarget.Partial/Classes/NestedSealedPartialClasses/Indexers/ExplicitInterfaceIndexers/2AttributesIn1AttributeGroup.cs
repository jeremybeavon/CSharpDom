namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedSealedPartialClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup
    {
        public sealed class Class : IInterfaceWithIndexer
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
