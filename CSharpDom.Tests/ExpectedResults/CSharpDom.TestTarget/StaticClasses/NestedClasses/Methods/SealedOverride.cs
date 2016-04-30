namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Methods
{
    public static class StaticClassWithNestedClassWithSealedOverrideMethod
    {
        public class Class : BaseClassWithMethod
        {
            public sealed override void Method()
            {
            }
        }
    }
}
