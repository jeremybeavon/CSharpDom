namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Methods
{
    public sealed class SealedClassWithNestedAbstractClassWithSealedOverrideMethod
    {
        public abstract class Class : BaseClassWithMethod
        {
            public sealed override void Method()
            {
            }
        }
    }
}
