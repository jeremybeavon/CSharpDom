namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Properties
{
    public struct StructWithNestedStructWithPrivateProperty
    {
        public struct Struct
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
