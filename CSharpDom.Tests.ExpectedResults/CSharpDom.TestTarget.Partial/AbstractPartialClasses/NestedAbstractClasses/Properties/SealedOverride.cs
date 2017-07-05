namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Properties
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithSealedOverrideProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
