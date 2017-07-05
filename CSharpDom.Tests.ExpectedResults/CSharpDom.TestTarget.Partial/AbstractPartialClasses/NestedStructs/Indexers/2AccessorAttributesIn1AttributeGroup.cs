namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedStructWithIndexerWithWith2AccessorAttributesIn1AttributeGroup
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
