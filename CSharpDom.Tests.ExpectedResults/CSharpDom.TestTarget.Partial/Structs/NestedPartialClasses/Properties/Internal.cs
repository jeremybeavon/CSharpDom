namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Properties
{
    public struct StructWithNestedPartialClassWithInternalProperty
    {
        public partial class Class
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
