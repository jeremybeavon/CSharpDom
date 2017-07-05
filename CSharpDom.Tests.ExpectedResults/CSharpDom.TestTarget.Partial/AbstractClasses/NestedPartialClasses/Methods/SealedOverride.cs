namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedPartialClassWithSealedOverrideMethod
    {
        public class Class : BaseClassWithMethod
        {
            public sealed override void Method()
            {
            }
        }
    }
}
