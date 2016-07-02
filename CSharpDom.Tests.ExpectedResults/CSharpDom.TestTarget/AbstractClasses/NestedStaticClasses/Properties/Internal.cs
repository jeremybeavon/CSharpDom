namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Properties
{
    public abstract class AbstractClassWithNestedStaticClassWithInternalProperty
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
