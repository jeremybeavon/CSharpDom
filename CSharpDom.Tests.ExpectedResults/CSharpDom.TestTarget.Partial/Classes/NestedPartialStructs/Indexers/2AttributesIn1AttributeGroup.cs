namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Indexers
{
    public class ClassWithNestedStructWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
