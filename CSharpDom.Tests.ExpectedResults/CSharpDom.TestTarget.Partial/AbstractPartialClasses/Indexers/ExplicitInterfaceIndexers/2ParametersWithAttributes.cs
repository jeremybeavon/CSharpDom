namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithExplicitInterfaceIndexerWith2ParametersWithAttributes : IInterfaceWithIndexerWith2Parameters
    {
        string IInterfaceWithIndexerWith2Parameters.this[[Attribute1]int x, [Attribute2][Attribute3]int y]
        {
            set { }
        }
    }
}
