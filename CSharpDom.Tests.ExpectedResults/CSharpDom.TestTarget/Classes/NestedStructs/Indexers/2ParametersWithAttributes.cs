namespace CSharpDom.TestTarget.Classes.NestedStructs.Indexers
{
    public class ClassWithNestedStructWithIndexerWith2ParametersWithParameters
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
