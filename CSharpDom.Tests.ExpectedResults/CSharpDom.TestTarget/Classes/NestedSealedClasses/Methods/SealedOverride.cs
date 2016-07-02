namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Methods
{
    public class ClassWithNestedSealedClassWithSealedOverrideMethod
    {
        public sealed class Class : BaseClassWithMethod
        {
            public sealed override void Method()
            {
            }
        }
    }
}
