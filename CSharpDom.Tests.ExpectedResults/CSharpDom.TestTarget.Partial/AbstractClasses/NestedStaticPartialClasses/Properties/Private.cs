namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithPrivateProperty
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
