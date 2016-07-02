namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Indexers
{
    public struct StructWithNestedAbstractClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup
    {
        public abstract class Class
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
