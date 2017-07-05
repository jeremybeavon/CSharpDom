namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithAttributes
    {
        public struct Struct : IInterfaceWithIndexerWith2Parameters
        {
            string IInterfaceWithIndexerWith2Parameters.this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
