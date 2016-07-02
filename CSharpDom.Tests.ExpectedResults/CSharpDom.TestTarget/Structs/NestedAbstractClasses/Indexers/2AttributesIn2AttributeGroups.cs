namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Indexers
{
    public struct StructWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [Attribute1]
            [Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
