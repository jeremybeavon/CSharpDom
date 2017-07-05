namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedPartialClassWithNewProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
