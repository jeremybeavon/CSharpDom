namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedPartialClassWithNewStaticProperty
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
