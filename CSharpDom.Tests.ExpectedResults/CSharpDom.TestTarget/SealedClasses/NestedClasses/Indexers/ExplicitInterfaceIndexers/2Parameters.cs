namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedClassWithExplicitInterfaceIndexerWith2Parameters
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
