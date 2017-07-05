namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithInternalProperty
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
