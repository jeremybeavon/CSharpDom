namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Properties
{
    public partial struct PartialStructWithNestedStructWithPublicProperty
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
