namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Properties
{
    public sealed class SealedClassWithNestedStaticPartialClassWithInternalProperty
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
