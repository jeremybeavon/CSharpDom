namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Properties
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNewStaticProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
