namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Indexers
{
    public static class StaticClassWithNestedAbstractClassWithIndexerWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
