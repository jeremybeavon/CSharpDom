namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public static class StaticClassWithNestedPartialClassWithExplicitInterfaceIndexerWith2ParametersWithAttributes
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
