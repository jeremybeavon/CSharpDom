namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedPartialClassWithExplicitInterfaceIndexerWith2Parameters
    {
        public class Class : IInterfaceWithIndexerWith2Parameters
        {
            string IInterfaceWithIndexerWith2Parameters.this[int x, int y]
            {
                set { }
            }
        }
    }
}
