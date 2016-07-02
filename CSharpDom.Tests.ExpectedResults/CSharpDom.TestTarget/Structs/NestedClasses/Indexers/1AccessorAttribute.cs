namespace CSharpDom.TestTarget.Structs.NestedClasses.Indexers
{
    public struct StructWithNestedClassWithIndexerWith1AccessorAttribute
    {
        public class Class
        {
            public string this[int index]
            {
                [Attribute1]
                get { return default(string); }
                [Attribute1]
                set { }
            }
        }
    }
}
