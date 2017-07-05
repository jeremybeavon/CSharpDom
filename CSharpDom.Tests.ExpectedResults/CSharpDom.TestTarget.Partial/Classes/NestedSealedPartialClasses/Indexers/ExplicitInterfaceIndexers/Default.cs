namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithNestedSealedPartialClassWithExplicitInterfaceIndexer
    {
        public sealed class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
