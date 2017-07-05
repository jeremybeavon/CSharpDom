namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Indexers
{
    public struct StructWithNestedAbstractPartialClassWithIndexerWith1AccessorAttribute
    {
        public abstract partial class Class
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
