namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedStructWithIndexerWith1Attribute
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
