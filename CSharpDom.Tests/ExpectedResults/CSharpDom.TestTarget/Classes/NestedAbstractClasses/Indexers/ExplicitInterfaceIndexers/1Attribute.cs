namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith1Attribute
    {
        public abstract class Class : IInterfaceWithIndexer
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
