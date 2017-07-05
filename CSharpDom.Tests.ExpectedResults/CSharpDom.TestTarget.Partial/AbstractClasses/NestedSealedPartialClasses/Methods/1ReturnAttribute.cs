namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithMethodWith1ReturnAttribute
    {
        public sealed partial class Class
        {
            [return: Attribute1]
            public void Method()
            {
            }
        }
    }
}
