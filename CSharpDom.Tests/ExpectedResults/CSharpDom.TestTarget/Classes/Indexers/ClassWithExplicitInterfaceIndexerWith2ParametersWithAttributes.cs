namespace CSharpDom.TestTarget.Classes.Indexers
{
    public class ClassWithExplicitInterfaceIndexerWith2ParametersWithParameters : IInterfaceWithIndexerWith2Parameters
    {
        string IInterfaceWithIndexerWith2Parameters.this[[Attribute1]int x, [Attribute2][Attribute3]int y]
        {
            set { }
        }
    }
}
