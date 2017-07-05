namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Properties
{
    public partial class PartialClassWithNestedStructWithInternalProperty
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
