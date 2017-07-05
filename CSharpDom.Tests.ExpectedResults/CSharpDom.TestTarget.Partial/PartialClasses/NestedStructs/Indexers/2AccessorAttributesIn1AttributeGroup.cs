namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Indexers
{
    public partial class PartialClassWithNestedStructWithIndexerWithWith2AccessorAttributesIn1AttributeGroup
    {
        public struct Struct
        {
            public string this[int index]
            {
                [Attribute1, Attribute2]
                get { return default(string); }
                [Attribute1, Attribute2]
                set { }
            }
        }
    }
}
