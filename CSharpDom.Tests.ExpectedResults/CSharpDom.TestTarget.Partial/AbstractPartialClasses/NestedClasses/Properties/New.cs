namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Properties
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNewProperty
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
