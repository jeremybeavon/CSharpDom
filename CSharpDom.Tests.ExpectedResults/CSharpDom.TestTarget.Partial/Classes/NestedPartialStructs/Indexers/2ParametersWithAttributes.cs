namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Indexers
{
    public class ClassWithNestedStructWithIndexerWith2ParametersWithAttributes
    {
        public struct Struct
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
