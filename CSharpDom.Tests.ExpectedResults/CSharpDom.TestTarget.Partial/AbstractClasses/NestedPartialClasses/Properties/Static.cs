namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedPartialClassWithStaticProperty
    {
        public partial class Class
        {
            public static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
