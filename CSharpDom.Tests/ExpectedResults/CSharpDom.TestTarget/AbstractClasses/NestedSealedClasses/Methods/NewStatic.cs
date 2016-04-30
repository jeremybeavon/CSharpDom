namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Methods
{
    public abstract class AbstractClassWithNestedSealedClassWithNewStaticMethod
    {
        public sealed class Class : BaseClassWithMethod
        {
            public new static void Method()
            {
            }
        }
    }
}
