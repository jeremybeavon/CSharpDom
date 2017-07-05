namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Indexers
{
    public partial class PartialClassWithNestedStructWithIndexerWith1AccessorAttribute
    {
        public struct Struct
        {
            public string this[int index]
            {
                [Attribute1]
                get { return default(string); }
                [Attribute1]
                set { }
            }
        }
    }
}
