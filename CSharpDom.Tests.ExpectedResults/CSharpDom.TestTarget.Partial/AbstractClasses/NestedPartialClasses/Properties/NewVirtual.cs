namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedPartialClassWithNewVirtualProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
