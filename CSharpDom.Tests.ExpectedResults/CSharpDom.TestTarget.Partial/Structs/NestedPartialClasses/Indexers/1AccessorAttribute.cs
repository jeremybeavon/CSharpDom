namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Indexers
{
    public struct StructWithNestedPartialClassWithIndexerWith1AccessorAttribute
    {
        public partial class Class
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
