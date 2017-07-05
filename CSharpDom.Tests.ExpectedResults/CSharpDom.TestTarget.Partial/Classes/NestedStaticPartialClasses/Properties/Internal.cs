namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Properties
{
    public class ClassWithNestedStaticPartialClassWithInternalProperty
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
