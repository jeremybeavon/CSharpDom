namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Indexers
{
    public static class StaticClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            public string this[int index]
            {
                [Attribute1]
                [Attribute2]
                get { return default(string); }
                [Attribute1]
                [Attribute2]
                set { }
            }
        }
    }
}
