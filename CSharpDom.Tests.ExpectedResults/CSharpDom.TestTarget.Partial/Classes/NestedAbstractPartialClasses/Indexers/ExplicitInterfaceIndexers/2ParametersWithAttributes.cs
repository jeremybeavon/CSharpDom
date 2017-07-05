namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedAbstractPartialClassWithExplicitInterfaceIndexerWith2ParametersWithAttributes
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
