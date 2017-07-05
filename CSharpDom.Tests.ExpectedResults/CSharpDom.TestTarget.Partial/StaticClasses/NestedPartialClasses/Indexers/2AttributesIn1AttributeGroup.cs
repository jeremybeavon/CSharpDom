namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Indexers
{
    public static class StaticClassWithNestedPartialClassWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        public partial class Class
        {
            [Attribute1, Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
