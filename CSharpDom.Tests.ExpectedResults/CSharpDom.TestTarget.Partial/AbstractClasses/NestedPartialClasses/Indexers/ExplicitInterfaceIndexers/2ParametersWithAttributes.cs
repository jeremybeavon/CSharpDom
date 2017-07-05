namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithNestedPartialClassWithExplicitInterfaceIndexerWith2ParametersWithAttributes
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
