namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedStructWithIndexerWith2ParametersWithAttributes
    {
        public struct Struct
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
