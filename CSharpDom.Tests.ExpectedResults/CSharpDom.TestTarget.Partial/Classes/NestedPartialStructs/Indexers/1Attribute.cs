namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Indexers
{
    public class ClassWithNestedStructWithIndexerWith1Attribute
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
