namespace CSharpDom.TestTarget.Classes.NestedClasses.Methods
{
    public class ClassWithNestedClassWithSealedOverrideMethod
    {
        public class Class : BaseClassWithMethod
        {
            public sealed override void Method()
            {
            }
        }
    }
}
