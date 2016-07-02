namespace CSharpDom.TestTarget.Classes.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedClassWithExplicitInterfaceIndexerWith1Attribute
    {
        public class Class : IInterfaceWithIndexer
        {
            [Attribute1]
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
