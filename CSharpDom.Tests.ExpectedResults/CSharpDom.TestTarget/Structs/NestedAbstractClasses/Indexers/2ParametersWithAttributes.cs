namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Indexers
{
    public struct StructWithNestedAbstractClassWithIndexerWith2ParametersWithParameters
    {
        public abstract class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
