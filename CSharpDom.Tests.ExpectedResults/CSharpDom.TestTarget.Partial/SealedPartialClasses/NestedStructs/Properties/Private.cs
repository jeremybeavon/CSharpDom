namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Properties
{
    public sealed partial class SealedPartialClassWithNestedStructWithPrivateProperty
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
