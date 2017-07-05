namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Indexers
{
    public static class StaticClassWithNestedSealedPartialClassWithIndexerWith2ParametersWithAttributes
    {
        public sealed partial class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
