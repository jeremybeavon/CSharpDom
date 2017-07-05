namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Properties
{
    public struct StructWithNestedStructWithStaticProperty
    {
        public struct Struct
        {
            public static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
