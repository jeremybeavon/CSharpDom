namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Properties
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNewProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
