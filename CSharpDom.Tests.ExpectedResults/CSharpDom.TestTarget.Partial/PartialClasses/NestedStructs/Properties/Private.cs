namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Properties
{
    public partial class PartialClassWithNestedStructWithPrivateProperty
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
