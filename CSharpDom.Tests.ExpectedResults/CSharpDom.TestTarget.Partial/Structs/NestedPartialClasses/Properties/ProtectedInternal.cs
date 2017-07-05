namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Properties
{
    public struct StructWithNestedPartialClassWithProtectedInternalProperty
    {
        public partial class Class
        {
            protected internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
