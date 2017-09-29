namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Properties
{
    public partial struct PartialStructWithNestedStructWithPrivateProperty
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
