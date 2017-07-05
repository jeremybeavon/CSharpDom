namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Indexers
{
    public static class StaticClassWithNestedAbstractPartialClassWithIndexerWith2ParametersWithAttributes
    {
        public abstract partial class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
