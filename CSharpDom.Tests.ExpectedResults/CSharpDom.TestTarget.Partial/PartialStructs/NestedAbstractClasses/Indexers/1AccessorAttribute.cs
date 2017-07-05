namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Indexers
{
    public partial struct PartialStructWithWithNestedAbstractClassWithIndexerWith1AccessorAttribute
    {
        public abstract class Class
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
