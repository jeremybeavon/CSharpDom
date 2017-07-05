namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Indexers
{
    public abstract class AbstractClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups
    {
        public struct Struct
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
