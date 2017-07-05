namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Properties
{
    public struct StructWithNestedPartialClassWithPrivateProperty
    {
        public partial class Class
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
