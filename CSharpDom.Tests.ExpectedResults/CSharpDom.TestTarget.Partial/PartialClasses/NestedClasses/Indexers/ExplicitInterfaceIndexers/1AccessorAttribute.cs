namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithNestedClassWithExplicitInterfaceIndexerWith1AccessorAttribute
    {
        public class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                [Attribute1]
                get { return default(string); }
                [Attribute1]
                set { }
            }
        }
    }
}
