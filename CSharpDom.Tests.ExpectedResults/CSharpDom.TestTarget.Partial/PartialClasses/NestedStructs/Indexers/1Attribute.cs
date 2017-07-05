namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Indexers
{
    public partial class PartialClassWithNestedStructWithIndexerWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
