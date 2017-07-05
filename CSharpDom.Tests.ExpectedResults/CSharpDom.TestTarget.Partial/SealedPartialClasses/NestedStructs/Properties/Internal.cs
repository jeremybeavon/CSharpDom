namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Properties
{
    public sealed partial class SealedPartialClassWithNestedStructWithInternalProperty
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
