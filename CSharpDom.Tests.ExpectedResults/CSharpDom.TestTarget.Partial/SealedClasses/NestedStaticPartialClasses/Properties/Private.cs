namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Properties
{
    public sealed class SealedClassWithNestedStaticPartialClassWithPrivateProperty
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
