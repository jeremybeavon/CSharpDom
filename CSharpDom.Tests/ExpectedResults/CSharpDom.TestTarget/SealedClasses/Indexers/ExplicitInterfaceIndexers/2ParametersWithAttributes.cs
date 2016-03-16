namespace CSharpDom.TestTarget.SealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithExplicitInterfaceIndexerWith2ParametersWithParameters : IInterfaceWithIndexerWith2Parameters
    {
        string IInterfaceWithIndexerWith2Parameters.this[[Attribute1]int x, [Attribute2][Attribute3]int y]
        {
            set { }
        }
    }
}
