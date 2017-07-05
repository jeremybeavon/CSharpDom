namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithSealedOverrideMethod
    {
        public sealed class Class : BaseClassWithMethod
        {
            public sealed override void Method()
            {
            }
        }
    }
}
