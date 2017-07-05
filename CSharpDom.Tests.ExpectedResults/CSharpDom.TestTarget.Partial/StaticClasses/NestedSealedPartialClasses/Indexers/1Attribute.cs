namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Indexers
{
    public static class StaticClassWithNestedSealedPartialClassWithIndexerWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
