namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithSealedOverrideMethod
    {
        public abstract class Class : BaseClassWithMethod
        {
            public sealed override void Method()
            {
            }
        }
    }
}
