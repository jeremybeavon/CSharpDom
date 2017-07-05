namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Properties
{
    public abstract partial class AbstractPartialClassWithNestedClassWithOverrideProperty
    {
        public class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
