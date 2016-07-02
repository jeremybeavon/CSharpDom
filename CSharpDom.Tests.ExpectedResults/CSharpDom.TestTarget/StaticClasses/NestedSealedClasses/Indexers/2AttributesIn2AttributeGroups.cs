namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Indexers
{
    public static class StaticClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
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
