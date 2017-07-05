namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Indexers
{
    public static class StaticClassWithNestedAbstractPartialClassWithIndexerWith1Attribute
    {
        public abstract partial class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
