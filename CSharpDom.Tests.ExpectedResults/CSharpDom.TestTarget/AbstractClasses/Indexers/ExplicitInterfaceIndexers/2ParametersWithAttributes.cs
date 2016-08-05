namespace CSharpDom.TestTarget.AbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithExplicitInterfaceIndexerWith2ParametersWithAttributes : IInterfaceWithIndexerWith2Parameters
    {
        string IInterfaceWithIndexerWith2Parameters.this[[Attribute1]int x, [Attribute2][Attribute3]int y]
        {
            set { }
        }
    }
}
