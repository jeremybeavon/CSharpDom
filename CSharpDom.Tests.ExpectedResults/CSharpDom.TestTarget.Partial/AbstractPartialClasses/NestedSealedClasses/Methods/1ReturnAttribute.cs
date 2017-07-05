namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithMethodWith1ReturnAttribute
    {
        public sealed class Class
        {
            [return: Attribute1]
            public void Method()
            {
            }
        }
    }
}
