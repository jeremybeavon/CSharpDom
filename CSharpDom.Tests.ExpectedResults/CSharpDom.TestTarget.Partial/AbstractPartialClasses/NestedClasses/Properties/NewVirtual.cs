namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Properties
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNewVirtualProperty
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
