namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Properties
{
    public sealed class SealedClassWithNestedStaticClassWithInternalProperty
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
