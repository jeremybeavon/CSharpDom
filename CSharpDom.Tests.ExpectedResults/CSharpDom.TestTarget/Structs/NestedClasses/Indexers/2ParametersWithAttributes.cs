namespace CSharpDom.TestTarget.Structs.NestedClasses.Indexers
{
    public struct StructWithNestedClassWithIndexerWith2ParametersWithParameters
    {
        public class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
