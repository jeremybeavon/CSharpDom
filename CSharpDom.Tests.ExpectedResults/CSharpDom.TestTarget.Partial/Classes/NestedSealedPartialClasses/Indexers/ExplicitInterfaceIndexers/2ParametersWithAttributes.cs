namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedSealedPartialClassWithExplicitInterfaceIndexerWith2ParametersWithAttributes
    {
        public sealed class Class : IInterfaceWithIndexerWith2Parameters
        {
            string IInterfaceWithIndexerWith2Parameters.this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
