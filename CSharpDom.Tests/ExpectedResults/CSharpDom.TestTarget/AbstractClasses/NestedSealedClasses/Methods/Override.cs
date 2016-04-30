namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Methods
{
    public abstract class AbstractClassWithNestedSealedClassWithOverrideMethod
    {
        public sealed class Class : BaseClassWithMethod
        {
            public override void Method()
            {
            }
        }
    }
}
