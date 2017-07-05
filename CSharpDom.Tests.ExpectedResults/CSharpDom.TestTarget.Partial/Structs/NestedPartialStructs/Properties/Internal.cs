namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Properties
{
    public struct StructWithNestedStructWithInternalProperty
    {
        public struct Struct
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
