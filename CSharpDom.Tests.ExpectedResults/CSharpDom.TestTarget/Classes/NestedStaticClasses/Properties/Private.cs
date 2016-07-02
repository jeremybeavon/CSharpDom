namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.Properties
{
    public class ClassWithNestedStaticClassWithPrivateProperty
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
