namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedPartialClassWithExplicitInterfaceIndexerWith1AccessorAttribute
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
