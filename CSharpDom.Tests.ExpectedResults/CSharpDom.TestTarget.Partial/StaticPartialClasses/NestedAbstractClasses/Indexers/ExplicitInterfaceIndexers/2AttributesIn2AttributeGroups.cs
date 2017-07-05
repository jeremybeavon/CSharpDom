namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups
    {
        public abstract class Class : IInterfaceWithIndexer
        {
            [Attribute1]
            [Attribute2]
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
