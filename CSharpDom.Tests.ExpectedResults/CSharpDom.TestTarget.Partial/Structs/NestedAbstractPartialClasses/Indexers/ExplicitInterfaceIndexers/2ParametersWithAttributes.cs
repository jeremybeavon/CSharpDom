namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedAbstractPartialClassWithExplicitInterfaceIndexerWith2ParametersWithAttributes
    {
        public abstract class Class : IInterfaceWithIndexerWith2Parameters
        {
            string IInterfaceWithIndexerWith2Parameters.this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
