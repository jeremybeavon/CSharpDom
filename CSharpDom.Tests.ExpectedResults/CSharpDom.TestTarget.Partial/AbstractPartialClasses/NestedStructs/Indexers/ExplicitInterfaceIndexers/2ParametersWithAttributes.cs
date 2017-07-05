namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public abstract partial class AbstractPartialClassWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithAttributes
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
