namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Properties
{
    public partial struct PartialStructWithWithNestedStructWithStaticProperty
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
