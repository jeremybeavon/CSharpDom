namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.Properties
{
    public struct StructWithNestedStaticClassWithInternalProperty
    {
        public static class Class
        {
            internal static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
