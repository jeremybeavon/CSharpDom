namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedPartialClassWithExplicitInterfaceIndexerWith2ParametersWithAttributes
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
