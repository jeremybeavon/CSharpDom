namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedSealedPartialClassWithExplicitInterfaceIndexerWith1AccessorAttribute
    {
        public sealed class Class : IInterfaceWithIndexer
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
