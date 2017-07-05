namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithAttributes
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
