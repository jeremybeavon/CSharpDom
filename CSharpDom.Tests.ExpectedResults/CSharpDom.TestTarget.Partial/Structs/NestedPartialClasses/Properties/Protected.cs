namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Properties
{
    public struct StructWithNestedPartialClassWithProtectedProperty
    {
        public partial class Class
        {
            protected string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
