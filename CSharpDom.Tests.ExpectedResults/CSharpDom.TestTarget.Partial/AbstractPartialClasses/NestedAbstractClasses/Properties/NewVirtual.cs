namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Properties
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNewVirtualProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
