namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Properties
{
    public struct StructWithNestedStaticPartialClassWithPrivateProperty
    {
        public static partial class Class
        {
            private static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
