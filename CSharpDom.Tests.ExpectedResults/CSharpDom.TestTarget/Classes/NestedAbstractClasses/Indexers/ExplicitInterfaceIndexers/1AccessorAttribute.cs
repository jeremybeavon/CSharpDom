namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith1AccessorAttribute
    {
        public abstract class Class : IInterfaceWithIndexer
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
