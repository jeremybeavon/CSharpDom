namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Properties
{
    public sealed class SealedClassWithNestedStaticClassWithPrivateProperty
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
