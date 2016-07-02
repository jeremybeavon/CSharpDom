namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Indexers
{
    public static class StaticClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [Attribute1]
            [Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
