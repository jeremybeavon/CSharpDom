namespace CSharpDom.TestTarget.Structs.NestedStructs.Indexers
{
    public struct StructWithNestedStructWithIndexerWith2ParametersWithModifiers
    {
        public struct Struct
        {
            public string this[params string[] descriptions]
            {
                set { }
            }
        }
    }
}
