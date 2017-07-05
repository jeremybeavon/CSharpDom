namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed partial class SealedPartialClassWithNestedClassWithExplicitInterfaceIndexerWith2Parameters
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
