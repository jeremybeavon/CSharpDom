namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Properties
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithStaticProperty
    {
        public sealed class Class
        {
            public static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
