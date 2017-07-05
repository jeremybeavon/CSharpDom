namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedPartialClassWithExplicitInterfaceIndexerWith2ParametersWithAttributes
    {
        public class Class : IInterfaceWithIndexerWith2Parameters
        {
            string IInterfaceWithIndexerWith2Parameters.this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
