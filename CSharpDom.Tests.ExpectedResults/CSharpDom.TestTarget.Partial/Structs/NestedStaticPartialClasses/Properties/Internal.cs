namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Properties
{
    public struct StructWithNestedStaticPartialClassWithInternalProperty
    {
        public static partial class Class
        {
            internal static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
