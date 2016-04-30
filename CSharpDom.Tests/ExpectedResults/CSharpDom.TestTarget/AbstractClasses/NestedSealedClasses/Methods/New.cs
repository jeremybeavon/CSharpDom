namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Methods
{
    public abstract class AbstractClassWithNestedSealedClassWithNewMethod
    {
        public sealed class Class : BaseClassWithMethod
        {
            public new void Method()
            {
            }
        }
    }
}
