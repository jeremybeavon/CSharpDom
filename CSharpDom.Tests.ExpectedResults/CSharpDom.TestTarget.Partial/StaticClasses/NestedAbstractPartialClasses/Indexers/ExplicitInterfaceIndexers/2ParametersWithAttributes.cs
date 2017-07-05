namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedAbstractPartialClassWithExplicitInterfaceIndexerWith2ParametersWithAttributes
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
