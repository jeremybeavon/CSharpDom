namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Properties
{
    public sealed partial class SealedPartialClassWithNestedStructWithStaticProperty
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
