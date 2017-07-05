namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedStructWithIndexerWith1AccessorAttribute
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
