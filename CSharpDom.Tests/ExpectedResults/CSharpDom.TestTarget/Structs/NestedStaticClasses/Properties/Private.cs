namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.Properties
{
    public struct StructWithNestedStaticClassWithPrivateProperty
    {
        public static class Class
        {
            private static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
