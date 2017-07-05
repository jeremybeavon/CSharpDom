namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitInterfaceIndexer
    {
        public class Class : IInterfaceWithIndexer
        {
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
