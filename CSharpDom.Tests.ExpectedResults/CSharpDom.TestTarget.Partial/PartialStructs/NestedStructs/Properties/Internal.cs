namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Properties
{
    public partial struct PartialStructWithWithNestedStructWithInternalProperty
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
