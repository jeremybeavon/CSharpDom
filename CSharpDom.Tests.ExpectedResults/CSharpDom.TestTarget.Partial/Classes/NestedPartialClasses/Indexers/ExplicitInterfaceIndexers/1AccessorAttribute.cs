namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedPartialClassWithExplicitInterfaceIndexerWith1AccessorAttribute
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
