namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithPublicProperty
    {
        public static partial class Class
        {
            public static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
