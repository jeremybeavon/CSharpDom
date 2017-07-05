namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitInterfaceIndexerWith1Attribute
    {
        public class Class : IInterfaceWithIndexer
        {
            [Attribute1]
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
