namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Properties
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNewStaticProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
