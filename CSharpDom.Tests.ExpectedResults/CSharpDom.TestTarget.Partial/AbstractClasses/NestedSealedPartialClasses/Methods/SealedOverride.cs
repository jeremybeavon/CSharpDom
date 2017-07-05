namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithSealedOverrideMethod
    {
        public sealed class Class : BaseClassWithMethod
        {
            public sealed override void Method()
            {
            }
        }
    }
}
