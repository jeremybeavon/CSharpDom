namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Methods
{
    public static class StaticClassWithNestedSealedClassWithSealedOverrideMethod
    {
        public sealed class Class : BaseClassWithMethod
        {
            public sealed override void Method()
            {
            }
        }
    }
}
