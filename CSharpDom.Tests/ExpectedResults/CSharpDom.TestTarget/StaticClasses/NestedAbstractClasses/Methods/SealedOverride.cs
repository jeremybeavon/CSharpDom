namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Methods
{
    public static class StaticClassWithNestedAbstractClassWithSealedOverrideMethod
    {
        public abstract class Class : BaseClassWithMethod
        {
            public sealed override void Method()
            {
            }
        }
    }
}
