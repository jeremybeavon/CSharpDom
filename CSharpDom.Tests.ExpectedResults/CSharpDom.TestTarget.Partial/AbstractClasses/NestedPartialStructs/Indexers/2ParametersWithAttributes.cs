namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Indexers
{
    public abstract class AbstractClassWithNestedStructWithIndexerWith2ParametersWithAttributes
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
