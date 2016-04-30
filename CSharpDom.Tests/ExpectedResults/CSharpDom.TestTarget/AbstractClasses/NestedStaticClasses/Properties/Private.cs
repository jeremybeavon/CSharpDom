namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Properties
{
    public abstract class AbstractClassWithNestedStaticClassWithPrivateProperty
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
