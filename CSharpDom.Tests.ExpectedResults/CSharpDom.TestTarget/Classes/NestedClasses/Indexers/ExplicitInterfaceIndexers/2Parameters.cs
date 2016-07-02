namespace CSharpDom.TestTarget.Classes.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedClassWithExplicitInterfaceIndexerWith2Parameters
    {
        public class Class : IInterfaceWithIndexerWith2Parameters
        {
            string IInterfaceWithIndexerWith2Parameters.this[int x, int y]
            {
                set { }
            }
        }
    }
}
