namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Properties
{
    public class ClassWithNestedStaticPartialClassWithPrivateProperty
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
