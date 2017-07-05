namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Properties
{
    public struct StructWithNestedStructWithPublicProperty
    {
        public struct Struct
        {
            public string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
