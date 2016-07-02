namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Indexers
{
    public static class StaticClassWithNestedAbstractClassWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
